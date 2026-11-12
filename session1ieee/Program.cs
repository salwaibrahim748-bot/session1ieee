namespace session1ieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            if (String.Equals(Name, "ieee", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("my name is IEEE");
            }
            else
            {
                Console.WriteLine("not IEEE");
            }
            string result = String.Equals(Name, "ieee", StringComparison.OrdinalIgnoreCase) ? "my name is IEEE" : "not IEEE";
            Console.WriteLine(result);
            #endregion

            #region task2
            Console.WriteLine("Enter a day number (1-7)");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            #endregion

            #region task3
            //shallow copy
            //  Console.WriteLine(p1) => ID: 2 :: Name : Omer  (prediction and Actual output)
            //  Console.WriteLine(p2) => ID: 2 :: Name : Omer  (prediction and Actual output)
            // 2. The statement p1 = p2 copies the reference (memory address) . 
            #endregion

            #region task4
            //i can't do it
            #endregion

            #region task5
            Console.WriteLine("Enter number 1");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else if (x < y)
            {
                Console.WriteLine($"{y} is greater than {x}");
            }
            else
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            //This branch (y != x) can never be executed Because the first three conditions
            //cover all possible relationships between any two numbers

            #endregion

            #region task6
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator (+,_,*,/,%)");
            char op = Console.ReadLine()[0];
            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result is : {num1 + num2}");
                    break;
                case '_':
                    Console.WriteLine($"Result is : {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result is : {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result is : {num1 / num2}");
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Modulos by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result is : {num1 % num2}");
                    }

                    break;

                default:
                    {
                        Console.WriteLine("Invalid operator");
                        break;
                    }
                    //  2 / 4 = 0  performs integer division which truncates the decimal part (yielding 0)
                    //  (double) 2 / 4 = 0.5  casts the number to a double
                    //  2 % 4 = 2
                    //  7 % 3 = 1 
            #endregion

            #region task7
                    Console.WriteLine("Enter a year to check if it's a leap year:");
                    int year = int.Parse(Console.ReadLine());
                    bool isLeapYear = (year % 4 == 0 && !(year % 100 == 0)) || (year % 400 == 0); // اما ان تقبل القسمه على 4 ومعها لا تقبل القسمه على 100 او انها تقبل القسمه على 400
                    if (isLeapYear)
                    {
                        Console.WriteLine($"{year} is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is NOT a Leap Year.");
                    }

                    //Grade Classifier
                    Console.WriteLine("Enter a score (0 - 100):");
                    int score = int.Parse(Console.ReadLine());
                    if (!(score >= 0) && (score >= 0))
                    {
                        Console.WriteLine("Invalid score! Please enter a value between 0 and 100.");
                    }
                    else if (score >= 90)
                    {
                        Console.WriteLine("Grade: A");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine("Grade: B");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine("Grade: C");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine("Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Grade: F");
                    } 
                    #endregion














            }
        }
    }
}
