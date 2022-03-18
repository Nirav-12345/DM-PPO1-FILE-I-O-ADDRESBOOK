using System;

namespace UC13FileIO;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";

        FileExists();
        readallLines();
        readalltext();
        Filecopying();
        Readfromstreamreader();
        StreamWriter();



    }

    public static void FileExists()
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        if (File.Exists(path))
        {
            Console.WriteLine("File Exists");
        }
        else { Console.WriteLine("File not Exits"); }


    }
    public static void readallLines()
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        string[] lines;
        lines = File.ReadAllLines(path);

        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
    }

    public static void readalltext()
    {
        string lines;
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        lines = File.ReadAllText(path);
        Console.WriteLine(lines);
    }

    public static void Filecopying()
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        string path1 = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressboo.json";
        File.Copy(path, path1);
    }

    public static void Readfromstreamreader()
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";

            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    public static void StreamWriter()
    {
        string path = @"C:\Users\Nirav Raj\Desktop\day 27\UC15/Addressbook.json";
        using (StreamWriter sw = File.AppendText(path))
        {

            sw.WriteLine();
            sw.WriteLine("HelloWord-BridgeLabz");
            sw.Close();
            Console.WriteLine(File.ReadAllText(path));
        }
    }


}