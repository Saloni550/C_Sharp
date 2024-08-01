 C# program to create a directory
using System;
using System.IO;
 
class Program
{

    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a name for the new directory:");

        string DirName = Console.ReadLine();

        // Checking if string is empty or not
        if (DirName != String.Empty)
        {
            // Creating the Directory
            Directory.CreateDirectory(DirName);

            // Checking Directory is created
            // Successfully or not
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("The directory was created!");
                Console.ReadKey();
            }
        }
    }
}*/


*/

// 3  method 

/*using System;
using System.IO;

class GFG
{

    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the directory name you want to delete:");

        string DirName = Console.ReadLine();

        // Checking if Directory Exist or not
        if (Directory.Exists(DirName))
        {

            // This will delete the 
            // Directory if it is empty
            Directory.Delete(DirName);

            // checking if directory if 
            // deleted successfully or not
            if (Directory.Exists(DirName) == false)
                Console.WriteLine("Directory deleted successfully...");
        }
        else
            Console.WriteLine("Directory {0} does not exist!", DirName);
        Console.ReadKey();
    }
}*/


//4 method 
// C# Program for Renaming a file
/*using System;
using System.IO;
using System.Text;

class GFG
{

    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a  name of the file to renamed:");
        string FileName = Console.ReadLine();

        // Checking File exist or not
        if (File.Exists(FileName))
        {
            Console.WriteLine("Please enter a new name for this file:");
            string newFilename = Console.ReadLine();

            // Checking if string is null or not
            if (newFilename != String.Empty)
            {

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
}*/



// 5 method filestream
// C# program to write and read from 
// a text file using FileStream class
using System;
using System.IO;
using System.Text;
  
namespace FileStreamWriteRead
{

    class GFG
    {

        static void Main(string[] args)
        {
            // Create a FileStream Object
            // to write to a text file
            // The parameters are complete 
            // path of the text file in the 
            // system, in Create mode, the
            // access to this process is 
            // Write and for other 
            // processes is None
            FileStream fWrite = new FileStream(@"M:\Documents\Textfile.txt",
                         FileMode.Create, FileAccess.Write, FileShare.None);

            // Store the text in the variable text
            var text = "This is some text written to the textfile " +
                           "named Textfile using FileStream class.";

            // Store the text in a byte array with
            // UTF8 encoding (8-bit Unicode 
            // Transformation Format)
            byte[] writeArr = Encoding.UTF8.GetBytes(text);

            // Using the Write method write
            // the encoded byte array to
            // the textfile
            fWrite.Write(writeArr, 0, text.Length);

            // Close the FileStream object
            fWrite.Close();

            // Create a FileStream Object
            // to read from a text file
            // The parameters are complete
            // path of the text file in 
            // the system, in Open mode,
            // the access to this process is
            // Read and for other processes
            // is Read as well
            FileStream fRead = new FileStream(@"M:\Documents\Textfile.txt",
                           FileMode.Open, FileAccess.Read, FileShare.Read);

            // Create a byte array 
            // to read from the 
            // text file
            byte[] readArr = new byte[text.Length];
            int count;

            // Using the Read method 
            // read until end of file
            while ((count = fRead.Read(readArr, 0, readArr.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(readArr, 0, count));
            }

            // Close the FileStream Object
            fRead.Close();
            Console.ReadKey();
        }
    }
}