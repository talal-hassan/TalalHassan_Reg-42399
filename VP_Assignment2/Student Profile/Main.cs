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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SideBar.Height = btnHome.Height;
            SideBar.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        //private void CreateStudent_Click(object sender, EventArgs e)
        //{
        //    Student student = new Student();
        //    student.Show();
        //    this.Hide();
        //}

        //private void SearchStudent_Click(object sender, EventArgs e)
        //{
        //    Student student = new Student();
        //    student.Show();
        //    this.Hide();
        //}

        //private void DeleteStudent_Click(object sender, EventArgs e)
        //{
        //    Student student = new Student();
        //    student.Show();
        //    this.Hide();
        //}

        //private void MarkAttendance_Click(object sender, EventArgs e)
        //{
        //    Attendance attend = new Attendance();
        //    attend.Show();
        //    this.Hide();
        //}

        //private void ViewAttendance_Click(object sender, EventArgs e)
        //{
        //    Attendance attend = new Attendance();
        //    attend.Show();
        //    this.Hide();
        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnHome.Height;
            SideBar.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnSearchStudent.Height;
            SideBar.Top = btnSearchStudent.Top;
            searchControl1.BringToFront();
        }

        private void searchControl1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnCreate.Height;
            SideBar.Top = btnCreate.Top;
            //createControl1.BringToFront();
            userControl11.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnDelete.Height;
            SideBar.Top = btnDelete.Top;
            delete1.BringToFront();
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            delete1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SideBar.Height = button5.Height;
            SideBar.Top = button5.Top;
            attendanceViewControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SideBar.Height = button6.Height;
            SideBar.Top = button6.Top;
            attendanceMarkControl1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        
    
    }
}
