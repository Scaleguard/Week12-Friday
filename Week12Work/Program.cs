using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Week12Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What file, would you like to move, to the Fruit folder? ");
            string userInput = Console.ReadLine();
            string filePath = $@"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\{userInput}";

            MovementTime(filePath);
            MoveFileFruits(userInput);

            Console.WriteLine("What file, would you like to move, to the vegetable folder?");
            string userInput2 = Console.ReadLine();

            MoveFileVegetables(userInput2);

            Console.WriteLine("What file would you like to remove from existants from the fruit folder?");
            string userInput3 = Console.ReadLine();

            FileDeleteFruit(userInput3);

            Console.WriteLine("What file would you like to remove from existants from the Vegetable folder");
            string userInput4 = Console.ReadLine();

            FileDeleteVegetable(userInput4);
        }

        public static void MoveFileFruits(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }

        public static void MoveFileVegetables(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            MovementTime(Path.Combine(sourceDirectory, fileName));
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }

        public static void MovementTime(string fileName)
        {
            List<string> dataFromFile = File.ReadAllLines(fileName).ToList();
            DateTime todayDetails = DateTime.Now;
            dataFromFile.Add($"{todayDetails}");
            File.WriteAllLines(fileName, dataFromFile);
        }

        public static void FileDeleteFruit(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }

        public static void FileDeleteVegetable(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";


            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
