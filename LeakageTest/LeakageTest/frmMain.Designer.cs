namespace LeakageTest
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblRpm = new System.Windows.Forms.Label();
            this.btnSet1 = new System.Windows.Forms.Button();
            this.btnSet2 = new System.Windows.Forms.Button();
            this.btnSet3 = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timerRpm = new System.Windows.Forms.Timer();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOil1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOil2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOil3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.lblTotalCharacter = new System.Windows.Forms.Label();
            this.lblCurrentCommand = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.PortName = "COM4";
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRight.Location = new System.Drawing.Point(526, 216);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(195, 48);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Coral;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(340, 216);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 48);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLeft.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLeft.Location = new System.Drawing.Point(156, 216);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(179, 48);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblRpm
            // 
            this.lblRpm.BackColor = System.Drawing.Color.DimGray;
            this.lblRpm.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.lblRpm.ForeColor = System.Drawing.Color.Lime;
            this.lblRpm.Location = new System.Drawing.Point(11, 90);
            this.lblRpm.Name = "lblRpm";
            this.lblRpm.Size = new System.Drawing.Size(324, 55);
            this.lblRpm.Text = "1080";
            this.lblRpm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSet1
            // 
            this.btnSet1.BackColor = System.Drawing.Color.DarkGray;
            this.btnSet1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSet1.Location = new System.Drawing.Point(118, 4);
            this.btnSet1.Name = "btnSet1";
            this.btnSet1.Size = new System.Drawing.Size(138, 36);
            this.btnSet1.TabIndex = 5;
            this.btnSet1.Text = "Set 1";
            this.btnSet1.Click += new System.EventHandler(this.btnSet1_Click);
            // 
            // btnSet2
            // 
            this.btnSet2.BackColor = System.Drawing.Color.DarkGray;
            this.btnSet2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSet2.Location = new System.Drawing.Point(266, 4);
            this.btnSet2.Name = "btnSet2";
            this.btnSet2.Size = new System.Drawing.Size(138, 36);
            this.btnSet2.TabIndex = 11;
            this.btnSet2.Text = "Set 2";
            this.btnSet2.Click += new System.EventHandler(this.btnSet2_Click);
            // 
            // btnSet3
            // 
            this.btnSet3.BackColor = System.Drawing.Color.DarkGray;
            this.btnSet3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSet3.Location = new System.Drawing.Point(410, 4);
            this.btnSet3.Name = "btnSet3";
            this.btnSet3.Size = new System.Drawing.Size(138, 36);
            this.btnSet3.TabIndex = 12;
            this.btnSet3.Text = "Set 3";
            this.btnSet3.Click += new System.EventHandler(this.btnSet3_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.DarkGray;
            this.btnCustom.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustom.ForeColor = System.Drawing.Color.Black;
            this.btnCustom.Location = new System.Drawing.Point(554, 4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(154, 36);
            this.btnCustom.TabIndex = 13;
            this.btnCustom.Text = "Custom";
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.Text = "Program : ";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.IndianRed;
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(117, 101);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(287, 51);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(410, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(298, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(591, 17);
            this.progressBar1.Value = 50;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.DimGray;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(341, 90);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(437, 55);
            this.lblTime.Text = "00:06:15";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtProgram.Location = new System.Drawing.Point(118, 46);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(286, 26);
            this.txtProgram.TabIndex = 20;
            this.txtProgram.Text = "RRRRRRSLLLLLLS";
            this.txtProgram.TextChanged += new System.EventHandler(this.txtProgram_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.Text = "Progress :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.Text = "RPM";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(631, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.Text = "Running Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRpm
            // 
            this.timerRpm.Enabled = true;
            this.timerRpm.Tick += new System.EventHandler(this.timerRpm_Tick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 32);
            this.label7.Text = "OIL Presure :";
            // 
            // lblOil1
            // 
            this.lblOil1.BackColor = System.Drawing.Color.DimGray;
            this.lblOil1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.lblOil1.ForeColor = System.Drawing.Color.White;
            this.lblOil1.Location = new System.Drawing.Point(156, 168);
            this.lblOil1.Name = "lblOil1";
            this.lblOil1.Size = new System.Drawing.Size(179, 41);
            this.lblOil1.Text = "3.2";
            this.lblOil1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(199, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.Text = "BLK 145";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(386, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.Text = "BLK 245";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOil2
            // 
            this.lblOil2.BackColor = System.Drawing.Color.DimGray;
            this.lblOil2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.lblOil2.ForeColor = System.Drawing.Color.White;
            this.lblOil2.Location = new System.Drawing.Point(341, 168);
            this.lblOil2.Name = "lblOil2";
            this.lblOil2.Size = new System.Drawing.Size(179, 41);
            this.lblOil2.Text = "4.5";
            this.lblOil2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(571, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.Text = "FSA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOil3
            // 
            this.lblOil3.BackColor = System.Drawing.Color.DimGray;
            this.lblOil3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.lblOil3.ForeColor = System.Drawing.Color.White;
            this.lblOil3.Location = new System.Drawing.Point(526, 168);
            this.lblOil3.Name = "lblOil3";
            this.lblOil3.Size = new System.Drawing.Size(195, 41);
            this.lblOil3.Text = "6.0";
            this.lblOil3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(727, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 32);
            this.label10.Text = "bar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(246, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 32);
            this.label12.Text = "Dashpot Leakage Test Machine";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.lblTotalCharacter);
            this.panel1.Controls.Add(this.lblCurrentCommand);
            this.panel1.Controls.Add(this.lblPercent);
            this.panel1.Controls.Add(this.btnSet2);
            this.panel1.Controls.Add(this.btnSet1);
            this.panel1.Controls.Add(this.btnSet3);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtProgram);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 160);
            this.panel1.Tag = "Program";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(665, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 26);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.DarkGray;
            this.btnS.Enabled = false;
            this.btnS.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnS.ForeColor = System.Drawing.Color.Black;
            this.btnS.Location = new System.Drawing.Point(593, 46);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(30, 26);
            this.btnS.TabIndex = 25;
            this.btnS.Text = "S";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.DarkGray;
            this.btnL.Enabled = false;
            this.btnL.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnL.ForeColor = System.Drawing.Color.Black;
            this.btnL.Location = new System.Drawing.Point(629, 46);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(30, 26);
            this.btnL.TabIndex = 24;
            this.btnL.Text = "L";
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.DarkGray;
            this.btnR.Enabled = false;
            this.btnR.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnR.ForeColor = System.Drawing.Color.Black;
            this.btnR.Location = new System.Drawing.Point(557, 46);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(30, 26);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "R";
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // lblTotalCharacter
            // 
            this.lblTotalCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCharacter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCharacter.Location = new System.Drawing.Point(410, 52);
            this.lblTotalCharacter.Name = "lblTotalCharacter";
            this.lblTotalCharacter.Size = new System.Drawing.Size(131, 20);
            this.lblTotalCharacter.Text = "Total : 12 Minutes";
            this.lblTotalCharacter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentCommand
            // 
            this.lblCurrentCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentCommand.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCommand.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentCommand.Location = new System.Drawing.Point(710, 50);
            this.lblCurrentCommand.Name = "lblCurrentCommand";
            this.lblCurrentCommand.Size = new System.Drawing.Size(56, 18);
            this.lblCurrentCommand.Text = "RIGHT";
            this.lblCurrentCommand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercent.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPercent.Location = new System.Drawing.Point(716, 78);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(44, 20);
            this.lblPercent.Text = "50 %";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Location = new System.Drawing.Point(716, 6);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(45, 36);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(798, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblOil3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOil2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOil1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRpm);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Leakage Test Machine (Ali Orang - Reza Garmabi)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblRpm;
        private System.Windows.Forms.Button btnSet1;
        private System.Windows.Forms.Button btnSet2;
        private System.Windows.Forms.Button btnSet3;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerRpm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOil1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOil2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOil3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblCurrentCommand;
        private System.Windows.Forms.Label lblTotalCharacter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Panel pnlStatus;
    }
}

