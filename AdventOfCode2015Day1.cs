using System;
using System.IO;

namespace AdventOfCode
{
    class AdventOfCode2015Day1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountFloor(LoadInput()));
            Console.WriteLine(CountFloor("()()(()()()"));
        }

        static string LoadInput()
        {
            string path = @"Input.txt";

            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);

            string input = reader.ReadToEnd();

            reader.Close();
            fs.Close();

            return input;
        }

        static int CountFloor(string input)
        {
            int whichFloor = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    whichFloor += 1;
                else if(input[i] == ')')
                    whichFloor -= 1;

                if(whichFloor == -1)
                {
                    return i + 1;
                }
            }

            return whichFloor;
        }
    }
}
