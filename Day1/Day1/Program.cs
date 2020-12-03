using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[] { };
            using(var reader = new StreamReader("input.csv"))
            {
                List<string> listA = new List<string>();
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    values = line.Split(',');
                }
            }

            int[] expenseReport = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                expenseReport[i] = int.Parse(values[i]);
            }

            //First half solution:
            //for (int i = 0; i < expenseReport.Length; i++)
            //{
            //    for (int j = i+1; j < expenseReport.Length; j++)
            //    {
            //        if(expenseReport[i] + expenseReport[j] == 2020)
            //        {
            //            Console.WriteLine(expenseReport[i] + " * " + expenseReport[j] + " = " + expenseReport[i]*expenseReport[j]);
            //            Console.ReadLine();
            //        }
            //    }
            //}

            //Second half solution:
            for (int i = 0; i < expenseReport.Length; i++)
            {
                for (int j = 0; j < expenseReport.Length; j++)
                {
                    for (int k = 0; k < expenseReport.Length; k++)
                    {
                        if (expenseReport[i] + expenseReport[j] + expenseReport[k] == 2020)
                        {
                            Console.WriteLine(expenseReport[i] + " * " + expenseReport[j] + " * " + expenseReport[k] + " = " + expenseReport[i] * expenseReport[j] * expenseReport[k]);
                            Console.ReadLine();
                        }
                    }
                }
            }


        }
    }
}
