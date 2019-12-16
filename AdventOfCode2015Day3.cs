using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2015Day3
{
    class AdventOfCode2015Day3
    {
        enum Who
        {
            santa,
            robo
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Advent of code 2015 day 3");

            Console.WriteLine(NumbersOfPresents(ReadInput()));
        }

        static int NumbersOfPresents(string path)
        {
            HashSet<string> visitedHousesBySanta = VisitedHouses(path, Who.santa);
            HashSet<string> visitedGousesByRoboSanta = VisitedHouses(path, Who.robo);

            visitedHousesBySanta.UnionWith(visitedGousesByRoboSanta);

            return visitedHousesBySanta.Count;
        }

        static HashSet<string> VisitedHouses(string path, Who who)
        {
            HashSet<string> visitedHouses = new HashSet<string>
            {
                "0,0"
            };

            int x = 0;
            int y = 0;

            for (int i = (int) who; i < path.Length; i += 2)
            {
                switch (path[i])
                {
                    case '>':
                        {
                            x++;
                            visitedHouses.Add($"{x},{y}");
                            break;
                        }
                    case '<':
                        {
                            x--;
                            visitedHouses.Add($"{x},{y}");
                            break;
                        }
                    case '^':
                        {
                            y++;
                            visitedHouses.Add($"{x},{y}");
                            break;
                        }
                    case 'v':
                        {
                            y--;
                            visitedHouses.Add($"{x},{y}");
                            break;
                        }
                }
            }

            return visitedHouses;
        }

        static string ReadInput()
            {
                return File.ReadAllText("input.txt");
            }
        }
    }
