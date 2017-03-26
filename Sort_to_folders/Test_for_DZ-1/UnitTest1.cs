using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort_to_folders;
using System.Collections.Generic;
using System.IO;

namespace Test_for_DZ_1
{
    [TestClass]
    public class TestFileType
    {
        [TestMethod]
        public void TestConstructor()
        {
            //проверка - создать папку и проверить ее путь с эталонной.

            FileType.targetfolder = @"C:\qwerty";
            Directory.CreateDirectory(FileType.targetfolder);
            List<string> lst =new List<string>();
            lst.Add(".tre");
            FileType s = new FileType("rr23r4d", lst);
            Assert.AreEqual(@"C:\qwerty\rr23r4d", s.info.FullName);           
        }
        [TestMethod]
        public void TestAdd()
        //При любых попытках перемещения файла в тесте - ошибка: файл занят другим процессом, а так все нормально.
        {
            try
            {
                // перемещать файл и проверить его конечный путь.
                FileType.targetfolder = @"C:\qwerty";
                Directory.CreateDirectory(FileType.targetfolder);
                DirectoryInfo c = new DirectoryInfo(FileType.targetfolder);
                FileInfo inf = new FileInfo(@"C:\qwerty\asdf.txt");
                inf.Create();
              //File.Create(@"C:\qwerty\asdf.txt");
                List<string> lst = new List<string>();
                lst.Add(".txt");
                FileType s = new FileType("rr23r4d", lst);
            //s.Add(inf);

            //foreach (FileInfo i in c.GetFiles())
            //{
            //            //Console.WriteLine(i.Name);
            //           s.Add(inf);
            //}
            //inf.Refresh();
            //Assert.AreEqual(inf.FullName, @"C:\qwerty\rr23r4d\asdf.txt");
            //File.Move(inf.FullName, String.Format($@"{c.FullName}\{inf.Name}"));
            inf.MoveTo($@"{s.info.FullName}");
            Assert.IsTrue(File.Exists(@"C:\qwerty\rr23r4d\asdf.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошло исключение - {ex.Message}");

            }
        }
    }
}