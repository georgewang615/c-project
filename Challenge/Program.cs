using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "rates.txt";

            Dictionary<string, double> map = new Dictionary<string, double>();
            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] entries = line.Split(new string[] { " , " }, StringSplitOptions.None);
                    map.Add(entries[0], Double.Parse(entries[1]));

                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist");
                return;
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0].Equals("rate"))
                {
                    if (!map.ContainsKey(input[1])) 
                    {
                        Console.WriteLine("Currency does not exist in file");
                    }

                    else
                    {
                        Console.WriteLine("Current " + input[1] + " is " + map[input[1]]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
