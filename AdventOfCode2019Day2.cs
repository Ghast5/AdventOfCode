using System;
using System.IO;
using System.Linq;

public class ProgramAlarm
{
    private string ReadInput() => File.ReadAllText("input.txt");

    private int[] ConvertInputToInteger(string path) => path.Split(',').Select(c => Int32.Parse(c)).ToArray();

    private int Count(int noun, int verb, int[] arr)
    {
        int positionInArray = 0;
        int opcode = arr[positionInArray];
        arr[1] = noun;
        arr[2] = verb;

        while (opcode != 99)
        {
            if (opcode == 1)
                arr[arr[positionInArray + 3]] = arr[arr[positionInArray + 1]] + arr[arr[positionInArray + 2]];

            else
                arr[arr[positionInArray + 3]] = arr[arr[positionInArray + 1]] * arr[arr[positionInArray + 2]];

            positionInArray += 4;
            opcode = arr[positionInArray];
        }

        return arr[0];
    }

    public string DisplayResult()
    {
        ProgramAlarm p = new ProgramAlarm();
        string path = p.ReadInput();

        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                if (p.Count(i, j, p.ConvertInputToInteger(path)) == 19690720)
                    return new string($"{i}{j}");

        return "";
    }
}
