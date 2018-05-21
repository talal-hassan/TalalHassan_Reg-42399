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

      

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }
        string passCheck = "admin";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Text.ToLower() == "admin" && pass.Text.ToLower() == passCheck)
            {
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                Error_Login error = new Error_Login();
                error.Show();
            }
        }

        private void user_DragOver(object sender, DragEventArgs e)
        {
            user.Text = "admin";
        }

        private void user_Enter(object sender, EventArgs e)
        {
          
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1050;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("username: admin", TB, 0, 0, VisibleTime);
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            TextBox TP = (TextBox)sender;
            int VisibleTime = 1050;  //in milliseconds

            ToolTip tp = new ToolTip();
            tp.Show("password: admin", TP, 0, 0, VisibleTime);
        }

        
    }
}
