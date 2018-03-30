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
        private List<ReadData> list;
        public DeleteControl()
        {
            InitializeComponent();
            list = new List<ReadData>();
            
        }
        private void DeleteControl_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader read = new StreamReader("data.txt");
            foreach(var items in deleteList)
            {

            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent.Text = "";
        }

        private void DeleteControl_Load(object sender, EventArgs e)
        {

        }
    }
}
