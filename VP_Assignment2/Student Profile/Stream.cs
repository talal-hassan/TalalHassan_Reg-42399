using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Profile
{
    class Stream
    {
        private static Stream stream;
        public static Stream streamOperation
        {
            get
            {
                if (stream == null)
                    stream = new Stream();
                return stream;
            }
        }

        StreamReader read;
        StreamWriter write;//= new StreamWriter("data.txt");
       
        //private Stream()
        //{
        //    write = new StreamWriter("data.txt"); write.Close();
        //    read = new StreamReader("data.txt"); // abhi create krni hai ye file
        //    read.Close();
        //}
        List<ReadData> list = new List<ReadData>();
        List<ReadData> confirmList = new List<Student_Profile.ReadData>();

        public void WriteData(string id, string name, string semester, string cgpa, string department, string campus)
        {

            // fill krna hai
            write = new StreamWriter("data.txt", true);
            write.AutoFlush = true;
            //foreach(var check in list)
            //{
            //    if(id != check.getID())
            //}
            write.Write(id.Trim() + "\t");
            write.Write("\r" + name.Trim() + "\t");
            write.Write("\r" + semester.Trim() + "\t");
            write.Write("\r" + cgpa.Trim() + "\t");
            write.Write("\r" + department.Trim() + "\t");
            write.Write("\r" + campus.Trim() + "\t");
            write.Write("\r" + "null");
            write.WriteLine();
            write.Close();
        }
        public List<ReadData> ReadData()
        {
            list.Clear();
            //if(File.Exists("data.txt"))
                read = new StreamReader("data.txt");
            String line;
           
            while ((line = read.ReadLine()) != null)
            {
                ReadData user = new ReadData();
                string  n = line.Trim();
                user.SetID(line.Trim());

                line = read.ReadLine();
                string n1 = line.Trim();
                user.SetName(n1);

                line = read.ReadLine();
                string n2 = line.Trim();
                user.SetSemester(n2);

                line = read.ReadLine();
                string n3 = line.Trim();
                user.SetCGPA(n3);

                line = read.ReadLine();
                string  n4 = line.Trim();
                user.SetDepartment(n4);

                line = read.ReadLine();
                string n5 = line.Trim();
                user.SetCampus(n5);

                read.ReadLine();
                list.Add(user);
            }
            read.Close();
            confirmList.Clear();
            confirmList = list.Distinct().ToList();
            return confirmList;
        }
        

    }
}
