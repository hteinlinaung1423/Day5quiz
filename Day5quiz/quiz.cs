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
            bool needtorepeat = true;
            while (needtorepeat)
            {
                int total = 0; char checksum = ' ';
                Console.Write("Enter a matriculation number : ");
                input = Console.ReadLine();
                input = input.ToUpper();
                if (input.Length == 7)
                {
                    string a = input[0].ToString();
                    if (a != "A")
                    {
                        Console.WriteLine("Invalid");

                    }

                    else
                    {
                        string num = input.Substring(1, 5);

                        for (int i = 0; i <= 4; i++)
                        {
                            int j = 6;

                            total += (num[i] * j);
                            j--;
                        }

                        int remain = total % 5;
                        checksum = input[6];

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
