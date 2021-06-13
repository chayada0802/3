using System;

namespace final3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                input = Console.ReadLine();

            } while (input!= "End");
            string mode;
            mode= Console.ReadLine();

            switch (mode)
            {
                case "FindMax"
:
                
                break
               ;
                case "FindMin"
:
                
                break
               ;
                case "FindMean"
:
                
                break
               ;
                default
:
                Console.WriteLine("Invalid mode");
                    break;
            }
            }
    }
}
