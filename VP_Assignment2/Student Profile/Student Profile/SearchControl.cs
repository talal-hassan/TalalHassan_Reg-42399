using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Profile
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudent.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(SearchStudentBy.Text == "Enrollment ID")
            {
                searchList.Items.Clear();
                foreach(var user in Stream.streamOperation.ReadData())
                {
                    if(user.getID() == SearchStudent.Text.ToLower())
                    {
                        ListViewItem items = new ListViewItem(user.getID());
                        items.SubItems.Add(user.getName());
                        items.SubItems.Add(user.getSemester());
                        items.SubItems.Add(user.getCGPA());
                        items.SubItems.Add(user.getDepartment());
                        items.SubItems.Add(user.getCampus());
                        searchList.Items.Add(items);
                    }
                }
            }
            else if(SearchStudentBy.Text == "Name")
            {
                searchList.Items.Clear();
                foreach(var user in Stream.streamOperation.ReadData())
                {
                    if (user.getName() == SearchStudent.Text.ToLower())
                    {
                        ListViewItem items = new ListViewItem(user.getID());
                        items.SubItems.Add(user.getName());
                        items.SubItems.Add(user.getSemester());
                        items.SubItems.Add(user.getCGPA());
                        items.SubItems.Add(user.getDepartment());
                        items.SubItems.Add(user.getCampus());
                        searchList.Items.Add(items);
                    }
                }
            }
            else if(SearchStudentBy.Text == "Semester")
            {
                searchList.Items.Clear();
                foreach(var user in Stream.streamOperation.ReadData())
                {
                    if (user.getSemester() == SearchStudent.Text.ToLower())
                    {
                        ListViewItem items = new ListViewItem(user.getID());
                        items.SubItems.Add(user.getName());
                        items.SubItems.Add(user.getSemester());
                        items.SubItems.Add(user.getCGPA());
                        items.SubItems.Add(user.getDepartment());
                        items.SubItems.Add(user.getCampus());
                        searchList.Items.Add(items);
                    }
                }
            }
        }
    }
}
