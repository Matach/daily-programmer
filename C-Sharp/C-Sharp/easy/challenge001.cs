/* This daily challenge accepts a name, age, and username for reddit. Once given it displays the information back to the user and writes the information to a file locally.
 * 
 * 
 * 
 */

using System;
using System.IO;

namespace C_Sharp.easy
{
    class Challenge001
    {
        public string Name, Age, Username;

        public void PrintGreeting()
        {
            string result = "Hello " + Name + ". You are " + Age + " years old. And your Reddit username is " + Username + ". See you on Reddit!";
            Console.WriteLine(result);
            File.AppendAllText("../../easy-1.txt", "First name: " + Name + " - Age: " + Age + " - Reddit username: " + Username + "\n");
        }
        public void RunProg()
        {
            Console.WriteLine("Hello, What is your first name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            Age = Console.ReadLine();
            Console.WriteLine("What is your Reddit username?");
            Username = Console.ReadLine();
        }
    }
}
