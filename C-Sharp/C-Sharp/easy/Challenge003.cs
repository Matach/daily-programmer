/* This challenge is to create a encryption program and as an extra credit exercise a decryption program as well. Caesar cypher is the base encryption technique for this exercise.
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.easy
{
    class Challenge003
    {
        public char[] lowerAlphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
            'w', 'x', 'y', 'z'
        };

        public char[] upperAlphabet =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        public char[] symbols =
        {
            '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '\\', '|', '[', ']', '{', '}', ';', ':', '"', '\'', '/', '?', '.', '>', ',', '<'
        };

        public string text;
        public void RunProg()
        {
            Console.WriteLine("Welcome to the cypher program. Do you wish to encrypt or decrypt a message?");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "encrypt":
                    CaesarEncrypt();
                    break;
                case "decrypt":
                    CaesarDecrypt();
                    break;
                default:
                    Console.WriteLine("That is not a valid option. Enter encrypt to encrypt a message or decrypt to decrypt a message.");
                    break;
            }
        }

        public void CaesarEncrypt()
        {
            Console.WriteLine("What is the text that you want to encrypt?");
            text = Console.ReadLine();

        }

        public void CaesarDecrypt()
        {
            Console.WriteLine("What is the text that you want to decrypt?");
            text = Console.ReadLine();

        }

        public void Print()
        {
            Console.WriteLine(text);
        }
    }
}
