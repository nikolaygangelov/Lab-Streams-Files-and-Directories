using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader("../../../lines.txt");
            
            using (reader)
            {
                int rowNumber = 1;
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"{rowNumber++}. {line}");
                }
            }
        }
    }
}

