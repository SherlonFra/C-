using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_exam
{
    class greaterThan
    {
        static void Main(string[] args)
        {
            //GREATEST VALUE CODE///////////////////////////////////

            /*int a;
            int b;
            int c;
            bool restart = true;
            
            while (restart)
            {
                Console.WriteLine("Input 3 values: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                Console.ReadLine();


                if (a > b && a > c)
                {
                    Console.WriteLine(a + " is the greatest value");
                    Console.ReadLine();
                }

                else if (b > a && b > c)
                {
                    Console.WriteLine(b + " is the greatest value");
                    Console.ReadLine();
                }

                else if (c > a && c > b)
                {
                    Console.WriteLine(c + " is the greatest value");
                    Console.ReadLine();
                }





                Console.WriteLine("Press R to restart");
                string again = Console.ReadLine();
                again = again.ToLower();

                if (again == "r")

                {
                    restart = true;
                    Console.Clear();
                }

                else
                {
                    restart = false;
                }


            }*/




            //GRADE AVERAGE CODE/////////////////////////////////////////


            /*double quizScore;
            double midTermScore;
            double finalScore;
            string grade;
            Console.Write("Enter QuizScore:  ");
            quizScore = double.Parse((Console.ReadLine()));
            Console.Write("Enter MidTerm Score:  ");
            midTermScore = double.Parse((Console.ReadLine()));
            Console.Write("Enter Final Score:  ");
            finalScore = double.Parse((Console.ReadLine()));

            double average = (quizScore + midTermScore + finalScore) / 3;

            if(average >= 90)
            {
                grade = "A";
                Console.WriteLine("Your grade is: " + grade);
                Console.ReadLine();
            }
            else if (average >= 70 && average < 90)
            {
                grade = "B";
                Console.WriteLine("Your grade is: " + grade);
                Console.ReadLine();

            }
            else if (average >= 50 && average < 90)
            {
                grade = "C";
                Console.WriteLine("Your grade is: " + grade);
                Console.ReadLine();

            }
            else if (average < 50)
            {
                grade = "F";
                Console.WriteLine("Your grade is: " + grade);
                Console.ReadLine();
            }

            Console.ReadLine();*/



            //NUMBER OF INTEGERS IN A NUMBER///////////////////////////////////

            /*int number;

            Console.Write("Enter integer value: ");
            number = int.Parse(Console.ReadLine());
                
            int counter = 0;
                while( number>0)
                {
                    number = number / 10;
                    counter++;
                }

                Console.WriteLine("Integer has "+ counter +" numbers.");
                Console.ReadLine();*/


            //NUMBER OF SPACE IN STRING//////////////////////////////////////////

           
            int ctr = 0;
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ctr++;
                }
            }

            Console.Write("Spaces in this string: "+ ctr);
            Console.ReadLine();






        }
    }
}
