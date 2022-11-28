using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO.Ports;

namespace LeakageTest
{
    enum RunningModes { Program, Free, NotRun }

    public partial class frmMain : Form
    {
        //string program = "";
        public static frmLog _frmLog = null;
        LogCollection logCollection = LogCollection.GetInstance;
        int rpm = 0;
        int secondsCounter = 0;
        RunningModes runningModes = RunningModes.NotRun;
        Regex regex = new Regex("<RPM>\\d*<\\/RPM>");
        StringBuilder buffer = new StringBuilder();

        //SCREEN SIZE 800,454
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }



        void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var str = serialPort1.ReadExisting();
            logCollection.AddLog(str);
            processBuffer(str);
        }

        public int Progress
        {
            get { return progressBar1.Value; }
            set
            {
                progressBar1.Value = value;
                lblPercent.Text = value.ToString() + "%";
            }
        }

        void processBuffer(string str)
        {

            buffer.Append(str);
            var matches = regex.Matches(buffer.ToString());
            Match lastMatch = null;
            foreach (Match item in matches)
            {
                try
                {
                    StringBuilder rpmStr = new StringBuilder(item.Value);
                    rpmStr = rpmStr.Replace("<RPM>", "");
                    rpmStr = rpmStr.Replace("</RPM>", "");
                    int r = int.Parse(rpmStr.ToString());
                    RPM = r;
                    lastMatch = item;
                }
                catch (Exception ex)
                {
                    logCollection.AddLog(ex.Message);
                }
            }
            if (lastMatch != null)
                buffer = buffer.Remove(0, lastMatch.Index + lastMatch.Length);



            //var splits = sb.ToString().Split("<RPM></RPM>".ToCharArray() );
            //foreach (var item in splits)
            //{
            //    try
            //    {
            //        int r = int.Parse(item);
            //        RPM = r;
            //        if (r > 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        if(_frmLog!= null)
            //            _frmLog.AddLog(ex.Message);
            //    }

            //}
        }

        //void UpdateRpm(int rpm)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        Action<int> action = new Action<int>(UpdateRpm);
        //        this.Invoke(action,new object[] { rpm });
        //    }
        //    else

        //}

        RunningModes RunningMode
        {
            get { return runningModes; }
            set { runningModes = value; }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            GoRight();
            secondsCounter = 0;
            RunningMode = RunningModes.Free;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            GoStop();
            RunningMode = RunningModes.NotRun;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            GoLeft();
            secondsCounter = 0;
            RunningMode = RunningModes.Free;
        }

        public int RPM
        {
            get
            {
                int r = 0;
                lock (this)
                {
                    r = rpm;
                }
                return r;
            }
            set
            {
                if (rpm != value)
                    lock (this)
                    {
                        rpm = value;
                    }
            }
        }

        void CheckOpen()
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                frmMessageBox.Show(ex.Message);
            }
        }

        void GoLeft()
        {
            try
            {
                lblCurrentCommand.Text = "LEFT";
                serialPort1.WriteLine("<left>");
            }
            catch (Exception ex)
            {
                frmMessageBox.Show(ex.Message);
            }
        }
        void GoRight()
        {
            try
            {
               lblCurrentCommand.Text = "RIGHT";
                serialPort1.WriteLine("<right>");
            }
            catch (Exception ex)
            {
                frmMessageBox.Show(ex.Message);
            }
        }
        void GoStop()
        {
            try
            {
                lblCurrentCommand.Text = "STOP";
                serialPort1.WriteLine("<stop>");

            }
            catch (Exception ex)
            {
                frmMessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "00:00:00";
            lblRpm.Text = "0";
            lblOil1.Text = "0";
            lblOil2.Text = "0";
            lblOil3.Text = "0";
            lblPercent.Text = "0";
            lblCurrentCommand.Text = "-";
            lblTotalCharacter.Text = "-";
            pnlStatus.BackColor = Color.Silver;
            CheckOpen();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RPM > 0)
                pnlStatus.BackColor = Color.Red;
            else
                pnlStatus.BackColor = Color.Silver;

            try
            {
                switch (runningModes)
                {
                    case RunningModes.Program:
                        int programIndex = secondsCounter / 60;
                        if (programIndex >= txtProgram.Text.Length)
                        {
                            GoStop();
                            runningModes = RunningModes.NotRun;
                            txtProgram.Text = "";
                            Progress = 0;
                            RefreshInterface();
                            return;
                        }
                        if (secondsCounter % 60 == 0)// Program Change Every Minutes
                        {
                            char command = txtProgram.Text.ToCharArray()[programIndex];
                            switch (command)
                            {
                                case 'R':
                                    GoRight();
                                    break;
                                case 'L':
                                    GoLeft();
                                    break;
                                case 'S':
                                    GoStop();
                                    break;
                                default:
                                    break;
                            }
                        }
                        Progress = secondsCounter * 100 / (txtProgram.Text.Length * 60);
                        secondsCounter++;
                        break;
                    case RunningModes.Free:
                        secondsCounter++;
                        break;
                    case RunningModes.NotRun:
                        lblCurrentCommand.Text = "-";
                        break;
                    default:
                        break;
                }
                var span = TimeSpan.FromSeconds(secondsCounter);
                lblTime.Text = String.Format("{0:00}:{1:00}:{2:00}", span.Hours, span.Minutes, span.Seconds);
            }
            catch (Exception ex)
            {
                frmMessageBox.Show(ex.Message);
            }

        }

        private void btnSet1_Click(object sender, EventArgs e)
        {
            txtProgram.Text = "RRRRRRRRS";
            btnR.Enabled = btnL.Enabled = btnS.Enabled = btnClear.Enabled = false;
        }

        private void btnSet2_Click(object sender, EventArgs e)
        {
            txtProgram.Text = "RRRRRRRRRRRRS";
            btnR.Enabled = btnL.Enabled = btnS.Enabled = btnClear.Enabled = false;
        }

        private void btnSet3_Click(object sender, EventArgs e)
        {
            txtProgram.Text = "RRRRRRRRSLLLLLLLLS";
            btnR.Enabled = btnL.Enabled = btnS.Enabled = btnClear.Enabled = false;
        }

        private void RefreshInterface()
        {
            if (RunningMode == RunningModes.Program)
            {
                btnR.Enabled = btnL.Enabled = btnS.Enabled = btnClear.Enabled = false;
                btnCustom.Enabled= btnSet1.Enabled = btnSet2.Enabled = btnSet3.Enabled = false;
                btnRun.Enabled = false;
                btnCancel.Enabled = true;
                btnRight.Enabled = false;
                btnStop.Enabled = false;
                btnLeft.Enabled = false;
            }
            else
            {
                btnCustom.Enabled = btnSet1.Enabled = btnSet2.Enabled = btnSet3.Enabled = true;
                btnRun.Enabled = true;
                btnCancel.Enabled = false;
                btnRight.Enabled = true;
                btnStop.Enabled = true;
                btnLeft.Enabled = true;
            }

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            txtProgram.Text = "";
            btnR.Enabled = btnL.Enabled = btnS.Enabled = btnClear.Enabled = true;
        }

        
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtProgram.Text = txtProgram.Text.ToUpper();
            if (txtProgram.Text.Trim().Length == 0)
            {
                frmMessageBox.Show("Nothing To Run","Error");
                return;
            }

            RunningMode = RunningModes.Program;
            RefreshInterface();
            //program = txtProgram.Text.Trim().ToUpper();
            secondsCounter = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmMessageBox.Show("Are you Sure ? ", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GoStop();
                //program = "";
                RunningMode = RunningModes.NotRun;
                RefreshInterface();
            }
        }


        const float omega = 0.104718033f;
        int lastRpm = 0;

        private void timerRpm_Tick(object sender, EventArgs e)
        {
            int rpm = RPM;
            if (lastRpm == rpm)
                return;

            lastRpm = rpm;

            if (rpm >= 0 && rpm <= 300)
                lblRpm.ForeColor = Color.Lime;
            if (rpm >= 301 && rpm <= 600)
                lblRpm.ForeColor = Color.Yellow;
            if (rpm >= 601 && rpm <= 800)
                lblRpm.ForeColor = Color.Orange;
            if (rpm >= 801)
                lblRpm.ForeColor = Color.Red;

            lblRpm.Text = rpm.ToString();

            double force1 = 0.086f * 0.2835f * Math.Pow(omega * rpm, 2); //BLK 145
            double force2 = 0.153f * 0.2835f * Math.Pow(omega * rpm, 2); //BLK 245
            double force3 = 0.086f * 0.2835f * Math.Pow(omega * rpm, 2); //FSA

            double presure1 = force1 / 0.001012f;
            double presure2 = force2 / 0.001103f;
            double presure3 = force3 / 0.000550f;

            double bar1 = presure1 * 0.00001f;
            double bar2 = presure2 * 0.00001f;
            double bar3 = presure3 * 0.00001f;

            lblOil1.Text = Math.Round(bar1, 2).ToString();
            lblOil2.Text = Math.Round(bar2, 2).ToString();
            lblOil3.Text = Math.Round(bar3, 2).ToString();

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_frmLog == null)
            {
                _frmLog = new frmLog();
                _frmLog.Show();
            }
            else
                _frmLog.BringToFront();
        }

        private void frmMain_Closing(object sender, CancelEventArgs e)
        {
            GoStop();
        }


        private void btnR_Click(object sender, EventArgs e)
        {
            txtProgram.Text += "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtProgram.Text += "S";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtProgram.Text += "L";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgram.Text = "";
        }

        private void txtProgram_TextChanged(object sender, EventArgs e)
        {
            lblTotalCharacter.Text = "Total : " + txtProgram.Text.Length + " Minutes";
        }



    }
}