using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string userName;

            Console.WriteLine("Hello, What is your first name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.WriteLine("What is your Reddit username?");
            userName = Console.ReadLine();

            string result = "Hello " + name + ". It's nice to meet you. You are " + age +
                            " years old. And your Reddit username is " + userName + ". See you on Reddit!";
            Console.WriteLine(result);
            File.AppendAllText("../../easy-1.txt", "First name: " + name + " - Age: " + age + " - Reddit username: " + userName + "\n");
        }
    }
}
