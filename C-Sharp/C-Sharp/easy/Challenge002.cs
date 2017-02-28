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
        public void RunProg()
        {
            Console.WriteLine("Welcome to the simple physics calculator.");
            Console.WriteLine(
                "This calculator converts temperature between fahrenheit and celsius, and the third variable of Newton's second law.");
            Console.WriteLine("Enter calc f to begin the fahrenheit calculator.");
            Console.WriteLine("Enter calc c to begin the celcius calculator.");
            Console.WriteLine("Enter calc mass to begin the mass calculator.");
            Console.WriteLine("Enter calc accel to begin the acceleration calculator.");
            Console.WriteLine("Enter calc force to begin the force calculator.");

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
                case "calc force":
                    CalcForce();
                    break;
                default:
                    Console.WriteLine("I'm sorry thats not a valid option.");
                    break;
            }

        }

        public void CalcFahren()
        {
            Console.WriteLine("What is the desired celcius temperature to convert to fahrenheit?");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celcius * 1.8) + 32;
            Console.WriteLine("Original temp (C): {0}. Converted temp (F): {1}.", celcius, fahrenheit);
        }

        public void CalcCel()
        {
            Console.WriteLine("What is the desired celcius temperature to convert to fahrenheit?");
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            double celcius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("Original temp (F): {0}. Converted temp (C): {1}.", fahrenheit, celcius);
        }

        public void CalcMass()
        {
            Console.WriteLine("Mass calculator.");
            Console.WriteLine("Mass is determined by the equation M = F / A.");
            Console.WriteLine("To calculate mass, you must enter the amount of acceleration and the amount of force.");
            Console.WriteLine("What is the known force?");
            float force = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is the amount of acceleration?");
            float acceleration = Convert.ToSingle(Console.ReadLine());
            float mass = force / acceleration;
            Console.WriteLine("The amount of mass of the object is {0}.", mass);
        }

        public void CalcAccel()
        {
            Console.WriteLine("Acceleration calculator.");
            Console.WriteLine("Acceleration is determined by the equation A = F / M.");
            Console.WriteLine("To calculate acceleration, you must enter the amount of mass and the amount of force.");
            Console.WriteLine("What is the known amount of force?");
            float force = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is the known amount of mass?");
            float mass = Convert.ToSingle(Console.ReadLine());
            float acceleration = force / mass;
            Console.WriteLine("The amount of acceleration of the object is {0}.", acceleration);
        }

        public void CalcForce()
        {
            Console.WriteLine("Force calculator.");
            Console.WriteLine("Force is determined by the equation F = M * A.");
            Console.WriteLine("To calculate force, you must enter the amount of acceleration and the amount of mass.");
            Console.WriteLine("What is the known amount of acceleration?");
            float acceleration = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is the known amount of mass?");
            float mass = Convert.ToSingle(Console.ReadLine());
            float force = mass * acceleration;
            Console.WriteLine("The amount of force of the object is {0}.", force);
        }
    }
}
