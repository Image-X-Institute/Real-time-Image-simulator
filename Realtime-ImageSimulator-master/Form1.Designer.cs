namespace ImageSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PreTreatment = new System.Windows.Forms.TextBox();
            this.textBox_Treatment = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Frequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Delay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Pretreatment = new System.Windows.Forms.Button();
            this.button_Treatment = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Arc2 = new System.Windows.Forms.Button();
            this.textBox_Arc2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_NextImage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Filename = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_PatientDirectory = new System.Windows.Forms.Button();
            this.textBox_PatientDirectory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output directories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pretreatment directory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Treatment arc 1 directory";
            // 
            // textBox_PreTreatment
            // 
            this.textBox_PreTreatment.Location = new System.Drawing.Point(178, 69);
            this.textBox_PreTreatment.Name = "textBox_PreTreatment";
            this.textBox_PreTreatment.Size = new System.Drawing.Size(729, 20);
            this.textBox_PreTreatment.TabIndex = 4;
            this.textBox_PreTreatment.TextChanged += new System.EventHandler(this.textBox_PreTreatment_TextChanged);
            // 
            // textBox_Treatment
            // 
            this.textBox_Treatment.Location = new System.Drawing.Point(178, 95);
            this.textBox_Treatment.Name = "textBox_Treatment";
            this.textBox_Treatment.Size = new System.Drawing.Size(729, 20);
            this.textBox_Treatment.TabIndex = 5;
            this.textBox_Treatment.TextChanged += new System.EventHandler(this.textBox_Treatment_TextChanged);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(178, 190);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(729, 20);
            this.textBox_Output.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Image frequency (milliseconds)";
            // 
            // numericUpDown_Frequency
            // 
            this.numericUpDown_Frequency.Location = new System.Drawing.Point(178, 216);
            this.numericUpDown_Frequency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Name = "numericUpDown_Frequency";
            this.numericUpDown_Frequency.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Frequency.TabIndex = 9;
            this.numericUpDown_Frequency.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Frequency.ValueChanged += new System.EventHandler(this.numericUpDown_Frequency_ValueChanged);
            // 
            // numericUpDown_Delay
            // 
            this.numericUpDown_Delay.Location = new System.Drawing.Point(178, 242);
            this.numericUpDown_Delay.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Delay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Delay.Name = "numericUpDown_Delay";
            this.numericUpDown_Delay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Delay.TabIndex = 11;
            this.numericUpDown_Delay.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Delay.ValueChanged += new System.EventHandler(this.numericUpDown_Delay_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Delay between arcs (seconds)";
            // 
            // button_Pretreatment
            // 
            this.button_Pretreatment.Location = new System.Drawing.Point(913, 67);
            this.button_Pretreatment.Name = "button_Pretreatment";
            this.button_Pretreatment.Size = new System.Drawing.Size(75, 23);
            this.button_Pretreatment.TabIndex = 12;
            this.button_Pretreatment.Text = "Browse";
            this.button_Pretreatment.UseVisualStyleBackColor = true;
            this.button_Pretreatment.Click += new System.EventHandler(this.button_Pretreatment_Click);
            // 
            // button_Treatment
            // 
            this.button_Treatment.Location = new System.Drawing.Point(913, 93);
            this.button_Treatment.Name = "button_Treatment";
            this.button_Treatment.Size = new System.Drawing.Size(75, 23);
            this.button_Treatment.TabIndex = 13;
            this.button_Treatment.Text = "Browse";
            this.button_Treatment.UseVisualStyleBackColor = true;
            this.button_Treatment.Click += new System.EventHandler(this.button_Treatment_Click);
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(913, 188);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(75, 23);
            this.button_Output.TabIndex = 14;
            this.button_Output.Text = "Browse";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Start
            // 
            this.button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Start.Location = new System.Drawing.Point(777, 272);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 15;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Pause.Location = new System.Drawing.Point(858, 272);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(75, 23);
            this.button_Pause.TabIndex = 16;
            this.button_Pause.Text = "Pause";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Stop.Location = new System.Drawing.Point(939, 272);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 17;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Arc2
            // 
            this.button_Arc2.Location = new System.Drawing.Point(913, 119);
            this.button_Arc2.Name = "button_Arc2";
            this.button_Arc2.Size = new System.Drawing.Size(75, 23);
            this.button_Arc2.TabIndex = 20;
            this.button_Arc2.Text = "Browse";
            this.button_Arc2.UseVisualStyleBackColor = true;
            this.button_Arc2.Click += new System.EventHandler(this.button_Arc2_Click);
            // 
            // textBox_Arc2
            // 
            this.textBox_Arc2.Location = new System.Drawing.Point(178, 121);
            this.textBox_Arc2.Name = "textBox_Arc2";
            this.textBox_Arc2.Size = new System.Drawing.Size(729, 20);
            this.textBox_Arc2.TabIndex = 19;
            this.textBox_Arc2.TextChanged += new System.EventHandler(this.textBox_Arc2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Treatment arc 2 directory";
            // 
            // button_NextImage
            // 
            this.button_NextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NextImage.Location = new System.Drawing.Point(696, 272);
            this.button_NextImage.Name = "button_NextImage";
            this.button_NextImage.Size = new System.Drawing.Size(75, 23);
            this.button_NextImage.TabIndex = 21;
            this.button_NextImage.Text = "Next image";
            this.button_NextImage.UseVisualStyleBackColor = true;
            this.button_NextImage.Click += new System.EventHandler(this.button_NextImage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Filename});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Filename
            // 
            this.toolStripStatusLabel_Filename.Name = "toolStripStatusLabel_Filename";
            this.toolStripStatusLabel_Filename.Size = new System.Drawing.Size(0, 17);
            // 
            // button_PatientDirectory
            // 
            this.button_PatientDirectory.Location = new System.Drawing.Point(913, 41);
            this.button_PatientDirectory.Name = "button_PatientDirectory";
            this.button_PatientDirectory.Size = new System.Drawing.Size(75, 23);
            this.button_PatientDirectory.TabIndex = 25;
            this.button_PatientDirectory.Text = "Browse";
            this.button_PatientDirectory.UseVisualStyleBackColor = true;
            this.button_PatientDirectory.Click += new System.EventHandler(this.button_PatientDirectory_Click);
            // 
            // textBox_PatientDirectory
            // 
            this.textBox_PatientDirectory.Location = new System.Drawing.Point(178, 43);
            this.textBox_PatientDirectory.Name = "textBox_PatientDirectory";
            this.textBox_PatientDirectory.Size = new System.Drawing.Size(729, 20);
            this.textBox_PatientDirectory.TabIndex = 24;
            this.textBox_PatientDirectory.TextChanged += new System.EventHandler(this.textBox_PatientDirectory_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Patient directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 320);
            this.Controls.Add(this.button_PatientDirectory);
            this.Controls.Add(this.textBox_PatientDirectory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_NextImage);
            this.Controls.Add(this.button_Arc2);
            this.Controls.Add(this.textBox_Arc2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Pause);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.button_Treatment);
            this.Controls.Add(this.button_Pretreatment);
            this.Controls.Add(this.numericUpDown_Delay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_Frequency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Treatment);
            this.Controls.Add(this.textBox_PreTreatment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Image simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PreTreatment;
        private System.Windows.Forms.TextBox textBox_Treatment;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Pretreatment;
        private System.Windows.Forms.Button button_Treatment;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Arc2;
        private System.Windows.Forms.TextBox textBox_Arc2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_NextImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Filename;
        private System.Windows.Forms.Button button_PatientDirectory;
        private System.Windows.Forms.TextBox textBox_PatientDirectory;
        private System.Windows.Forms.Label label9;
    }
}

