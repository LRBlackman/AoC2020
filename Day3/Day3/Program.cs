using System;
using System.Collections.Generic;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[] { };
            using (var reader = new StreamReader("input.csv"))
            {
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    values = line.Split(',');
                }
            }

            //First half:
            //int treeCount = 0;
            //int xVal = 0;
            //for (int i = 0; i < values.Length; i++)
            //{
            //    char[] currentSlope = values[i].ToCharArray();
            //    if (currentSlope[xVal] == '#')
            //    {
            //        treeCount++;
            //    }
            //    if (xVal >= 28)
            //    {
            //        xVal -= 31;
            //    }
            //    xVal += 3;
            //}
            //Console.WriteLine("Encountered " + treeCount + " trees");
            //Console.ReadLine();

            //Second half:
            int treeCount = 0;
            int xVal = 0;
            for (int i = 0; i < values.Length; i+=2)
            {
                char[] currentSlope = values[i].ToCharArray();
                if (currentSlope[xVal] == '#')
                {
                    treeCount++;
                }
                if (xVal == 30)
                {
                    xVal -= 31;
                }
                xVal += 1;
            }
            Console.WriteLine("Encountered " + treeCount + " trees");
            Console.ReadLine();
        }
    }
}
