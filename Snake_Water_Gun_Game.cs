/*
Two player game
Inputs : 'S' / 'W' / 'G'
Rules :
snake vs water - snake drinks water so snake wins
snake vs gun - gun kills snake so gun wins
water vs gun : gun drowns in water so water wins
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Snake_Water_Gun_Game
    {
        static void main()
        {
            Console.WriteLine("SNAKE, WATER, GUN"); //this is title of game
            char comp = '\0';  // it means null character
            //Random rnd = new Random();
            var rnd = new Random(); //var can take int , double value, any object , any randsom string
            var str = "swg";  //it means we are generating random character from this string i.e s, w, g
           
               var rndIndex = rnd.Next(str.Length);
               comp  = str[rndIndex];

            Console.Write("Enter 's' / 'w' / 'g' :");
            char user = Convert.ToChar (Console.ReadLine());

            Console.WriteLine($"Computer : {comp} | {user}");

            if(comp == user)
            {
                Console.WriteLine("Draw");
            }

            if (comp == 's' && user == 'w')
            {
                Console.WriteLine("Computer Wins");
            }

            if (comp == 's' && user == 'g')
            {
                Console.WriteLine("User Wins");
            }

            if (comp == 'w' && user == 's')
            {
                Console.WriteLine("User Wins");
            }

            if (comp == 'w' && user == 'g')
            {
                Console.WriteLine("Computer Wins");
            }

            if (comp == 'g' && user == 's')
            {
                Console.WriteLine("User Wins");
            }
            
            if (comp == 'g' && user == 'w')
            {
                Console.WriteLine("User Wins");
            }
        }
    }
}
