namespace CourseAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    //1. Even or Odd

            //    int num1;
            //    Console.WriteLine("Enter a Number");
            //    num1 = int.Parse(Console.ReadLine());

            //    if (num1 % 2 == 0)
            //    {
            //        Console.WriteLine(num1 + "is an Even Number");

            //    }
            //    else
            //    {
            //        Console.WriteLine(num1 + "is an Odd Number");
            //    }
            ////-----------------------------------------------------------

            //2. Largest of Three Numbers
            //int num1, num2, num3, large;
            //Console.WriteLine("Enter First Number:");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Third Number");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1 > num3)
            //{
            //    large = num1;
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    large = num2;
            //}
            //else
            //{
            //    large = num3;
            //}
            //Console.WriteLine("The Largest Number is " + large);
            ////--------------------------------------------------------------

            //3. Temperature Converter
            //double temp, Fahrenheit;
            //Console.WriteLine("Enter Temperature in Celsius");
            //double Celsius = double.Parse(Console.ReadLine());

            //Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine("Temperature in Fahrenheit is " + Fahrenheit); 

            ////----------------------------------------------------------------

            //4. Simple Discount Calculator
            //float Price, FinalPrice, Discount;
            //Console.WriteLine("Enter The Price");
            //Price = float.Parse(Console.ReadLine());

            //if (Price > 100)
            //{
            //    Discount = (Price / 100) *10;
            //    FinalPrice = Price - Discount;
            //    Console.WriteLine("Final Price is "+ FinalPrice);

            //}
            //else
            //{
            //    FinalPrice = Price;
            //    Console.WriteLine("Final Price is "+ FinalPrice);
            //}

            ////-----------------------------------------------------------------

            //5. Grading System
            //float StudentMark;
            //Console.WriteLine("Enter Your Score");
            //StudentMark = float.Parse(Console.ReadLine());

            //if (StudentMark >=90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (StudentMark >=80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (StudentMark >=70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (StudentMark >=60)
            //{
            //    Console.WriteLine("D");
            //}
            //else 
            //{
            //    Console.WriteLine("F");
            //}

            ////---------------------------------------------------------------

            //6. Swap Two Numbers
            //int a, b,c;
            //Console.WriteLine("Enter First Number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //b = int.Parse(Console.ReadLine());

            //c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("After Swapping First Number = " + a + ", Second Number = " + b);


            //---------------------------------------------(CSharpPart2Exercises)

            //1. Simple Calculator (Switch Case)
            //char choice;
            //do
            //{
            //    Console.Clear();
            //    int OperationNumber, num1, num2;
            //    Console.WriteLine("Enter The Operation Number:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");

            //    OperationNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter First Number: ");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    double result = 0;
            //    bool isActive = false;
            //    switch (OperationNumber)
            //    {
            //        case 1:
            //            result = num1 + num2;
            //            break;

            //        case 2:
            //            result = num1 - num2;
            //            break;

            //        case 3:
            //            result = num1 * num2;
            //            break;

            //        case 4:
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Division by Zero is not allowed");
            //                isActive = true;
            //            }

            //            else
            //            {
            //                result = num1 / num2;

            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            break;

            //    }
            //    if (!isActive)
            //    {
            //        Console.WriteLine(result);
            //    }
            //    Console.WriteLine("Do you want another Operation? Y / N");
            //    choice = Console.ReadKey().KeyChar;



            //} while (choice == 'Y' || choice == 'y');
            //Console.WriteLine("\nSee You Next Time");


            //-------------------------------------------------------------------
            //2. Basic ATM System



            float balance = 1000;
            string userChoice;


            while (true)
            {

                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Withdraw Money");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");


                Console.Write("choose an option: ");
                userChoice = Console.ReadLine();


                switch (userChoice)
                {
                    case "1":
                    Console.Write("Enter the amount to withdraw: ");
                    float withdrawAmount = float.Parse(Console.ReadLine());

                    if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient funds Withdrawal failed.");
                    }
                    else
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"You withdrew {withdrawAmount}$. Your new balance is {balance}$");
                    }
                    break;





























































            } while (choice == 'Y' || choice == 'y');
            Console.WriteLine("\nSee You Next Time");

   //-------------------------------------------------------------------------------------

        //2.Basic ATM System
        double balance = 1000;
        int choice;

        do
        {
            // Display menu options
            Console.WriteLine("\n==== Banking System ====");
            Console.WriteLine("1. Withdraw Money");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            
            bool isValidInput = int.TryParse(Console.ReadLine(), out choice);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
                continue;
            }

            switch (choice)
            {
                case 1: // Withdraw Money
                    Console.Write("Enter amount to withdraw: $");
                    bool isValidWithdraw = double.TryParse(Console.ReadLine(), out double withdrawAmount);

                    if (!isValidWithdraw || withdrawAmount <= 0)
                    {
                        Console.WriteLine("Invalid amount! Please enter a positive number.");
                    }
                    else if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient funds! Withdrawal denied.");
                    }
                    else
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"Withdrawal successful! New balance: ${balance}");
                    }
                    break;

                case 2: // Deposit Money
                    Console.Write("Enter amount to deposit: $");
                    bool isValidDeposit = double.TryParse(Console.ReadLine(), out double depositAmount);

                    if (!isValidDeposit || depositAmount <= 0)
                    {
                        Console.WriteLine("Invalid amount! Please enter a positive number.");
                    }
                    else
                    {
                        balance += depositAmount;
                        Console.WriteLine($"Deposit successful! New balance: ${balance}");
                    }
                    break;

                case 3: // Check Balance
                    Console.WriteLine($"Current balance: ${balance}");
                    break;

                case 4: // Exit
                    Console.WriteLine("Thank you for using our banking system.");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option");
                    break;
            }

        } while (choice != 4);
        }

        //-------------------------------------------------------------------

        //3.Geometry Calculator
        
        int choice;

        do

        {

            // Display menu

            Console.WriteLine("\n==== Geometry Calculator ====");

            Console.WriteLine("1. Circle (Area & Circumference)");

            Console.WriteLine("2. Square (Area & Perimeter)");

            Console.WriteLine("3. Triangle (Area)");

            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");



            

            bool isValidInput = int.TryParse(Console.ReadLine(), out choice);



            if (!isValidInput)

            {

                Console.WriteLine("Invalid input! Enter a number between 1 and 4.");

                continue;

            }



            switch (choice)

            {

                case 1: 

                    Console.Write("Enter the radius of the circle: ");

                    bool isValidRadius = double.TryParse(Console.ReadLine(), out double radius);



                    if (!isValidRadius || radius <= 0)

                    {

                        Console.WriteLine("Invalid radius! Please enter a positive number.");

                    }

                    else

                    {

                        double area = Math.PI * radius * radius;

                        double circumference = 2 * Math.PI * radius;

                        Console.WriteLine($"Circle Area: {area:F2}");

                        Console.WriteLine($"Circle Circumference: {circumference:F2}");

                    }

                    break;



                case 2: 

                    Console.Write("Enter the side length of the square: ");

                    bool isValidSide = double.TryParse(Console.ReadLine(), out double side);



                    if (!isValidSide || side <= 0)

                    {

                        Console.WriteLine("Invalid side length! Please enter a positive number.");

                    }

                    else

                    {

                        double area = side * side;

                        double perimeter = 4 * side;

                        Console.WriteLine($"Square Area: {area:F2}");

                        Console.WriteLine($"Square Perimeter: {perimeter:F2}");

                    }

                    break;



                case 3: 

                    Console.Write("Enter the base of the triangle: ");

                    bool isValidBase = double.TryParse(Console.ReadLine(), out double baseLength);

                    Console.Write("Enter the height of the triangle: ");

                    bool isValidHeight = double.TryParse(Console.ReadLine(), out double height);



                    if (!isValidBase || baseLength <= 0 || !isValidHeight || height <= 0)

                    {

                        Console.WriteLine("Invalid input! Base and height must be positive numbers.");

                    }

                    else

                    {

                        double area = 0.5 * baseLength * height;

                        Console.WriteLine($"Triangle Area: {area:F2}");

                    }

                    break;



                case 4: 

                    Console.WriteLine("Thank you for using the Geometry Calculator \nGoodbye");

                    break;



                default:

                    Console.WriteLine("Invalid choice! Please select a valid option");

                    break;

            }



        } while (choice != 4);

      //------------------------------------------------------------------------------------------------

        //4.Factorial of a Number
        
        Console.Write("Enter a non-negative integer: ");

        

        

        bool isValidInput = int.TryParse(Console.ReadLine(), out int number);



        if (!isValidInput || number < 0)

        {

            Console.WriteLine("Invalid input! Please enter a non-negative integer.");

        }

        else

        {

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is: {factorial}");

        }

    }



    static long CalculateFactorial(int n)

    {

        long result = 1;

        

        for (int i = 1; i <= n; i++)

        {

            result *= i; 

        }

        

        return result;

    }
    }
}
                 
               