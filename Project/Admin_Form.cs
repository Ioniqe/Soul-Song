using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maximize_Butt_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void minimize_Butt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nextForm()
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void back_Butt_Click(object sender, EventArgs e)
        {
            nextForm();
        }

        private void new_song_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Song form = new New_Song();
            form.ShowDialog();
            this.Close();
        }

        private void delete_song_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Song_Form l = new Delete_Song_Form();
            l.ShowDialog();
            this.Close();
        }
    }
}
