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
                        //TODO
                        break;
                    case "del":
                        //TODO
                        break;
                    case "contains":
                        //TODO
                        break;
                    case "remove":
                        //TODO
                        break;
                    //TODO
                    case "large":
                        int number = int.Parse(cmd[1]);

                        var result = nums.Where(x => x > number);

                        Console.WriteLine(string.Join(" ", result));
                        break;
                    case "count":
                        int num = int.Parse(cmd[1]);

                        int count = nums.Count(x => x > num);

                        Console.WriteLine(count);
                        break;
                    

                    default:
                        break;
                }
            }
        }
    }
}
