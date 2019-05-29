using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string maxPalindrome = "";
            string maxPalindrome2 = "";

            for (int i=0; i<input.Length-2; i++)
            {
                if(input[i] == input[i+1])
                {
                    for(int j=0; j <= input.Length-i; j++)
                    {
                        if (input[i - j] == input[i + 1 + j])
                        {
                            maxPalindrome = input[i - j] + maxPalindrome + input[i + 1 + j];
                        }
                        else
                            break;
                    }
                }

                if(input[i] == input[i+2])
                {
                    for (int j = 0; j <= input.Length - i; j++)
                    {
                        if (input[i - j] == input[i + j])
                        {
                            maxPalindrome = input[i - j] + maxPalindrome + input[i + j];
                        }
                        else
                            break;
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
            Console.ReadLine();
        }
    }
}
