using System;

namespace ProjectCourse
{
    class Program
    {

        static void Task1()
        {
            // The user enters the number of hours, output the number of minutes in that number of hours.

            Console.WriteLine("Please enter hour(s):");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = hours * 60;

            Console.WriteLine($"Amount minutes in {hours}: {minutes}");
            //Console.WriteLine();
        }
        static void Task2()
        {
            // The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
            try
            {
                Console.WriteLine($"The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console");
                Console.WriteLine($"Write number A:");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write number B:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Answer for solution (5*A+B^2)/(B-A) is:  {(5 * A + B * B) / (B - A)}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("error: divided by zero.");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("error: out of range");
            }
            catch
            {
                Console.WriteLine("error: wrong format");
            }

        }
        static void Task3()
        {
            // The user enters 2 string values (A and B). Swap the contents of variables A and B.
            Console.WriteLine("Please enter string phrase number 1:");
            string phrase1 = Console.ReadLine();

            Console.WriteLine("Please enter string phrase number 2:");
            string phrase2 = Console.ReadLine();

            string phrase1savelocation = phrase1;
            string phrase2savelocation = phrase2;



            Console.WriteLine($"Your phrase #1 is: {phrase1}");
            Console.WriteLine($"Your phrase #2 is: {phrase2}");
            phrase2 = phrase1savelocation;
            phrase1 = phrase2savelocation;
            Console.WriteLine($"Swapped phrase #1 and #2: {phrase1} and {phrase2} ");
        }
        static void Task4()
        {
            // The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
            Console.WriteLine($"Write numbers:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Dividing A by B: {A / B}");
            Console.WriteLine($"Division remainder: {A % B}");
        }
        static void Task5()
        {
            // The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.

            Console.WriteLine($"Print to the console the solution (X value) of the standard linear equation, where A*X+B=C");
            Console.WriteLine($"Write number A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write number B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write number C:");
            int C = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($" X value is: {(C-B)/A}");


        }
        static void Task6()
        {
            // The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane. Output the equation of a straight line in the format Y=AX+B passing through these points.
            Console.WriteLine($"Output the equation of a straight line in the format Y=AX+B passing through these points.");
            Console.WriteLine($"Write number X1:");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write number X2:");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write number Y1:");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write number Y2:");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            int A = Y2 - Y1 / X2 - X1;
            int B = (Y2+A)+(X2+A);


            Console.WriteLine($"Output format: Y={A}x+{B}");


        }
        static void Task7()
        {
            // The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
            Console.WriteLine($"The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.");
            Console.WriteLine($"Write number N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = (sum + N % 10) + (N / 10);

            Console.WriteLine($"the sum is: {sum}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Course Tasks");
            Task7();
        }
    }
}
