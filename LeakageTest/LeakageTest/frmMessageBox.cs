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
    public partial class frmMessageBox : Form
    {

        MessageBoxButtons _buttons = MessageBoxButtons.OK;

        public frmMessageBox()
        {
            InitializeComponent();
        }

        public frmMessageBox(string msg, string title, MessageBoxButtons buttons)
        {
            InitializeComponent();
            Message = msg;
            Title = title;
            Buttons = buttons;
        }

        public string Title { get { return this.Text; } set { this.Text = value; } }
        public string Message { get { return lblMsg.Text; } set { lblMsg.Text = value; } }
        public MessageBoxButtons Buttons
        {
            get { return _buttons; }
            set
            {
                _buttons = value;
                switch (_buttons)
                {
                    case MessageBoxButtons.AbortRetryIgnore:
                        break;
                    case MessageBoxButtons.OK:
                        btnOne.Text = "OK";
                        btnTwo.Visible = false;
                        break;
                    case MessageBoxButtons.OKCancel:
                        btnOne.Text = "OK";
                        btnTwo.Text = "Cancel";
                        btnTwo.Visible = true;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        break;
                    case MessageBoxButtons.YesNo:
                        btnOne.Text = "Yes";
                        btnTwo.Text = "No";
                        btnTwo.Visible = true;
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (Buttons == MessageBoxButtons.OK || Buttons == MessageBoxButtons.OKCancel)
                this.DialogResult = DialogResult.OK;
            if (Buttons == MessageBoxButtons.YesNo || Buttons == MessageBoxButtons.YesNoCancel)
                this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (Buttons == MessageBoxButtons.OK || Buttons == MessageBoxButtons.OKCancel)
                this.DialogResult = DialogResult.Cancel;
            if (Buttons == MessageBoxButtons.YesNo || Buttons == MessageBoxButtons.YesNoCancel)
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static DialogResult Show(string msg)
        {
            return Show(msg, "");
        }
        public static DialogResult Show(string msg, string title)
        {
            return Show(msg, title, MessageBoxButtons.OK);
        }
        public static DialogResult Show(string msg, string title, MessageBoxButtons buttons)
        {
            frmMessageBox frm = new frmMessageBox(msg, title, buttons);
            return frm.ShowDialog();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }




    }
}