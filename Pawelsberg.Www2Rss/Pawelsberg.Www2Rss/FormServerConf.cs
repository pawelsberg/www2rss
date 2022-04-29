using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pawelsberg.Www2Rss
{
    public partial class FormServerConfiguration : Form
    {
        private UInt16 _port;

        public UInt16 Port
        {
            get { return _port; }
        }
        private bool _localonly;

        public bool Localonly
        {
            get { return _localonly; }
        }
        private bool _result;

        public bool Result
        {
            get { return _result; }
        }
        public FormServerConfiguration(UInt16 port, bool localonly)
        {
            InitializeComponent();
            _port = port;
            _localonly = localonly;
            _result = false;
            textBoxPort.Text = String.Format("{0}", _port);
            checkLocalOnly.Checked = _localonly;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            _result = true;
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            _port = Convert.ToUInt16(textBoxPort.Text);
        }
        private void checkLocalOnly_CheckedChanged(object sender, EventArgs e)
        {
            _localonly = checkLocalOnly.Checked;
        }
    }
}