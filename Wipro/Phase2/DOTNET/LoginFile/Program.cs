using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace LoginFile
{ 

    public class FileHandle
    {
        public static void Check()
        {
            if(File.Exists("LogFile1.txt"))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                using(FileStream fs = File.Create("LogFile1.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Satavisha");
                    fs.Write(info, 0, info.Length);
                    fs.Flush();
                    fs.Close();
                }

                using(StreamReader sw=File.OpenText("LogFile.txt"))
                {
                    string s = "";
                    while ((s = sw.ReadLine()) != null)
                        Console.WriteLine(s);
                    sw.Close();
                }
            }
        }

        public static void Main(string[] args)
        {
            Check();
        }
    }
}