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
                    case "add":
                        int a = int.Parse(cmd[1]);
                        int b = int.Parse(cmd[2]);
                        nums.Add(a + b);
                        break;
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        //TODO
                        break;
                    case "contains":
                        //TODO
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        break;
                    //TODO

                    default:
                        break;
                }
            }
        }
    }
}
