
   
using System;
namespace AddressBookIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\DELL\source\repos\AddressBookIO\AddressBook.txt";

            //ReadAllLines(path);
            //ReadFromStreamReader(path);
            WriteUsingStreamWriter(path);


        }
        public static void FileExist()
        {
            string path = @"C:\Users\DELL\source\repos\AddressBookIO\AddressBook.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }

        // IO ReadAlline UC13
        public static void ReadAllLines(string path)
        {
            string[] lines;

            lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public static void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("***********New Details***********");
                sw.WriteLine("Name :Madhan");
                sw.WriteLine("Last Name :Kumar");
                sw.WriteLine("Adress : rajiv road main raod, Dindigul");
                sw.WriteLine("City :Dindigul");
                sw.WriteLine("State :Tamilnadhu");
                sw.WriteLine("zip :423402");
                sw.WriteLine("phone :63251456");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }
}
