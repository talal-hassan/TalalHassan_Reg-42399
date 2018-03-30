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
    public partial class DeleteControl : UserControl
    {
        private List<ReadData> deleteList;
        public DeleteControl()
        {
            InitializeComponent();
            deleteList = new List<ReadData>();
            
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent.Text = "";
        }

        private void DeleteControl_Load(object sender, EventArgs e)
        {
            //StreamReader read = new StreamReader("data.txt");
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteList = Stream.streamOperation.ReadData();
            File.Delete("data.txt");
            foreach (var user in deleteList)
            {
                if (DeleteStudent.Text.ToLower() != user.getID())
                {
                    Stream.streamOperation.WriteData(user.getID().ToLower(),user.getName().ToLower(),user.getSemester().ToLower(),user.getCGPA().ToLower(),user.getDepartment().ToLower(),user.getCampus().ToLower());
                    
                }
            }
            DeleteConfirmation del = new DeleteConfirmation();
            del.Show();
        }
    }
}
