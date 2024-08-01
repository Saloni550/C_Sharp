C# Program for Renaming a file
using System;
using System.IO;
using System.Text;

class GIG
{

    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a  name of the file to renamed:");
        string FileName = Console.ReadLine();
        if (File.Exists(FileName))
        {
            Console.WriteLine("Please enter a new name for this file:");
            string newFilename = Console.ReadLine();

                 // Checking if string is null or not
            if (newFilename != String.Empty)
            {

                 // Checking File exist or not

                // Renaming the file
                File.Move(FileName, newFilename);

                // checking if the file has been
                // renamed successfully or not
                if (File.Exists(newFilename))
                {
                    Console.WriteLine("The file was renamed to " + newFilename);
                    Console.ReadKey();
                }
            }
        }
    }
}