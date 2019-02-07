using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int secondnumber = int.Parse(Console.ReadLine());
            if (firstnumber>secondnumber)
            {
                Console.WriteLine("first num is greater than second num");
            }
            else if (secondnumber>firstnumber)
            {
                Console.WriteLine("second num is greater than first num");   
            }
            else
            {
                Console.WriteLine("the two nums are equal");
            }

            string password = "moreenn";
            string name = "moreen";
            Console.WriteLine("enter name");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter password");
            string password1 = Console.ReadLine();
            if ((name!=name1)&&(password!=password1))
            {
                Console.WriteLine("invalid name or password");
                Console.WriteLine("try again");
            }
            else
            {
                Console.WriteLine("welcome,enjoy our code");
            }
            Console.WriteLine("enter any number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                 case  1 :
                 case 3:
                 case 5:
                 case 7:
                 case 9:
                 Console.WriteLine("the number is odd");
                 break;
                 case  2 :
                 case 4:
                 case 6:
                 case 8:
                     Console.WriteLine("the number is even");
                     break;
                 default:
                     Console.WriteLine("the number you entered is out of bounds");
                     break;
             
            }
            
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}