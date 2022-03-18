using System;

namespace UC13FileIO;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";

        FileExists();
        readallLines();
        readalltext();
        Filecopying();
        //Readfromstreamreader();
        //StreamWriter();
        sorting();



    }

    public static void FileExists()
    {
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        if (File.Exists(path))
        {
            Console.WriteLine("File Exists");
        }
        else { Console.WriteLine("File not Exits"); }


    }
    public static void readallLines()
    {
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        string[] lines;
        lines = File.ReadAllLines(path);

        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
    }

    public static void readalltext()
    {
        string lines;
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        lines = File.ReadAllText(path);
        Console.WriteLine(lines);
    }

    public static void Filecopying()
    {
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        string path1 = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressExample.txt";
        //File.Copy(path, path1);
    }

    public static void Readfromstreamreader()
    {
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
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
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        using (StreamWriter sw = File.AppendText(path))
        {

            sw.WriteLine();
            sw.WriteLine("HelloWord-BridgeLabz");
            sw.Close();
            Console.WriteLine(File.ReadAllText(path));
        }
    }

    //uc12

    public static void sorting()
    {
        
        string path = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressBook.txt";
        string path1 = @"C:/Users/Nirav Raj/Desktop/day 27/UC12/AddressExample.txt";

        //var contents = File.ReadAllLines(path);
       // Array.Sort(contents);
       // File.WriteAllLines(path1, contents);
       // Array.Sort(contents);

        FileStream readerStream = new FileStream(path, FileMode.Open);
        string[] content = null;
        FileStream writerStream = new FileStream(path, FileMode.OpenOrCreate);
        using (StreamWriter writer = new StreamWriter(writerStream))
        {
            //Sort the content and write back to the same file
            Array.Sort(content);
            writer.Write(string.Join(Environment.NewLine, content));
        }



    }




}