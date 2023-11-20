using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exerice
{
    class Program
    {
        static void Main(string[] args)
        {
            // var obj = new NewProgram();


            // NewProgram.swapVarialbe();
            // NewProgram.findDistance();
            // NewProgram.findPercent();
            // NewProgram.findCircumference();
            // NewProgram.findProfitLoss();
            // NewProgram.tempInCentigrade();
            // NewProgram.swapVariable2();
            // NewProgram.perimeterOfRect();
            // NewProgram.litAndIllit();
            // NewProgram.nomAndDenom();
            // NewProgram.costPriceOfOneItem();
            // NewProgram.isLeapYear();
            // NewProgram.findAbsolute();
            // NewProgram.insuringDriver();
            // NewProgram.calcDivision();
            // NewProgram.checkHealth();
            // NewProgram.printPattern();
            // NewProgram.printPattern2();
            // NewProgram.printPattern3();
            // NewProgram.isPrime();
            // NewProgram.overTimePay();
            // NewProgram.findFactorial();
            // NewProgram.nameOfTheDay();
            // NewProgram.reversNum();
            // NewProgram.checkVowel();
            // NewProgram.daysOfMonth();
            // NewProgram.calc();

            // int[] arr = { 1, 2, 3, 4, 5 };
            // NewProgram.reverseOrder(arr);
            // int[] arr2 = { 2, 4, 5, 6, 8, 5, 4, 3, 2, 3, 6, 9, 8, 1 };
            // NewProgram.sortArray(arr2);
            //int[,] arr3 = { { 1, 2, 3 }, { 1, 2, 3 } };
            //NewProgram.addSquareMatrix(arr3);

            NewProgram.FindElement();

            // Console.WriteLine(NewProgram.compareString("abc", "abc"));


            Console.ReadLine();
        }
    }

    class NewProgram
    {
        // Exrecise 1
        // Swapping Variable with helping variable
        public static void swapVarialbe()
        {
            int a, b, temp;

            a = 10;
            b = 20;

            // Swpping
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Value of a: {a}\nValue of {b}");
        }

        // Exrecise 2
        // Units of Distance
        public static void findDistance()
        {
            Console.Write("Input Distance in Km's");
            int dist = Convert.ToInt32(Console.ReadLine());

            int inMeter = dist * 1000;
            double inFeet = inMeter * 3.281;
            double inInches = inFeet * 12;
            double cm = inInches * 100;

            Console.WriteLine($"Distance in Km: {dist}\nDistance in Meters: {inMeter}\nDistance in Feet: {inFeet}\nDistance in Inches: {inInches}\nDistance in cm: {cm}");
        }

        // Exercise 3
        // Calculating Percnetages
        public static void findPercent()
        {
            Console.WriteLine("Enter Your Subject Marks one by one: ");
            Console.Write("Enter First Subject Marks: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Subject Marks: ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Subject Marks: ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fourth Subject Marks: ");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fifth Subject Marks: ");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            int aggrMarks = 500;
            int obtMarks = sub1 + sub2 + sub3 + sub4 + sub5;
            double percentage = (obtMarks * 100) / aggrMarks;

            Console.WriteLine($"Your Obtained Percentage is: {percentage}%");
        }

        // Exercise 4
        // Calculating Circle Area and Circumference
        public static void findCircumference()
        {
            Console.Write("Input the Radius of Circle: ");
            double radius = Convert.ToInt32(Console.ReadLine());
            double circleArea, circleCircumference;

            circleArea = radius * radius * 3.14;
            circleCircumference = radius * 2 * 3.14;

            Console.WriteLine($"Circle Area: {circleArea}\nCricle Circumference: {circleCircumference}");
        }

        // Exercise 5
        // Profit or loss
        public static void findProfitLoss()
        {
            Console.Write("Enter the Cost Price of Item: ");
            double costPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Selling Price of Item: ");
            double sellingPrice = Convert.ToInt32(Console.ReadLine());

            double profitOrLoss = sellingPrice - costPrice;

            if(profitOrLoss > 0)
            {
                Console.WriteLine($"The profit is {profitOrLoss}");
            }else if(profitOrLoss < 0)
            {
                Console.WriteLine($"The Loss is {profitOrLoss}");
            }else if(profitOrLoss == 0)
            {
                Console.WriteLine($"No profit or Loss {profitOrLoss}");
            }
        }

        // Exercise 6
        // Temp into centigrade
        public static void tempInCentigrade()
        {
            // Taking Input
            Console.Write("Enter the Temp in Fahrenheit");
            int tempInFahrenheit = Convert.ToInt32(Console.ReadLine());

            // Converting temp in centigrade
            int tempInCentigrade = ((tempInFahrenheit - 32) * 5) / 9;
            Console.WriteLine(tempInCentigrade);
        }

        // Exercise 7
        // Swapping variable without helping variable.
        public static void swapVariable2()
        {
            int x, y;

            x = 10;
            y = 20;
            
            Console.WriteLine($"{x} {y}");
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"{x} {y}");


        }

        // Exercse 8
        // Calculate the area and perimeter of rectangle.
        public static void perimeterOfRect()
        {
            int length, breadth;

            // Taking input 
            Console.Write("Input the length : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Breadth : ");
            breadth = Convert.ToInt32(Console.ReadLine());

            int rectArea, rectPerimeter;

            rectArea = length * breadth;
            rectPerimeter = ((length * 2) + breadth * 2);

            Console.WriteLine($"Rectangle Area: {rectArea}\nRectangle Perimeter: {rectPerimeter}");
        }

        // Exercise 9
        // Finding literacy and illiteracy
        public static void litAndIllit()
        {
            const int totalPopulation = 80000;
            const double percentMen = 0.52;
            const double percentTotalLit = 0.48;
            const double percentLiterateMen = 0.35;

            double totalLiterateMen = (percentLiterateMen * totalPopulation);
            double totalMen = (percentMen * totalPopulation);
            double  illiterateMen = totalMen - totalLiterateMen;
            double totalLiteratePopulation = percentTotalLit * totalPopulation;
            double illiterateWomen = totalLiteratePopulation - illiterateMen;

            Console.WriteLine($"Illiterate Men: {illiterateMen}\nIlliterate Women: {illiterateWomen}");
        }

        // Exercise 10
        // Nomination & Denomination
        public static void nomAndDenom()
        {
            int amount;
            Console.Write("Enter Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            int hundreds = amount / 100;
            int fifties = ((amount % 100) / 50);
            int tens = (((amount % 100) % 50) / 10);
            Console.WriteLine($"Denomination in Hundreds: {hundreds}");
            Console.WriteLine($"Denomination in Fifties: {fifties}");
            Console.WriteLine($"Denomination in Tens: {tens}");
        }

        // Exercise 11
        // Write a program to find the cost price of one item.
        public static void costPriceOfOneItem()
        {
            double totalSellingPrice, totalProfit;
            Console.Write("Enter the Total Selling Price: ");
            totalSellingPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Total Profit Earned: ");
            totalProfit = Convert.ToInt32(Console.ReadLine());

            double costPrice = (totalSellingPrice - totalProfit);
            double costPricePerItem = (costPrice / 15);
            Console.WriteLine(costPricePerItem);
        }

        // Exercise 12
        // Find the Leap Year
        public static void isLeapYear()
        {
            Console.Write("Enter The Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine($"{year} is not a leap Year.");
            }
        }

        //Exercise 13
        // Finding absolute of number
        public static void findAbsolute()
        {
            Console.Write("Enter The Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 0)
            {
                Console.WriteLine($"Absolute of number is : {number}");
            }
            else
            {
                number = -number;
                Console.WriteLine($"Absolute of number is : {number}");
            }
        }

        // Exercise 14
        // Hiring Driver
        public static void insuringDriver()
        {
            // Entering Marital Status
            Console.Write("Enter the Marital Status: ");
            string maritalStatus = Console.ReadLine();
            
            

            if (maritalStatus.ToLower() == "true")
            {
                Console.WriteLine("You are insured.");
            }
            else
            {
                // Entering Gender
                Console.Write("Enter the Gender: ");
                string gender = Console.ReadLine();
                if (gender == "male")

                {
                    // Entering Age
                    Console.Write("Enter the Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 30)
                    {
                        Console.WriteLine("You are insured");
                    }
                    else
                    {
                        Console.WriteLine("Driver is not insured");
                    }
                }else if(gender == "female")
                {
                    Console.Write("Enter the Age: ");
                    int age = int.Parse(Console.ReadLine());
                    if(age >= 25)
                    {
                        Console.WriteLine("You are insured");
                    }
                    else
                    {
                        Console.WriteLine("Driver is not insured");
                    }

                }
                
            }


        }

        // Exercise 15
        // Calculation the division
        public static void calcDivision()
        {
            Console.Write("Enter the First subject marks: ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second subject marks: ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third subject marks: ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fourth subject marks: ");
            int mark4 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fifth subject marks: ");
            int mark5 = int.Parse(Console.ReadLine());

            int obtMarks = mark1 + mark2 + mark3 + mark4 + mark5;
            int totalMarks = 500;
            double percentage = (obtMarks * 100) / totalMarks;
            if (percentage >= 60)
            {
                Console.WriteLine("First Division");
            } else if (percentage >= 50 || percentage < 59)
            {
                Console.WriteLine("Second Divison");
            } else if (percentage >= 40 || percentage < 49)
            {
                Console.WriteLine("Third Division");
            } else if (percentage < 40)
            {
                Console.WriteLine("Fail");
            }
        }

        // Exercise 16
        // Checking persons health
        public static void checkHealth()
        {
            Console.Write("Enter your Health Status (poor/excelent): ");
            string health = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your Gender: ");
            string gender = Console.ReadLine(); 
            Console.Write("Enter location (city or village): ");
            string location = Console.ReadLine();

            if (health.ToLower() == "excellent" && age >= 25 || age <=35 && location.ToLower() == "city" && gender.ToLower() == "male")
            {
                Console.WriteLine("The premium is Rs. 40 per thousand and the policy amount cannot exceed Rs. 2 Lakh.");
            }else if (health.ToLower() == "excellent" && age >= 25 || age <= 35 && location.ToLower() == "city" && gender.ToLower() == "female")
            {
                Console.WriteLine("The premium is Rs. 30 per thousand and the policy amount cannot exceed Rs. 1 Lakh.");
            }else if (health.ToLower() == "poor" && age >= 25 || age <= 35 && location.ToLower() == "village" && gender.ToLower() == "male")
            {
                Console.WriteLine("The premium is Rs. 60 per thousand and the policy amount cannot exceed Rs. 10,000.");
            }
            else
            {
                Console.WriteLine("The person is not insured.");
            }
        }

        // Exercise 17
        // Displaying patten
        public static void printPattern()
        {
            int num, i, k;
            Console.Write("Enter the level: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }

        // Exrcise 18
        // Displaying patten 2
        public static void printPattern2()
        {
            int num, i, k;
            Console.Write("Enter the level: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        // Exrcise 19
        // Displaying patten 3
        public static void printPattern3()
        {
            int row, column, num;
            row = 1;
            
            num = 1;
            for (; row <= 4;)
            {
                column = 1;
                for (; column <= row;)
                {
                    Console.Write(num);
                    num++;
                    column++;
                }
                Console.WriteLine();
                row++;
            } 
        }

        // Exercise 20
        // Find the prime number is prime or not using loop
        public static void isPrime()
        {
            Console.Write("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());
            

            if (number <= 1)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Pow(number, 0.5); i++)
                {
                    if(number %i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("The number is Prime");
                }
                else
                {
                    Console.WriteLine("The number is not Prime");
                }
            }
        }

        // Exercise 21
        // Overtime Pay
        public static void overTimePay()
        {
            int employee = 1;
            int overTime = 0;
            while (employee <= 10)
            {
                Console.Write("Enter the number of hours worked by the employee: ");
                int hours = int.Parse(Console.ReadLine());
                if (hours > 40)
                {
                    overTime = hours * 200;
                }
                if (hours <= 40)
                {
                    overTime = 0;
                }
                Console.WriteLine(overTime);
                employee++;
            }
        }
        // Exercise 22
        // Foctorial number
        public static void findFactorial()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i=1; i<=number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }

        // Exercise 23
        // Name of the day
        public static void nameOfTheDay()
        {
            Console.Write("Enter The Day Number: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
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
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }

        // Exercise 24
        // Reverse the number
        public static void reversNum()
        {
            Console.Write("Enter the number to be reversed: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int reminder = 0;
            for (;number!=0;)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number /= 10;
            }
            Console.WriteLine(reverse);
        }

        // Exercise 25
        // Check the vowel 
        public static void checkVowellllll()
        {
            Console.Write("Enter a vowel alphabet: ");
            char alph = char.Parse(Console.ReadLine());

            switch (alph)
            {
                case 'a':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'e':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'i':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'o':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'u':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'A':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'E':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'I':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'O':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                case 'U':
                    Console.WriteLine($"{alph} is vowel.");
                    break;
                default:
                    Console.WriteLine($"{alph} is not vowel.");
                    break;
            }
        }

        // Exercise 26
        // Print days of the month
        public static void daysOfMonth()
        {
            Console.Write("Enter number of the month: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 2:
                    Console.WriteLine($"{number} has 28 or 29 days depending on whether it is a leap year.");
                    break;
                case 3:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 4:
                    Console.WriteLine($"{number} has 30 days.");
                    break;
                case 5:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 6:
                    Console.WriteLine($"{number} has 30 days.");
                    break;
                case 7:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 8:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 9:
                    Console.WriteLine($"{number} has 30 days.");
                    break;
                case 10:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                case 11:
                    Console.WriteLine($"{number} has 30 days.");
                    break;
                case 12:
                    Console.WriteLine($"{number} has 31 days.");
                    break;
                default:
                    Console.WriteLine($"'{number}' Invalid month.");
                    break;

            }
        }

        // Exercise 27
        // Building Calculator
        public static void calc()
        {
            Console.Write("Enter the Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Operator (+,-,*./): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Addition of {num1} and {num2} is {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"Subtraction of {num1} and {num2} is {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplication of {num1} and {num2} is {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"Divison of {num1} and {num2} is {num1 / num2}");
                    break;
            }
        }

        // Exercise 28
        // Print array in reverse order
        public static void reverseOrder(int[] arr)
        {
            int i = arr.Length - 1;
            while (i >= 0)
            {
                Console.Write(arr[i]);
                i--;
            }
        }

        // Exercise 29
        // Sorting array
        public static void sortArray(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i);
            }
        }

        // Exercise 30
        // Check matrix identity od 2d array
        public static void checkMatrixIdentity(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int col = arr.GetLength(1);
            if ( rows == col)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        // Exercise 31
        // Add square matrix
        public static void addSquareMatrix(int[,] arr) 
        {
            int rows = arr.GetLength(0);
            int col = arr.GetLength(1);
            if (rows == col)
            {
                int firstMatrix = 0;
                int secondMatrix = 0;
                int resultMatrix = 0;
                for (int i=0; i<rows; i++)
                {
                    firstMatrix += i;
                    for (int j=0; j < col; j++)
                    {
                        secondMatrix += j;
                        resultMatrix = i + j;
                    }
                }
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        // Exercise 32
        // Find the Element present in array or not
        public static bool FindElement()
        {
            int target = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i=0; i<arr.Length; i++)
            {
                if( target == arr[i])
                {
                    // Console.WriteLine($"Element {arr[i]} is present at index {i}");
                    return true;
                }
                else if (target != arr[i])
                {
                    // Console.WriteLine($"False");
                    return false;
                }
            }
        }

        // Exercise 33
        // Compare String without using string library
        public static bool compareString(string a, string b)
        {
            if(a == b)
            {
                return true;
            }
            return false;
        }
    }



}

