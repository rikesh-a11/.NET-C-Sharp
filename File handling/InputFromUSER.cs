using System;

namespace Qus13
{
     class InputFromUSER
    {
        static void Main()
        {
            string filePath = @"E:\dummy\anotherfile"; // Path to the output file

            Console.WriteLine("Enter text to write to the file (press Enter on an empty line to finish):");

            // Collect user input and write it to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string userInput;
                do
                {
                    userInput = Console.ReadLine();
                    writer.WriteLine(userInput);
                } while (!string.IsNullOrEmpty(userInput));
            }

            Console.WriteLine("File written successfully!");
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
