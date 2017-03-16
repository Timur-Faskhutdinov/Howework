using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_to_folders
{
    public class FileType
    {
        public List<string> value;
        public string kind;
        public int kolvo { get; private set; }
        private double Size;
        public DirectoryInfo info;
        public double size
        {
            get
            {
                return Size; 
            }
        }
        public static string targetfolder;
        public FileType(string a, List<string> b)
        {
            value = new List<string>();
            value.AddRange(b);
            kind = a;
            kolvo = 0;
            Size = 0.0;
            System.IO.Directory.CreateDirectory(String.Format($@"{targetfolder}\{kind}"));// может криво работать - проверить, работает ли собачка!
            info = new DirectoryInfo(String.Format($@"{targetfolder}\{kind}"));
        }
        public void Add(FileInfo a)
        {
            File.Move(a.FullName, String.Format($@"{info.FullName}\{a.Name}"));
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
                foreach (FileType q in lst)
                {
                    if (q.value.Contains(i.Extension))
                    {
                        q.Add(i);
                        break;
                    }
                }
            }
            StringBuilder e = new StringBuilder();
            foreach (FileType q in lst)
            {
                e.AppendLine(q.kind);
                e.AppendLine($"number - {q.kolvo}; size - {q.size} bytes");
                e.AppendLine();
            }
            File.WriteAllText(@"C:\output.txt", e.ToString());
            Console.ReadLine();
        }
    }
}
