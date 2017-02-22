/* This challenge is to create a calculator. The calculator will have two modes, calculating celcius to fahrenheit and back, and 
 * calculating each of the variables of Newton's second law.
 * 
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.easy
{
    class Challenge002
    {
        public int celcius, fahrenheit, mass, force, acceleration;

        public void RunProg()
        {
            Console.WriteLine("Welcome to the simple physics calculator.");
            Console.WriteLine(
                "This calculator converts temperature between fahrenheit and celsius, and the third variable of Newton's third law.");
            Console.WriteLine("Enter calc f to begin the fahrenheit calculator.");
            Console.WriteLine("Enter calc c to begin the celcius calculator.");
            Console.WriteLine("Enter calc mass to begin the mass calculator.");
            Console.WriteLine("Enter calc accel to begin the acceleration calculator.");
            Console.WriteLine("Enter calc vel to begin the velocity calculator.");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "calc f":
                    CalcFahren();
                    break;
                case "calc c":
                    CalcCel();
                    break;
                case "calc mass":
                    CalcMass();
                    break;
                case "calc accel":
                    CalcAccel();
                    break;
                case "calc vel":
                    CalcVel();
                    break;
                default:
                    Console.WriteLine("I'm sorry thats not a valid option.");
                    break;
            }

        }

        public void CalcFahren()
        {

        }

        public void CalcCel()
        {

        }

        public void CalcMass()
        {

        }

        public void CalcAccel()
        {

        }

        public void CalcVel()
        {

        }
    }
}
