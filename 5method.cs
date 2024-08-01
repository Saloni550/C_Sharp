C# program to write and read from 
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