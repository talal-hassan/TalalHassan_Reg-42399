using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_Recognition
{
    class DataSet
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
            StreamWriter write;
            //List<ReadData> list = new List<ReadData>();
            //List<ReadData> confirmList = new List<ReadData>()

            public void NewData(string program,string command)
            {
                write = new StreamWriter(@"data_set.txt");
                write.AutoFlush = true;
                write.Write(program.Trim() + "\t");
                write.Write("\r" + command.Trim() + "\t");
                write.Write("\r" + "null");
                write.WriteLine();
                write.Close();
            }
        }
    }
}
