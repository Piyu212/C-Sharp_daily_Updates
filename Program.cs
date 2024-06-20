using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
namespace C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // int priya = 34; //creating integer variable

 
**  Datatypes in c# :   ** 
int - int priya  -- 4 bytes
long -- 8 bytes
floating point -  4 bytes
double   -- 8 bytes
character - char a = 'P' -- 1 bit ( 1 byte mhnj 8 bit ast
boolean - true , false
 */

// string inp = Console.ReadLine();   //console.readline he string return karat
// Console.WriteLine(inp);

//            Console.WriteLine("Hello C#");
//       Console.WriteLine("i love  C# and number" + priya);
//        Console.ReadLine();


/*
 ** TYPE CASTING : ek value ek dataype mdun dusrya data type mdhe convert krane: **
1) implicit casting  --> char to long to float to double
2) explicit casting  --> 
eg - int x = (int) 4.5;

eg - int x=3;
double y = x;

 */
/*    
( CONVERTING STRING TO INT )
 string stringNumber = "123";
int number = int.Parse(stringNumber);
Console.WriteLine("The number is: " + number);

string textNegative = "-98.8";
double negative = convert.Todouble(textNegative);
Console.Writeline(negative);
 */

/*
 ** Finding remainder between the division of 2 integer variables 

int FirstSum = 10;
int SecNum = 3;
console.Writeline(firstSum / SecNum);
console.Readline();
 */


/*
 *** Defining variable ***
 var age = 56;
Console.Wroiteline(age);
 */


/*
 ** CONST KEYWORD **
 const int  vat = 67;
vat = 90;    //chnage nahi karu shkat value const key use kely mhnun
 */



/*
// *** Exercise 1 - Storing user data : 
 string name = "Priya";
int number = 00006873883;
int age = 34;

Console.WriteLine(name);
Console.WriteLine(number);
Console.WriteLine(age);
Console.ReadLine();
*/



/*
//Exercise 2 - Odd even Checker

int num1 = 14;
int num2 = 7;
int remainder = num1 % num2;
Console.WriteLine(remainder);
Console.ReadLine();

/*

// ***** IF STATEMENTS *****

int number = 10;

if (number > 15)
{
    Console.WriteLine("The number is greater than 15.");
}
else if (number > 5)
{
    Console.WriteLine("The number is greater than 5 but less than or equal to 15.");
}
else
{
    Console.WriteLine("The number is 5 or less.");
    Console.ReadLine();

*/

// ***** SWITCH STATEMENTS *******
/*
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;


}

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


for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    Console.ReadLine();
}






// EXE 6 - Check number is even or odd
Console.WriteLine("enter the number");
int number = Convert.ToInt32(Console.ReadLine());
//if we do not have any remainder after dividing a number by 2 then it is even number
// 4/2 = 0(remainder) - it is even
// 5/2 = 1(remainder) - it is odd
if (number % 2 == 0)
{
    Console.WriteLine("it is an odd number");
}
else
{
    Console.WriteLine("it is odd");
    Console.ReadLine();
}


Console.WriteLine("SNAKE, WATER, GUN"); //this is title of game
char comp = '\0';  // it means null character
//Random rnd = new Random();
var rnd = new Random(); //var can take int , double value, any object , any randsom string
var str = "swg";  //it means we are generating random character from this string i.e s, w, g

var rndIndex = rnd.Next(str.Length);
comp = str[rndIndex];

Console.Write("Enter 's' / 'w' / 'g' :");
char user = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"Computer : {comp} | {user}");

if (comp == user)
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
 */