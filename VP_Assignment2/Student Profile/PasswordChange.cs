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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            newPassword.Text = "";
        }

        private void confirmPassword_Click(object sender, EventArgs e)
        {
            confirmPassword.Text = "";
        }
        string newPass;
        private void btnChange_Click(object sender, EventArgs e)
        {
            if(newPassword.Text.Equals(confirmPassword.Text))
            {
                newPass = confirmPassword.Text;
            }
            Dispose();
        }
        public string NewPass()
        {
            return newPass;
        }
    }
}
