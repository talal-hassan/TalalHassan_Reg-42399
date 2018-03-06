using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StudentProfile
{
    class TTS
    {
        public void topStudent(string path)
        {

            Console.Write("Enter Department(SS,EE):_____\b\b\b\b  ");
            string dept = Console.ReadLine().ToUpper();
            double first, second, third;
            first = second = third = 0;

            Console.WriteLine("tts");


            Console.Clear();
            string line;
            StreamReader read = new StreamReader(@"StudentProfile.txt");
            List<StudendRecord> list = new List<StudendRecord>();
            //string fileReader;
            string[] subFields; char splitter = ',';

            while ((line = read.ReadLine()) != null)
            {
                StudendRecord stu = new StudendRecord();
                subFields = line.Split(splitter);
                stu.setStudentID(subFields[0]);
               
                stu.setStudentName(subFields[1]);

                stu.setDepartament(subFields[2]);

                stu.setSemester(subFields[3]);
               
                stu.setCGPA(subFields[4]);

                stu.setUnivarsity(subFields[5]);

                string tem = subFields[2];
                if (tem.Equals(dept))
                {

                    list.Add(stu);
                }
            }
            read.Close();


            StudendRecord obj = list[0];
            first = double.Parse(obj.getCGPA());
            int count = 0;
            foreach (var stu in list)
            {
                if (first <= double.Parse(stu.getCGPA()))
                {
                    first = double.Parse(stu.getCGPA());
                    count++;
                }

            }
            //Console.WriteLine(count);
            foreach (var stu in list)
            {
                if (first > double.Parse(stu.getCGPA()))
                {
                    if (second < double.Parse(stu.getCGPA()))
                    {
                        second = double.Parse(stu.getCGPA());
                    }
                }

            }


            foreach (var stu in list)
            {
                if (first > double.Parse(stu.getCGPA()))
                {
                    if (second > double.Parse(stu.getCGPA()))
                    {
                        if (third < double.Parse(stu.getCGPA()))
                        {
                            third = double.Parse(stu.getCGPA());
                        }
                    }
                }

            }


            foreach (var stu in list)
            {
                if (first == double.Parse(stu.getCGPA()) || second == double.Parse(stu.getCGPA()) || third == double.Parse(stu.getCGPA()))
                {
                    Console.Write(stu.getStudentID() + "\t");
                    Console.Write(stu.getStudentName() + "\t");
                    Console.Write(stu.getSemester() + "\t");
                    Console.Write(stu.getCGPA() + "\t");
                    Console.Write(stu.getDepartment() + "\t");
                    Console.Write(stu.getUniversity() + "\t");
                    Console.WriteLine();
                }

            }

        }
    }
}
