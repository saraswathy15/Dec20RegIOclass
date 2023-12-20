using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Dec20RegIOclass
{
    public class IOExample
    {
        public static void WriteAndReadFile()
        { // create a file with streamwrite
            StreamWriter writer = new StreamWriter(@"D:\Mphasis\Dec20Console\File1.txt");
            writer.WriteLine("Hello forth Line");// write permissions or write mode
            writer.WriteLine(" Hello fifth line");
            writer.Close();//must, without close, permission 
            //lets read content of given file 
            StreamReader reader = new StreamReader(@"D:\Mphasis\Dec20Console\File1.txt");
            string strContent = reader.ReadToEnd();//Read() readLine()// read permission
            Console.WriteLine(strContent);
            reader.Close();
        }
        public static void WriteAndReadWithFileStream()
        {
            FileStream wrStream = new FileStream(@"D:\Mphasis\Dec20Console\File3.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(wrStream);
            writer.WriteLine("With File stream class ");
            //   writer.Close();
            FileStream srStream = new FileStream(@"D:\Mphasis\Dec20Console\File3.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(srStream);
            string strCOntent = reader.ReadLine();
            Console.WriteLine(strCOntent);
            reader.Close();
        }
        public static void FileWithFileFuns()
        {
            string pathFile = @"D:\Mphasis\Dec20Console\File4.txt";
            // checking 
            if (System.IO.File.Exists(pathFile))
            {//true
                //File.Delete(pathFile);
                StreamReader reader = System.IO.File.OpenText(pathFile);
                string s1 = reader.ReadToEnd();
                Console.WriteLine("file exists so we are reading " + s1);
                reader.Close();
            }
            else
            {//false
                StreamWriter writer = System.IO.File.CreateText(pathFile);
                writer.Write(" now we are with file class");
                writer.Close();
            }
            // let when a file is created
            DateTime dt1 = System.IO.File.GetCreationTime(pathFile);
            Console.WriteLine(dt1.ToString());
            // to append in existing file 
            StreamWriter sw1 = System.IO.File.AppendText(pathFile);
            sw1.Close();
            //  File.Move(pathFile, "d:\\mphasis");// oldfile,new path cut paste

            System.IO.File.Copy(pathFile, @"D:\Mphasis\Dec20Console\file5.txt");// new file name must 


        }
        public static void WorkingWithDirectoryFuns()
        {// create folde
            string str = "d:\\dec20net";
            Directory.CreateDirectory(str);
            Directory.Delete(str);
            // check
            if (Directory.Exists(str)) Console.WriteLine("folder is there");
            else Console.WriteLine("no such folder");
            // let display all files in a path
            Console.WriteLine("all file names");
            string[] fileNames = Directory.GetFiles("c:\\windows");
            foreach (string oneFile in fileNames) { Console.WriteLine(oneFile); }
            //let display all folders in path
            Console.WriteLine(" all folder names");
            string[] folderNames = Directory.GetDirectories("d:\\");
            foreach (string oneFolder in folderNames) { Console.WriteLine(oneFolder); }
            // lets display drive names
            string[] driveNames = Directory.GetLogicalDrives();
            foreach (string oneDrive in driveNames) { Console.WriteLine(oneDrive); }
        }
        public static void FunsWithFIleInfo()
        {
            string s1 = @"D:\Mphasis\Dec20Console\File3.txt";
            string s2 = @"D:\Mphasis\Dec20Console\File4.txt";
            string s3 = s1 + s2;
            FileInfo fi = new FileInfo(s3);
            string str1 = fi.Extension;
            long size = fi.Length;
            Console.WriteLine(str1);
            Console.WriteLine(size);
            string fn = fi.FullName;//complete path
            string n = fi.Name;// just file name
            // try display only path without filename
            DirectoryInfo di = new DirectoryInfo("d:\\mphasis");

        }

        static void Main(string[] args)
        {
            FunsWithFIleInfo();
            //WorkingWithDirectoryFuns();
            // FileWithFileFuns();
            //  WriteAndReadWithFileStream();
            // WriteAndReadFile();
            DateTime dt1 = DateTime.Now;// current time date year millisecond
                                        // Console.WriteLine(dt1.ToLongTimeString());
                                        // Console.WriteLine(dt1.ToString("MMM"));//Dec
            Console.WriteLine(dt1.ToString("MMMM"));//december
            Console.WriteLine(dt1.ToString("dddd"));
            Console.WriteLine(dt1.ToString("ddd"));
            //how to assign date 
            DateTime dt2 = new DateTime(2002, 03, 20, 4, 45, 30, 200);
            DateTime dt3 = new DateTime();
            int sec = dt2.Second;
            int min = dt2.Minute;
            int yr = dt2.Year;
            // lets add years
            dt3 = dt2.AddYears(2);
            //display
            //months
            dt2.AddMonths(3);
            Console.WriteLine(dt2.DayOfYear);
            Console.ReadLine();
        }
    }
}

