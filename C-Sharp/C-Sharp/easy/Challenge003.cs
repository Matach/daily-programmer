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
                case default:
                    Console.WriteLine("That is not a valid option. Enter encrypt to encrypt a message or decrypt to decrypt a message.");
                    break;
            }
        }

        public void CaesarEncrypt()
        {
            
        }

        public void CaesarDecrypt()
        {
            
        }
    }
}
