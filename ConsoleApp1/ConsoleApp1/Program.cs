using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool exit = false;
            while(exit == false)
            {
                Console.WriteLine("input number or exit");
                string Input = Console.ReadLine();
                int Loading = 0;
                Console.Clear();
                Console.WriteLine("Loading ");
                if (Input == "exit")
                {
                    exit = true;
                    Environment.Exit(1);
                }
                else
                {
                    exit = false;
                }
                while (99 > Loading)
                {
                    Random rnd = new Random();
                    Loading = Loading + rnd.Next(1, 10);
                    if(Loading > 100)
                    {
                        Loading = 100;
                    }
                    Console.Write("\r{0}%   ", Loading + "%");
                    
                    await Task.Delay(100);
                }
                Console.Clear();
                Console.WriteLine(string.Empty);
                int InputInt = Convert.ToInt32(Input, 10);
                int StaticInput = InputInt;

                string result = String.Empty;
                while (InputInt > 0)
                {
                    int remainder = InputInt % 2;
                    InputInt /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("Binary output:" + result);
                float Output = StaticInput / 1 * -1.25f;
                Console.WriteLine("Voltage output:" + Output + "V");
            
            }
        }
    }
    
}