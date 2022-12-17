using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace prime_number_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the two limits");
            bool is_prime_number=true;
            int num1, num2, i;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());


            //receiving input from the user 

            Console.WriteLine();
            Console.WriteLine(); //spaces so the program doesnt become cluttered 
            Console.WriteLine();


            if (num1<=1)
            {
                num1 = 2;  //an instruction to eliminate 0 , 1 since they are not prime numbers
            }
            for (num1 = num1; num1 <= num2; num1++) //invoking all the numbers between the two limits  
            {   
                for (i = 2; i < num1; i++)
                {
                    if (num1 % i == 0) //testing if the number is divisble by any number  
                    {
                        is_prime_number = false; //if it was then break and return to check the next number 
                        break;
                    }
                    else
                    {
                       is_prime_number = true; //if it wasnt therefore it is a prime number 
                    }                   
                }
                if (is_prime_number)
                {
                    Console.WriteLine(num1); //print every prime number within the two limits 
                }
            }
        }
    }
}