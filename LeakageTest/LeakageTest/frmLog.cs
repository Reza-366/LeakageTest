using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeakageTest
{
    public partial class frmLog : Form
    {

        LogCollection _logger = LogCollection.GetInstance;
        public frmLog()
        {
            InitializeComponent();
            textBox1.Text = _logger.ToString(24);
            _logger.LogChanged += new Action(logCollection_LogChanged);
        }
        public void logCollection_LogChanged()
        {
            RefreshLogs(_logger.ToString(24));
        }

        private void RefreshLogs(string p)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Action<string> add = new Action<string>(RefreshLogs);
                    this.Invoke(add, new object[] { p });
                }
                else
                {
                    textBox1.Text = p;
                }
            }
            catch { }

        }

 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _logger.Clear();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
        }

        private void frmLog_Closed(object sender, EventArgs e)
        {
            frmMain._frmLog = null;
        }
    }
}