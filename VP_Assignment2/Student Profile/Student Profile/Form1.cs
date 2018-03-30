using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Profile
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }

        private void login_screen_Load(object sender, EventArgs e)
        {
            selected.Select();
        }

        private void user_Click(object sender, EventArgs e)
        {
            user.Text = "";
        }

        private void pass_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
            pass.Text = "";
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    Main m = new Main();
        //    m.Show();
        //    this.Hide();
        //}

        private void panel_btnLogin_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }
    }
}
