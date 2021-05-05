using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Exam____Sherlon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetMyInfo");
            GetMyInfo();
            Console.WriteLine("Characters in string ");
            CharactersInString();
            Console.WriteLine("Odd and Even Numebers");
            OddAndEvenNumbers();
            Console.WriteLine("Count to ten");
            CountToTen();
            Console.WriteLine("Multiple or add");
            MultipleOrAdd();
            Console.WriteLine("Day of the week");
            DayOfTheWeek();
            Console.WriteLine("Positive or negative");
            PositiveOrNegative();
            Console.WriteLine("factorial");
            factorial();
            Console.WriteLine("Array to uppercase");
            Array();
        }

        public static void GetMyInfo()
        {
            try
            {
                string firstName, lastName;
                DateTime now = DateTime.Now;
                Console.WriteLine("Enter your first name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                lastName = Console.ReadLine();
                Console.WriteLine(firstName + " " + lastName + " " + now);
                Console.ReadKey();


            }

            catch(Exception ex)

            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

           
            
        }

        public static void CharactersInString()
        {
            try
            {
                int count;
                string name;
                Console.WriteLine("Enter a string: ");
                name = Console.ReadLine();
                count = name.Length;
                Console.WriteLine("The output is: " + count);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void OddAndEvenNumbers()
        {
            try
            {
                int number, remainder;
                Console.WriteLine("Enter an integer: ");
                number = int.Parse(Console.ReadLine());
                remainder = number % 2;
                if (remainder == 0)
                {
                    Console.WriteLine(number + " is an even number ");
                }
                else
                {
                    Console.WriteLine(number + " is an odd number");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void CountToTen()
        {
            try
            {
                int a;
                a = 1;
                while (a <= 10)
                {
                    Console.Write(" "+ a);
                    a++;
                }
                 Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void MultipleOrAdd()
        {
            try
            {
                int a, b;
                string operand;
                Console.WriteLine("Enter a number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter operand * or +");
                operand = Console.ReadLine();
                Console.WriteLine("Enter a number: ");
                b = int.Parse(Console.ReadLine());

                if (operand == "*")
                {
                    Console.WriteLine( a * b);
                    Console.ReadKey();
                }
                else if (operand == "+")
                {
                    Console.WriteLine( a + b);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }




        }

         public static void DayOfTheWeek()
         { 
             try
             {
                DateTime date = new DateTime(2021, 3, 12);
                Console.WriteLine("{0:d} is {1}.", date, date.DayOfWeek);
                Console.ReadKey();
                 
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 Console.ReadKey();
             }


         }

        public static void PositiveOrNegative()
        {
            try
            {
                int number;
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine(number + " is Negative");

                }
                else
                {
                    Console.WriteLine(number + " is Positive");

                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void Array()
        {
            try
            {
                string[] words = { "One", "Two", "Three", "Four" };
                string singleString = String.Join(",", words);
                Console.WriteLine(words);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }

        public static void factorial()
        {
            try
            {
                int number;
                Console.WriteLine("Enter a Number: ");
                number = int.Parse(Console.ReadLine());

                double result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                    Console.WriteLine(result);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }

    }

}
