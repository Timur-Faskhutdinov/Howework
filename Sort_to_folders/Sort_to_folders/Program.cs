using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_to_folders
{
    // Переместить input & output в корень C!!!
    public class FileType
    {
        public List<string> value;
        public string kind;
        public int kolvo { get; private set; }
        private double Size;
        //FileInfo info;
        public DirectoryInfo info;
        public double size
        {
            get
            {
                return Size; 
            }
        }
        public static string targetfolder;
        //public string mesto;
        public FileType(string a, List<string> b)
        {
            value = new List<string>();
            value.AddRange(b);
            kind = a;
            kolvo = 0;
            Size = 0.0;
            //mesto = String.Format($@"{targetfolder}\{kind}");
            System.IO.Directory.CreateDirectory(String.Format($@"{targetfolder}\{kind}"));// может криво работать - проверить, работает ли собачка!
            info = new DirectoryInfo(String.Format($@"{targetfolder}\{kind}"));
        }
        public void Add(FileInfo a)
        {
            File.Move(a.FullName, String.Format($@"{info.FullName}\{a.Name}"));
            //a.MoveTo(String.Format($@"{info.FullName}\{a.Name}"));
            //Console.WriteLine(a.FullName, String.Format($@"{info.FullName}\{a.Name}"));
            //Console.WriteLine();
            kolvo++;
            Size += a.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs;
            List<FileType> lst = new List<FileType>();
            strs = File.ReadAllLines(@"C:\input.txt");
            bool f = true;
            DirectoryInfo c=new DirectoryInfo(@"C:\Users");
            foreach (String s in strs)
            {
                if (f)
                {
                    f = false;
                    FileType.targetfolder = s;
                    c = new DirectoryInfo(s);
                }
                else
                {
                    List<string> w = s.Split(' ').ToList();
                    lst.Add(new FileType(w[0], w.GetRange(1, w.Count - 1)));
                }
            }
            foreach(FileInfo i in c.GetFiles())
            {
                //Console.WriteLine(i.Extension);
                foreach (FileType q in lst)
                {
                    //foreach(string t in q.value)
                    //{
                    //    Console.WriteLine(t);
                    //}
                    if (q.value.Contains(i.Extension))
                    {
                        //Console.WriteLine(i.Name);
                        q.Add(i);
                        break;
                    }
                }
            }

            //StreamWriter wrt = new StreamWriter(@"C:\Users\Тимур_7\Desktop\output.txt");
            StringBuilder e = new StringBuilder();
            foreach (FileType q in lst)
            {
                //wrt.Write(q.kind);
                //wrt.Write($"\nnumber - {q.kolvo}; size - {q.size} bytes\n");
                e.AppendLine(q.kind);
                e.AppendLine($"number - {q.kolvo}; size - {q.size} bytes");
                e.AppendLine();
                //Console.WriteLine(q.kind);
                //Console.WriteLine($"number - {q.kolvo}; size - {q.size} bytes");
                //Console.WriteLine();
            }
            File.WriteAllText(@"C:\output.txt", e.ToString());
            //          FileInfo a = new FileInfo(@"C:\Users\Тимур_7\Desktop\output.txt");
            //          a.Length;
            Console.ReadLine();
        }
    }
}
