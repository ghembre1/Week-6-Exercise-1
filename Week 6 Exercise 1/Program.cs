using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Had to inplement this in the code to be able to read and write into a file

namespace Week_6_Exercise_1
{
    internal class Program
    {
        static int CountWords(string filename) // Method for CountWords
        {
            if (!File.Exists(filename)) // Checks if the file exists
            {
                Console.WriteLine($"The file '{filename}' does not exist."); // If file does not exist prints this line
                return 0; // Returns 0 as the number of words in non existent file
            }

            string content = File.ReadAllText(filename); // Sets content as variable to read from the text
            // Makes the file an array and names it words and then uses Split to go through each word in the array and counts 
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length; // returns the number of words in the file
        }

        static void Main(string[] args)
        {
            string filename = "Tempfile.txt"; // Sets filename as the same as the name of the file
            int wordCount = CountWords(filename); // Makes wordcount the same number from what the method prints out
            Console.WriteLine($"Total word count: " + wordCount); // Prints line for the total word count

            Console.ReadKey();
        }
    }
}
