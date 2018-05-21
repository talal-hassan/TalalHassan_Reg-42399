using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Profile
{
    class ReadData
    {
        private string studentID, studentName, studentSemester, studentCGPA, studentDepartment, studentCampus;

        public void SetID(string id)
        {
            studentID = id;
        }
        public void SetName(string name)
        {
            studentName = name;
        }
        public void SetSemester(string semester)
        {
            studentSemester = semester;
        }
        public void SetCGPA(string CGPA)
        {
            studentCGPA = CGPA;
        }
        public void SetDepartment(string department)
        {
            studentDepartment = department;
        }
        public void SetCampus(string campus)
        {
            studentCampus = campus;
        }

        public string getID()
        {
            return studentID;
        }
        public string getName()
        {
            return studentName;
        }
        public string getSemester()
        {
            return studentSemester;
        }
        public string getCGPA()
        {
            return studentCGPA;
        }
        public string getDepartment()
        {
            return studentDepartment;
        }
        public string getCampus()
        {
            return studentCampus;
        }

    }
}
