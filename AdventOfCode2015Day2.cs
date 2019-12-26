using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2015Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] input = LoadInput();
            Console.WriteLine($"Part One: {CountPapperAmount(input)}");
            Console.WriteLine($"Part Two: {CountPartTwo(input)}");
        }

        static string[] LoadInput()
        {
            string path = @"Input.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);

            string input = reader.ReadToEnd();
            string[] inputArray = input.Split('\n');

            return inputArray;
        }

        static int CountPapperAmount(string[] inputs)
        {
            return inputs.Select(s => s.Split('x')).Select(n => n.Select(Int32.Parse)).Select(w => w.OrderBy(x => x).ToArray()).Select(w => 3 * w[0] * w[1] + 2 * w[0] * w[2] + 2 * w[1] * w[2]).Sum();

            //int[] outputArray = new int[inputs.Length];
            //for(int i = 0; i < inputs.Length; i++)
            //{
            //    string[] textDimension = inputs[i].Split('x');
            //    int l = Convert.ToInt32(textDimension[0]);
            //    int w = Convert.ToInt32(textDimension[1]);
            //    int h = Convert.ToInt32(textDimension[2]);

            //    int area1 = l * h;
            //    int area2 = l * w;
            //    int area3 = w * h;

            //    if(area1 < area2 && area1 < area3)
            //        outputArray[i] = (2 * l * w + 2 * w * h + 2 * h * l) + area1;
            //    else if(area2 < area1 && area2 < area3)
            //        outputArray[i] = (2 * l * w + 2 * w * h + 2 * h * l) + area2;
            //    else if(area3 < area1 && area3 < area2)
            //        outputArray[i] = (2 * l * w + 2 * w * h + 2 * h * l) + area3;
            //}

            //return outputArray.Sum();
        }

        static int CountPartTwo(string[] inputs)
        {
            return inputs.Select(s => s.Split('x')).Select(n => n.Select(Int32.Parse)).Select(w => w.OrderBy(x => x).ToArray()).Select(w => 2 * w[0] + 2 * w[1] + w[0] * w[1] * w[2]).Sum();
        }
    }
}
