using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode2018Day1
{
    public class ChronalCalibration
    {
        public string[] ReadInput() => File.ReadAllText(@"input.txt").Split('\n');

        public List<int> ConvertToInteger(string[] input)
        {
            List<int> numbers = new List<int>();

            foreach(string i in input)
            {
                char sign = i[0];

                if (sign == '+')
                    numbers.Add(Int32.Parse(i.Substring(1)));
                else
                    numbers.Add(-Int32.Parse(i.Substring(1)));
            }

            return numbers;
        }

        public int TotalFrequency(List<int> numbers) => numbers.Sum();

        public int DisplayResult()
        {
            string[] path = ReadInput();
            return TotalFrequency(ConvertToInteger(path));
        }
    }
}
