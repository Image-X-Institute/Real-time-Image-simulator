using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageSimulator
{
    public delegate void NewFile( string filename );

    /// <summary>
    /// Copy the files from the input directories to the output directories
    /// </summary>
    public class CopyFiles
    {
        string _pretreatment = "";
        string _arc1 = "";
        string _arc2 = "";
        string _output = "";
        int _frequencyMS = 100;
        int _delaySec = 20;
        public event NewFile NewFileReceived;

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern bool CreateHardLink(
        string lpFileName,
        string lpExistingFileName,
        IntPtr lpSecurityAttributes
        );

            public CopyFiles(string pretreatment, string arc1, string arc2, string output, int frequencyMS, int delaySec)
        {
            _pretreatment = pretreatment;
            _arc1 = arc1;
            _arc2 = arc2;
            _output = output;
            _frequencyMS = frequencyMS;
            _delaySec = delaySec;
        }

        void MainControlThread()
        {
            _isRunning = true;

            RunArc(_pretreatment, "KIM-KV");
            if (_isRunning && !_isPaused)
                Thread.Sleep(_delaySec * 1000);
            RunArc(_arc1, "KIM-MV");
            if (_isRunning && !_isPaused)
                Thread.Sleep(_delaySec * 1000);
            RunArc(_arc2, "Arc2");

            _isRunning = false;
        }

        void DeleteFiles(string path)
        {
            // Clear all files in the path
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                File.Delete(file);
            }
        }

        int GetFileNumber(string inputFilename)
        {
            string[] vals = new FileInfo(inputFilename).Name.Split('_');
            return Convert.ToInt32(vals[2]);
        }
        int GetImageSessionNumber(string inputFilename)
        {
            string[] vals = new FileInfo(inputFilename).Name.Split('_');
            return Convert.ToInt32(vals[1]);
        }

        void RunArc(string directory, string subDirectory)
        {
            if (!Directory.Exists(directory))
                return;
            string outpath = _output + "\\" + subDirectory;
            if (!Directory.Exists(outpath))
                Directory.CreateDirectory(outpath);
            DeleteFiles(outpath);

            string[] files = Directory.GetFiles(directory, "*.hn?");

            if (files == null || files.Length == 0)
            {
                files = Directory.GetFiles(directory, "*.tiff");
                if(files!=null && files.Length > 0)
                {
                    // Sort the TIFF files
                    Array.Sort(files, delegate (string str1, string str2)
                    {
                        int str1N = GetFileNumber(str1);
                        int str2N = GetFileNumber(str2);

                        int str1C = GetImageSessionNumber(str1);
                        int str2C = GetImageSessionNumber(str2);

                        if (str1C != str2C)
                        {
                            return str1C.CompareTo(str2C);
                        }

                        //Trace.WriteLine(str1N.ToString(), str2N.ToString());
                        return str1N.CompareTo(str2N);
                    });

                }
                else //not hn?, not tiff, so probably his 
                {
                    files = Directory.GetFiles(directory, "*.his");
                    var files2 = new String[files.Length+1];
                    if (files != null && files.Length > 0)
                    {
                        var xmlfile = Directory.GetFiles(directory, "_Frames.xml");
                        if (xmlfile!=null && xmlfile.Length > 0)
                        {
                            Array.Sort(files, delegate (string str1, string str2)
                            {
                                
                                int str1N = Convert.ToInt32(Path.GetFileName(str1).Split('.')[0]);
                                int str2N = Convert.ToInt32(Path.GetFileName(str2).Split('.')[0]);
                                return str1N.CompareTo(str2N);
                            });
                            
                        }
                        xmlfile.CopyTo(files2, 0);
                        files.CopyTo(files2,1);
                        files = files2;
                        //make sure that xmlfile gets copied first.
                    }
                    else
                    {
                        MessageBox.Show("no compatible image found, supported files: *.tiff, *.hnd/hnc, *.his");
                    }
                }


            }
            else
                Array.Sort(files);    

            int index = 0;
            if (files.Length == 0)
                return;
            string nextFile = files[index];
            TimeSpan frequency = TimeSpan.FromMilliseconds(_frequencyMS);
            //DateTime startTime = DateTime.Now;
            DateTime nextTime = DateTime.Now + frequency;
            string currentFilename = "";
            do
            {
                string nextFilename = Path.GetFileName(nextFile);
#if DEBUG
                try {
                    if (GetImageSessionNumber(currentFilename) != GetImageSessionNumber(nextFile))
                    {
                        var result =MessageBox.Show("Imaging Session Changed At:"+nextFile);

                    }
                }
                catch { 
                
                }
#endif       
                // Run the delay
                int msToSleep = (int)((nextTime - DateTime.Now).TotalMilliseconds);
                //Trace.WriteLine("Sleeping for " + msToSleep);
                if (msToSleep > 0)
                    Thread.Sleep(msToSleep);
                nextTime += frequency;
                Stopwatch sw = Stopwatch.StartNew();
                if (!_isPaused && _isRunning)
                {
                    if (_oneImage)
                    {
                        _isPaused = true;
                        _oneImage = false;
                    }
                    // Copy the file
                    string outfilename = outpath + "\\" + nextFilename;
                    Stopwatch swB = Stopwatch.StartNew();

                    string dest = outfilename;
                    string src = directory + "\\" + nextFilename;
                    File.Copy(src, dest);

                    // These seem to inconsistenly raise file system watcher events
                    //if (CreateHardLink(dest, src, IntPtr.Zero) == false)
                    //{
                    //    continue;
                    //}
                    //else
                    //{
                    //    if (File.Exists(src))
                    //    {
                    //        //FileInfo fi = new FileInfo(src);
                    //        //fi.CreationTime = fi.LastWriteTime = fi.LastAccessTime = DateTime.Now;
                    //        //using (StreamWriter stream = new StreamWriter(src))
                    //        //{
                    //        //    stream.Flush();
                    //        //}
                    //        FileInfo fi = new FileInfo(src);
                    //        fi.CreationTime = fi.LastWriteTime = fi.LastAccessTime = DateTime.Now;
                    //        //fi.Refresh();
                    //    }
                    //}
                    
                    Trace.WriteLine("Copy time " + swB.ElapsedMilliseconds);
                    if (NewFileReceived != null)
                        NewFileReceived(outfilename);
                    Trace.WriteLine("Filename: " + outpath + "\\" + nextFilename);
                    // Increment the file
                    index++;
                    if (index >= files.Length)
                        break;
                    nextFile = files[index];
                    currentFilename = nextFilename;
                }
                //Trace.WriteLine("Elapsed loop time " + sw.ElapsedMilliseconds);
            } while (_isRunning);
        }

        bool _oneImage = false;

        // Get just one image and then pause
        public bool OneImage
        {
            get 
            {
                return _oneImage; 
            }
            set 
            {
                if (_isPaused)
                    _isPaused = false;
                if (!_isRunning)
                    Start();
                _oneImage = value; 
            }
        }

        // Start processing the data
        public void Start()
        {
            if (!_isRunning)
            {
                // Start the simulation running
                _isRunning = true;
                _isPaused = false;
                Thread simulationThread = new Thread(MainControlThread);
                simulationThread.IsBackground = true;
                simulationThread.Start();
            }
        }

        // Stop processing data
        public void Stop()
        {
            _isRunning = false;
        }

        bool _isRunning = false;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        bool _isPaused = false;

        // Pause data processing
        public bool IsPaused
        {
            get { return _isPaused; }
            set { _isPaused = value; }
        }

    }
}
