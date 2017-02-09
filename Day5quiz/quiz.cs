using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5quiz
{
    class quiz
    {
        static void Main(string[] args)
        {
            string input;
            bool needtorepeat = true; // if the user enter wrong pin, we need to ask them to enter again!
            while (needtorepeat)
            {
                int total = 0; char checksum = ' ';
                Console.Write("Enter a matriculation number : ");
                input = Console.ReadLine();
                input = input.ToUpper();// input string to upper case, so we don't need to worry about lower case!
                if (input.Length == 7) // if the input isn't meet minumun length 7, we should ask them to enter again!
                {
                    string a = input[0].ToString(); // first char of the string to check whether it is A or not!
                    if (a != "A")
                    {
                        Console.WriteLine("Invalid");

                    }

                    else
                    {
                        string num = input.Substring(1, 5);// take the numbers from string , so we can compute checksum!

                        for (int i = 0; i <= 4; i++)
                        {
                            int j = 6;

                            total += (num[i] * j); // compute total result based on all the numbers that user entered from the middle of string!
                            j--;
                        }

                        int remain = total % 5;
                        checksum = input[6]; // take the last charcter of the string! , so we can check whether it is valid or not!

                        switch (checksum) 
                        {
                            case 'O':
                                if (remain == 0)
                                {
                                    Console.WriteLine("Valid"); needtorepeat = false;
                                }
                                else { Console.WriteLine("Invalid"); needtorepeat = true; }
                                break;


                            case 'P':
                                if (remain == 1)
                                {
                                    Console.WriteLine("Valid"); needtorepeat = false;
                                }
                                else { Console.WriteLine("Invalid"); needtorepeat = true; }
                                break;
                            case 'Q':
                                if (remain == 2)
                                {
                                    Console.WriteLine("Valid"); needtorepeat = false;
                                }
                                else { Console.WriteLine("Invalid"); needtorepeat = true; }
                                break;
                            case 'R':
                                if (remain == 3)
                                {
                                    Console.WriteLine("Valid"); needtorepeat = false;
                                }
                                else { Console.WriteLine("Invalid"); needtorepeat = true; }
                                break;
                            case 'S':
                                if (remain == 4)
                                {
                                    Console.WriteLine("Valid"); needtorepeat = false;
                                }
                                else { Console.WriteLine("Invalid"); needtorepeat = true; }
                                break;
                            default: Console.WriteLine("Invalid"); break;

                        }
                    }
                }


                else
                {
                    Console.WriteLine("Invalid");
                }










            }

        }
    }
}
