using System;
using System.IO;

class IPS
{

    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a  name of the directory to renamed:");
        string DirName = Console.ReadLine();

        // checking directory exist or not
        if (Directory.Exists(DirName))
        {
            Console.WriteLine("Please enter a new name for this directory:");
            string newDirName = Console.ReadLine();

            if (newDirName != String.Empty)
            {

                // to rename directory
                Directory.Move(DirName, newDirName);

                // checking directory has 
                // been renamed or not
                if (Directory.Exists(newDirName))
                {
                    Console.WriteLine("The directory was renamed to " + newDirName);
                    Console.ReadKey();
                }
            }
        }
    }
}