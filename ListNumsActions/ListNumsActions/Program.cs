using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;

                    case "del":
                        nums.Remove(int.Parse(cmd[1]));
                        break;

                    case "contains":
                        Console.WriteLine(nums.Contains(int.Parse(cmd[1])) ? "YES" : "NO");
                        break;
                    case "remove":
                    //TODO
                        break;

                    case "cut":
                        int n = int.Parse(cmd[1]);
                        if (n >= nums.Count)
                        {
                            nums.Clear();
                        }
                        else
                        {
                            nums.RemoveRange(0, n);
                        }
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}