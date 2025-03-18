namespace CourseAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Even or Odd

            int num1;
            Console.WriteLine("Enter a Number");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + "is an Even Number");

            }
            else
            {
                Console.WriteLine(num1 + "is an Odd Number");
            }
            //-----------------------------------------------------------

            //  2.Largest of Three Numbers
            int numb1, num2, num3, large;
            Console.WriteLine("Enter First Number:");
            numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3 = int.Parse(Console.ReadLine());

            if (numb1 > num2 && numb1 > num3)
            {
                large = numb1;
            }
            else if (num2 > numb1 && num2 > num3)
            {
                large = num2;
            }
            else
            {
                large = num3;
            }
            Console.WriteLine("The Largest Number is " + large);
            //--------------------------------------------------------------

            // 3.Temperature Converter
            double temp, Fahrenheit;
            Console.WriteLine("Enter Temperature in Celsius");
            double Celsius = double.Parse(Console.ReadLine());

            Fahrenheit = (Celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is " + Fahrenheit);

            //----------------------------------------------------------------

            // 4.Simple Discount Calculator
            float Price, FinalPrice, Discount;
            Console.WriteLine("Enter The Price");
            Price = float.Parse(Console.ReadLine());

            if (Price > 100)
            {
                Discount = (Price / 100) *10;
                FinalPrice = Price - Discount;
                Console.WriteLine("Final Price is "+ FinalPrice);

            }
            else
            {
                FinalPrice = Price;
                Console.WriteLine("Final Price is "+ FinalPrice);
            }

            //-----------------------------------------------------------------

            // 5.Grading System
            float StudentMark;
            Console.WriteLine("Enter Your Score");
            StudentMark = float.Parse(Console.ReadLine());

            if (StudentMark >=90)
            {
                Console.WriteLine("A");
            }
            else if (StudentMark >=80)
            {
                Console.WriteLine("B");
            }
            else if (StudentMark >=70)
            {
                Console.WriteLine("C");
            }
            else if (StudentMark >=60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            //---------------------------------------------------------------

            // 6.Swap Two Numbers
            int a, b, c;
            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping First Number = " + a + ", Second Number = " + b);


            //---------------------------------------------(CSharpPart2Exercises)

            // 1.Simple Calculator(Switch Case)
            char choice;
            do
            {
                Console.Clear();
                int OperationNumber, number1, number2;
                Console.WriteLine("Enter The Operation Number:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");

                OperationNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter First Number: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                number2 = int.Parse(Console.ReadLine());

                double result = 0;
                bool isActive = false;
                switch (OperationNumber)
                {
                    case 1:
                        result = number1 + number2;
                        break;

                    case 2:
                        result = number1 - number2;
                        break;

                    case 3:
                        result = number1 * number2;
                        break;

                    case 4:
                        if (number2 == 0)
                        {
                            Console.WriteLine("Division by Zero is not allowed");
                            isActive = true;
                        }

                        else
                        {
                            result = number1 / number2;

                        }
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
                if (!isActive)
                {
                    Console.WriteLine(result);
                }
                Console.WriteLine("Do you want another Operation? Y / N");
                choice = Console.ReadKey().KeyChar;



            } while (choice == 'Y' || choice == 'y');
            Console.WriteLine("\nSee You Next Time");


            //-------------------------------------------------------------------

            //2. Basic ATM System


            double balance = 1000;
            double withdraw, deposit;
            Console.WriteLine("\n==== Banking System ====");
            Console.WriteLine("1. Withdraw Money");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    if (balance == 0)
                    {
                        Console.WriteLine("Your Balance " + balance + "  is not Valid to withdraw");

                    }
                    else
                    {
                        Console.WriteLine("Enter amount to withdraw\n");
                        withdraw = double.Parse(Console.ReadLine());
                        withdraw = balance - withdraw;
                        Console.WriteLine("Your Balance is " + balance);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter amount to deposit");
                        deposit = double.Parse(Console.ReadLine());
                        deposit = balance + deposit;
                        Console.WriteLine("Your Balance is " + balance);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Your Balance is " + balance);
                    }
                    break;
                case 4:
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
            //--------------------------------------------------------------
            //3. Geometry Calculator
            Console.WriteLine("Choose a Shape :\n1. Circle\n2. Square\n3.Triangle ");
            int shape = int.Parse(Console.ReadLine());
            double radius, SideLength, Tbase, height;
            switch (shape)
            {
                case 1:
                    Console.WriteLine("Enter Circle radius: ");
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {Math.PI * radius * radius}, Circumference: {2 * Math.PI * radius}");

                    break;
                case 2:
                    Console.Write("Enter Square side length: ");
                    SideLength = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {SideLength * SideLength}, Perimeter: {4 * SideLength}");
                    break;
                case 3:
                    Console.Write("Enter Triangle base: ");
                    Tbase = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {0.5 * Tbase * height}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }

            //-------------------------------------------------
            //4. Factorial of a Number 
            Console.WriteLine("Enter a number");
            int N = int.Parse(Console.ReadLine());
            double fact = 1;
            for (int i = 1; i <= N; i++) fact *= i;
            Console.WriteLine($"Factorial: {fact}");

            //----------------------------------------------------------------
            //5. Sum of Even and Odd Numbers
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            int SumEven = 0, SumOdd = 0;

            for (int i = 1; i <= n; i++)
                if (i % 2 == 0) SumEven += i; else SumOdd += i;

            Console.WriteLine($"Sum of Even: {SumEven}, Sum of Odd: {SumOdd}");

            //---------------------------------------------------------
            //6. Scientific Calculator (Switch-Case & Math Functions)
            Console.Write("Choose an operation \n(sin, cos, tan, sqrt, log, pow): ");
            string operation = Console.ReadLine();
            Console.Write("Enter Number: ");
            double number = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "sin": Console.WriteLine($"Result: {Math.Sin(number)}"); break;
                case "cos": Console.WriteLine($"Result: {Math.Cos(number)}"); break;
                case "tan": Console.WriteLine($"Result: {Math.Tan(number)}"); break;
                case "sqrt": Console.WriteLine($"Result: {Math.Sqrt(number)}"); break;
                case "log": Console.WriteLine($"Result: {Math.Log(number)}"); break;
                case "pow":
                    Console.Write("Enter an exponent: ");
                    double exp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Pow(number, exp)}");
                    break;
                default: Console.WriteLine("Operation is Invalid"); break;
            }
            //------------------------------------------------------------


            //7. Print Pattern (For Loop)
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
                Console.WriteLine(new string('*', i));

            //---------------------------------------------------------------
            //8.Print a Pyramid Pattern (For Loop)
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
                Console.WriteLine(new string(' ', N - i) + new string('*', 2 * i - 1));

            //----------------------------------------------------------------
            //9. Print a Diamond Pattern (For Loop)

            //--------------------------------------------------------------
            //10. Guess Game with Helper

            Random rand = new Random();
            int target = rand.Next(1, 50);

            int guess;

            do
            {
                Console.Write("Guess the number (1-50): ");
                guess = int.Parse(Console.ReadLine());


                if (guess > target)
                    Console.WriteLine("Try Lower!");
                else if (guess < target)
                    Console.WriteLine("Try Higher!");
                else
                    Console.WriteLine("You Win!");


            } while (guess != target);












        }





    }

    }




