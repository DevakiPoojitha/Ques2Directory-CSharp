using System;
using System.Diagnostics;
using System.IO;



namespace que2directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir1 = @"C:\directory1";
            Directory.CreateDirectory(dir1);



            string file1 = @"C:\directory1\MyNewFile.txt";


            if (!File.Exists(file1))
            {
                using FileStream fs = File.Create(file1);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", file1);

            }



            string dir2 = @"C:\directory2";
            Directory.CreateDirectory(dir2);



            string file2 = @"C:\directory2\MyNewFile2.txt";




            if (!File.Exists(file2))
            {
                using FileStream fs = File.Create(file2);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", file2);
            }
            string destination = @"C:\directory2\MyNewFile.txt";
            if (File.Exists(destination))
                File.Delete(destination);
            File.Move(file1, destination);
            Console.WriteLine("{0} was moved to {1}.", file1, destination);



            string destination1 = @"C:\directory1\MyNewFile2.txt";
            if (File.Exists(destination1))
                File.Delete(destination1);
            File.Move(file2, destination1);
            Console.WriteLine("{0} was moved to {1}.", file2, destination1);




        }
    }
}