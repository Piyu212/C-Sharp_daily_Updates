using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class EXERCISE_1
    {
        static void main()
        {
            
            // EXE 1 - Enter 3 inputs and multiply them.
            int a, b, c;
            a = 5;
            b = 2;
            c = 1;
            int d = a * b * c;
            Console.WriteLine($"multiplication of {a} , {b}, {c} is {d}");
            

            //EXE 2 - Enter 2 numbers , print their average
            int n1 = 5;
            int n2 = 3;
            int avg = (n1 + n2) / 2;
            Console.WriteLine(avg);
            Console.ReadLine();


            //EXE 3 - If someone enters negative value then show error msg "WE DO NOT ACCPET NEGATIVE VALUE".
            Console.WriteLine("Enter any number:");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("WE DO NOT ACCEPT NEGATIVE VALUE:");
                Console.ReadLine();
            }

            // EXE 4 - Print two stars ** 4 times
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("**");
            }

            /*
            //EXE 5 - Print this pattern 
            *
            **
            ***
            ****
            *****
            */
             for(int i =1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadLine();

            }

            //EXE 6 - Check number is even or odd
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            //if we do not have any remainder after dividing a number by 2 then it is even number
            // 4/2 = 0(remainder) - it is even
            // 5/2 = 1(remainder) - it is odd
            if(number % 2 == 0)
            {
                Console.WriteLine("it is an odd number");

            }
            else
            {
                Console.WriteLine("it is odd");
            }




        }
    }
}