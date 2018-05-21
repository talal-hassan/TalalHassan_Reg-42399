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
    public partial class AttendanceMarkControl : UserControl
    {
        public AttendanceMarkControl()
        {
            InitializeComponent();
        }
        List<ReadData> attendanceList;
        List<ReadData> cont;
        private void AttendanceMarkControl_Load(object sender, EventArgs e)
        {
            attendanceList = Stream.streamOperation.ReadData();
            cont = attendanceList.Distinct().ToList();
        }
        private void btnMArkAttendance_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            for (int i = 0; i < cont.Count; i++)
            {
               // MessageBox.Show(attendanceList[i].ToString());
                foreach (var attendance in cont)
                {
                   // MessageBox.Show(attendance.getDepartment().ToString());
                    if (attendance.getDepartment() == fieldDepartment.Text.ToLower() && attendance.getSemester() == fieldSemester.Text.ToLower())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i+1;
                        dataGridView1.Rows[i].Cells[1].Value = attendance.getName();
                        dataGridView1.Rows[i].Cells[2].Value = attendance.getID();
                        dataGridView1.Rows[i].Cells[3].Value = attendance.getDepartment();

                        //dataGridView1.Rows[i].Cells[3].Value = false;
                    }
                }
            }
        }

        
    }
}
