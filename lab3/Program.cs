using System;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        // Bai 1
        Console.WriteLine("Bai 1:");
        string path = "data.txt";
        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("UserName: wwcdn");
                sw.WriteLine("PassWord: ******");
            }
        }

        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // Bai 2
        Console.WriteLine("\nBai 2:");
        string userName = "Lost love";
        string passWord = "**************";
        string time = "23/05/2023";

        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine("UserName: " + userName);
            sw.WriteLine("PassWord: " + passWord);
            sw.WriteLine("Time: " + time);

            string content = sw.ToString();

            using (StringReader stringReader = new StringReader(content))
            {
                string line;
                while ((line = stringReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // Bai 3
        Console.WriteLine("\nBai 3:");
        Directory.CreateDirectory("data");
        string path_bai3 = "data/data.txt";
        using (StreamWriter writer = new StreamWriter(path_bai3))
        {
            writer.WriteLine("Msvv: 12345");
            writer.WriteLine("Họ và tên: Khanh");
        }

        Directory.CreateDirectory("data2");

        DirectoryInfo sourceDirectory = new DirectoryInfo("data");

        foreach (FileInfo file in sourceDirectory.GetFiles())
        {
            file.CopyTo("data2/data.txt", true);
        }

        Console.WriteLine("File copy xong, kiem tra thu muc data va data2!");
    }
}
