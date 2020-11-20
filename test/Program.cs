using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\test.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            dataFromFile.Add("grapes");
            File.WriteAllLines(filePath, dataFromFile);
        }
    }
}
