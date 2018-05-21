using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Profile
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //private void getSemester_TextChanged(object sender, EventArgs e)
        //{
           
        //    //getField_TextCheck();
        //}

        //private void getCGPA_TextChanged(object sender, EventArgs e)
        //{
        //    getCGPA.Text = "";
        //    //getField_TextCheck();
        //}
        private void getID_Click(object sender, EventArgs e)
        {
            getID.Text = "";
        }

        private void getName_Click(object sender, EventArgs e)
        {
            getName.Text = "";
        }

        private void getSemester_Click_1(object sender, EventArgs e)
        {
            getSemester.Text = "";
        }

        private void getCGPA_Click(object sender, EventArgs e)
        {
            getCGPA.Text = "";
        }
        private bool getField_TextCheck()
        {
            if (getID.Text == "" || getName.Text == "" || getSemester.Text == "" || getCGPA.Text == "" || getDepartment.Text == "" || getSemester.Text == "")
            {
                return false;
            }
            else
                return true;
        }
        private void btnSaveCreate_Click(object sender, EventArgs e)
        {
            if (getField_TextCheck() == false)
            {
                Error_Save err = new Error_Save();
                err.Show();
            }
            else
            {
                if (File.Exists("data.txt"))
                {
                    Stream.streamOperation.ReadData();
                }
                Stream.streamOperation.WriteData(getID.Text.ToLower(), getName.Text.ToLower(), getSemester.Text.ToLower(), getCGPA.Text.ToLower(), getDepartment.Text.ToLower(), getCampus.Text.ToLower());
                Confirmation confirm = new Confirmation();
                confirm.Show();
            }
        }
    }
}
