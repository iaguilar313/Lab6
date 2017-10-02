using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;
            while (ProgramContinue == true)
            {
                Console.WriteLine("Please Enter 1 Word");
                //reads user input an converts it to lowercase 
                string userInput = Console.ReadLine().ToLower();

                //isolates first index of string
                // checks if index value 0 is a vowel 
                //string[0] tells it to look at index 0 can place any index 

                if (userInput[0] == 'a' || userInput[0] == 'e' || userInput[0] == 'i' || userInput[0] == 'o' || userInput[0] == 'u')
                {
                    Console.WriteLine(userInput + "way");
                }
                else
                {
                    int pig = userInput.IndexOfAny(new char[] { 'a', 'e', 'o', 'u', 'i' });

                    Console.WriteLine((userInput.Substring(pig)) + (userInput.Substring(0, pig)) + "`" +
                        "ay");


                    //userInput.IndexOf('a') != -1 || userInput.IndexOf('e') != -1 || userInput.IndexOf('i') != -1 || userInput.IndexOf('o') != -1 || userInput.IndexOf('u') != -1

                    // string pig = userInput.SubString();
                }
                
               
                if (ReadValidtion() == "no")
                {
                    ProgramContinue = false;
                }
            }
        }

        public static string ReadValidtion ()
        {
            Console.WriteLine("Do you want to roll the dice again? Yes or No");
            string Input= Console.ReadLine().ToLower();
            while (Input!= "yes" && Input != "no" )
            {
                Console.WriteLine("Please enter either Yes or No");
                Input = Console.ReadLine().ToLower();
            }
            return Input;
        }
    }
}
