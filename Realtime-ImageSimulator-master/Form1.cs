using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ImageSimulator
{
    public partial class Form1 : Form
    {
        CopyFiles _fileWriter = null;
        bool _hasLoaded = false;
        public Form1()
        {
            InitializeComponent();
            this.textBox_PatientDirectory.Text = Properties.Settings.Default.PatientDirectory;
            this.textBox_Output.Text = Properties.Settings.Default.OuputDirectory;
            this.textBox_PreTreatment.Text = Properties.Settings.Default.PretreatmentDirectory;
            this.textBox_Treatment.Text = Properties.Settings.Default.TreatmentDirectory;
            this.textBox_Arc2.Text = Properties.Settings.Default.TreatmentArc2Directory;

            this.numericUpDown_Delay.Value = Properties.Settings.Default.DelaySeconds;
            this.numericUpDown_Frequency.Value = Properties.Settings.Default.FrequencyMS;
            _hasLoaded = true;
        }

        private void button_Pretreatment_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser(this.textBox_PreTreatment);
            Properties.Settings.Default.PretreatmentDirectory = this.textBox_PreTreatment.Text;
            Properties.Settings.Default.Save();
        }

        private void button_Treatment_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser(this.textBox_Treatment);
            Properties.Settings.Default.TreatmentDirectory = this.textBox_Treatment.Text;
            Properties.Settings.Default.Save();
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser(this.textBox_Output);
            Properties.Settings.Default.OuputDirectory = this.textBox_Output.Text;
            Properties.Settings.Default.Save();
        }

        void OpenFolderBrowser(TextBox textbox)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = textbox.Text;
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                textbox.Text = dialog.SelectedPath;
            }
        }

        void SaveDirectories()
        {
            Properties.Settings.Default.PretreatmentDirectory = this.textBox_PreTreatment.Text;
            Properties.Settings.Default.TreatmentDirectory = this.textBox_Treatment.Text;
            Properties.Settings.Default.TreatmentArc2Directory = this.textBox_Arc2.Text;
            Properties.Settings.Default.OuputDirectory = this.textBox_Output.Text;
            Properties.Settings.Default.PatientDirectory = this.textBox_PatientDirectory.Text;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_Frequency_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FrequencyMS = (int)this.numericUpDown_Frequency.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_Delay_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DelaySeconds = (int)this.numericUpDown_Delay.Value;
            Properties.Settings.Default.Save();
        }

        private void button_Arc2_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser(this.textBox_Arc2);
            Properties.Settings.Default.TreatmentArc2Directory = this.textBox_Arc2.Text;
            Trace.WriteLine("Arc 2 " + Properties.Settings.Default.TreatmentArc2Directory);
            Properties.Settings.Default.Save();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        void Start( )
        {
            if (!CheckDirectory(Properties.Settings.Default.PretreatmentDirectory, false))
                return;
            if (!CheckDirectory(Properties.Settings.Default.TreatmentDirectory, false))
                return;
            if (!CheckDirectory(Properties.Settings.Default.TreatmentArc2Directory, false))
                return;
            if (!CheckDirectory(Properties.Settings.Default.OuputDirectory, true))
                return;

            if (_fileWriter != null && _fileWriter.IsRunning && !_fileWriter.IsPaused)
            {
                MessageBox.Show("A simulation is already running.  You must stop it first.");
                return;
            }
            if (_fileWriter != null && _fileWriter.IsPaused)
                _fileWriter.IsPaused = false;
            else
            {
                _fileWriter = new CopyFiles(Properties.Settings.Default.PretreatmentDirectory, Properties.Settings.Default.TreatmentDirectory,
                                             Properties.Settings.Default.TreatmentArc2Directory, Properties.Settings.Default.OuputDirectory,
                                             Properties.Settings.Default.FrequencyMS, Properties.Settings.Default.DelaySeconds);
                _fileWriter.NewFileReceived += new NewFile(_fileWriter_NewFileReceived);
                _fileWriter.Start();
            }
        }

        void _fileWriter_NewFileReceived(string filename)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    this.toolStripStatusLabel_Filename.Text = filename;
                });
            }
            else
            {
                this.toolStripStatusLabel_Filename.Text = filename;
            }
        }

        bool CheckDirectory(string directory, bool bcreate)
        {
            if (!Directory.Exists(directory))
            {
                if( !bcreate )
                    MessageBox.Show("The directory " + directory + " does not exist");
                else 
                    Directory.CreateDirectory(directory);
                return false;
            }
            return true;
        }

        private void button_Pause_Click(object sender, EventArgs e)
        {
            if( _fileWriter != null )
                _fileWriter.IsPaused = true;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (_fileWriter != null)
            {
                _fileWriter.Stop();
                _fileWriter = null;
            }
        }

        private void button_NextImage_Click(object sender, EventArgs e)
        {
            if (_fileWriter == null)
                Start();
            _fileWriter.OneImage = true;
        }

        private void button_PatientDirectory_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser(this.textBox_PatientDirectory);
            Properties.Settings.Default.PatientDirectory = this.textBox_PatientDirectory.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox_PatientDirectory_TextChanged(object sender, EventArgs e)
        {
            if (!_hasLoaded)
                return;
            string directory = this.textBox_PatientDirectory.Text;
            string[] directories = Directory.GetDirectories(directory);
            bool outputFound = false;
            foreach (string dir in directories)
            {
                string dirLower = dir.ToLower();
                if (dirLower.Contains("pretreatment"))
                    this.textBox_PreTreatment.Text = dir;
                else if (dirLower.Contains("arc1"))
                    this.textBox_Treatment.Text = dir;
                else if (dirLower.Contains("arc2"))
                    this.textBox_Arc2.Text = dir;
                else if (dirLower.Contains("output"))
                {
                    this.textBox_Output.Text = dir;
                    outputFound = true;
                }
            }

            if (!outputFound)
            {
                var folder = new FolderBrowserDialog();
                string op = folder.SelectedPath + "\\Output";
                Directory.CreateDirectory(op);
                this.textBox_Output.Text = op;
            }
            SaveDirectories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Treatment_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TreatmentDirectory = textBox_Treatment.Text;
        }

        private void textBox_Arc2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TreatmentArc2Directory = textBox_Arc2.Text;
        }

        private void textBox_PreTreatment_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PretreatmentDirectory = textBox_PreTreatment.Text;
        }
    }
}
