using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp.easy;

namespace C_Sharp
{
    class Program
    {
        // Create an enum to hold the values of the individual challenges.
        public enum Challenges
        {
            Challenge1, Challenge2, Challenge3, Challenge4, Challenge5, Challenge6, Challenge7, Challenge8, Challenge9, Challenge10, Challenge11, Challenge12, Challenge13
        }

        //
        public Challenges challenges;
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("Select from the following challenges to run");
            var values = Enum.GetValues(typeof(Challenges));
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine((i+1)+ " - " + values.GetValue(i));
            }
            var selection = Console.In.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Running Challenge 1\n");
                    var chal1 = new Challenge001();
                    chal1.RunProg();
                    break;
                case "2":
                    Console.WriteLine("Running Challenge 2\n");
                    var chal2 = new Challenge002();
                    chal2.RunProg();
                    break;
                case "3":
                    Console.WriteLine("Running Challenge 3\n");
                    var chal3 = new Challenge003();
                    chal3.RunProg();
                    break;
                case "4":
                    Console.WriteLine("Running Challenge 4\n");
                    var chal4 = new Challenge004();
                    chal4.RunProg();
                    break;
                case "5":
                    Console.WriteLine("Running Challenge 5\n");
                    var chal5 = new Challenge005();
                    chal5.RunProg();
                    break;
                case "6":
                    Console.WriteLine("Running Challenge 6\n");
                    var chal6 = new Challenge006();
                    chal6.RunProg();
                    break;
                case "7":
                    Console.WriteLine("Running Challenge 7\n");
                    var chal7 = new Challenge007();
                    chal7.RunProg();
                    break;
                case "8":
                    Console.WriteLine("Running Challenge 8\n");
                    var chal8 = new Challenge008();
                    chal8.RunProg();
                    break;
                case "9":
                    Console.WriteLine("Running Challenge 9\n");
                    var chal9 = new Challenge009();
                    chal9.RunProg();
                    break;
                case "10":
                    Console.WriteLine("Running Challenge 10\n");
                    var chal10 = new Challenge010();
                    chal10.RunProg();
                    break;
                case "11":
                    Console.WriteLine("Running Challenge 11\n");
                    var chal11 = new Challenge011();
                    chal11.RunProg();
                    break;
                case "12":
                    Console.WriteLine("Running Challenge 12\n");
                    var chal12 = new Challenge012();
                    chal12.RunProg();
                    break;
                case "13":
                    Console.WriteLine("Running Challenge 13\n");
                    var chal13 = new Challenge013();
                    chal13.RunProg();
                    break;
            }
            Console.ReadLine();
        }
    }
}
