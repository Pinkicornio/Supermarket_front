using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Load_Form : Form
    {
        private Gestion_Form gestion_form;
        public Load_Form()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private void Load_Form_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadFilesLabel.Text = "Loading files.";
            loadFilesLabel.Text = "Loading files..";

            this.progressBar1.Increment(5);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                gestion_form = new Gestion_Form();
                gestion_form.Show();
                this.Hide();
            }

            }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
