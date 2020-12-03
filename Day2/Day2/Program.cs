using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
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
            //int validCount = 0;
            //for (int i = 0; i < values.Length; i++)
            //{
            //    int min = 0;
            //    int max = 0;
            //    char[] letterArray;
            //    char letter;
            //    string[] currentvalue = values[i].Split(' ');
            //    string[] minMax = currentvalue[0].Split('-');
            //    min = int.Parse(minMax[0]);
            //    max = int.Parse(minMax[1]);
            //    string[] letterSection = currentvalue[1].Split(':');
            //    letterArray = letterSection[0].ToCharArray();
            //    letter = letterArray[0];
            //    char[] password = currentvalue[2].ToCharArray();

            //    int letterCount = 0;
            //    for (int j = 0; j < password.Length; j++)
            //    {
            //        if (password[j] == letter)
            //        {
            //            letterCount++;
            //        }
            //    }

            //    if (letterCount >= min && letterCount <= max)
            //    {
            //        validCount++;
            //    }
            //}
            //Console.WriteLine("There are " + validCount + " valid passwords");
            //Console.ReadLine();

            //Second half:
            int validCount = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int pos1 = 0;
                int pos2 = 0;
                char[] letterArray;
                char letter;
                string[] currentvalue = values[i].Split(' ');
                string[] minMax = currentvalue[0].Split('-');
                pos1 = int.Parse(minMax[0]);
                pos2 = int.Parse(minMax[1]);
                string[] letterSection = currentvalue[1].Split(':');
                letterArray = letterSection[0].ToCharArray();
                letter = letterArray[0];
                char[] password = currentvalue[2].ToCharArray();

                if (password[pos1-1] == letter || password[pos2-1] == letter)
                {
                    if(password[pos1-1] != password[pos2-1])
                    {
                        validCount++;
                    }
                }
            }
            Console.WriteLine("There are " + validCount + " valid passwords");
            Console.ReadLine();
        }
    }
}
