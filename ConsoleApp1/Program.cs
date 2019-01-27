using System;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    namespace Assignment1_S19
    {
        class Program
        {
            // To compute the factorial
            public static int factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                return fact;
            }
            //To compute the power of given numbers
            public static int exp(int n, int e)
            {
                int pow = 1;
                while (e > 0)
                {
                    pow = pow * n;
                    e--;
                }

                return pow;
            }

            public static bool isPrime(int n)
            {
                for (int i = 2; i < n; i++)
                {
                    //Any number divisible by number other than 1 and itself is not a prime number
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            
            public static void printPrimeNumbers(int x, int y)
            {
                //For example if x=15 and y=5; below code will execute
                if (x > y)
                {
                    while (x >= y)
                    {
                        if(isPrime(x))
                        {
                            Console.WriteLine(x);
                        }    
                        x--;
                    }
                }
                //For example if x=5 and y=15; below code will execute
                else
                {
                    while (x <= y)
                    {
                        if(isPrime(x))
                        {
                            Console.WriteLine(x);
                        }
                        x++;
                    }
                }
            }

            public static double getSeriesResult(int n)
            {
                int fact = 0;
                float sum = 0;
                float factDiv = 0;
                for (int j = 1; j <= n; j++)
                {
                        //to find if number is even
                        if (j % 2 == 0)
                        {
                            fact = factorial(j);
                            factDiv = (float)fact / (j + 1);
                        //for even numbers, the sign should be negative. Hence multiplied by -1
                            sum = sum + (factDiv * -1);
                        }
                        else
                        {
                            fact = factorial(j);
                            factDiv = (float)fact / (j + 1);
                            sum = sum + (factDiv);
                        }
                    
                }
                //rounding off to three decimal places without using math.round()
                string input_decimal_number = sum.ToString();
                var values = input_decimal_number.ToString(CultureInfo.InvariantCulture).Split('.');
                int firstValue = int.Parse(values[0]);
                int secondValue = int.Parse(values[1]);
                string decimal_places = secondValue.ToString();
                string finalValue = firstValue.ToString();
                finalValue = finalValue + ".";
                for (int i=0;i<3;i++)
                {
                    finalValue = finalValue + decimal_places[i];
                }
                double result = double.Parse(finalValue);
                return result;
            }

            public static long decimalToBinary(long n)
            {
                long remainder;
                long sum = 0;
                var mylist = new List<long>();

                while (n != 0)
                {
                    remainder = n % 2;
                    n = n / 2;
                    //adding the values to a list
                    mylist.Add(remainder);

                }
                
                foreach(long i in mylist)
                {
                    sum = sum*10 + i;
                }

                return sum;
                
            }

            public static long binaryToDecimal(long n)
            {
                List<long> binaryList = new List<long>();
                long sum = 0;

                long remainder = 0;
                while (n > 0)
                {
                    remainder = n % 10;
                    if(remainder > 1)
                    {
                        //to check if the given number is binary; if not -1 is returned
                        return -1;
                    }
                    n = n / 10;
                    binaryList.Add(remainder);
                }
                long listLength = binaryList.Count;

                for (int i = 0; i <= listLength - 1; i++)
                {

                    sum = sum + (binaryList[i] * exp(2, i));

                }
                return sum;
            }

            public static void printTriangle(int n)
            {

                int sum = 1;
                int temp = 1;
                if (n >= 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = i; j <= n - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        while (sum > 0)
                        {
                            Console.Write("*");
                            sum--;
                        }
                        temp = temp + 2;
                        sum = temp;
                        Console.WriteLine();

                    }
                }
                else
                {
                    Console.WriteLine();
                }


            }

            public static void ComputeFrequency(int[] a)
            {
                List<int> unique_list = new List<int>();
                
                int len = a.Length;
                
                int i = 0;
                int counter = 0;
                for (i = 0; i < len ; i++)
                {
                    if (unique_list.Contains(a[i]))
                    {
                        continue;
                    }
                    else
                        //adding unique values to the list
                        unique_list.Add(a[i]);
                }
               
                
                Console.WriteLine("Element   Frequency");
                int list_len = unique_list.Count;
                for (int k = 0; k <= list_len-1; k++)
                {
                    for (int j = 0; j < len ; j++)
                    {
                        //comparing unique values between list and given array
                        if (unique_list[k] == a[j])
                        {
                            counter++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine(unique_list[k] + "           " + counter);
                    counter = 0;
                }
            }


            public static void Main()
            {
                Console.WriteLine("This program prints the prime number between the given range");
                int a = 15, b = 5;
                if(a>0 || b>0) {
                    Console.WriteLine("The prime numbers between " + a + " and " + b + " are:");
                    printPrimeNumbers(a, b);
                }
                Console.WriteLine();
                
                Console.WriteLine("This program prints the sum of the given series");
                int n1 = 5;
                double r1 = getSeriesResult(n1);
                Console.WriteLine("The sum of the series is: " + r1);
                Console.WriteLine();

                Console.WriteLine("This program converts the given decimal number to binary equivalent");
                long dec = 15;
                if (dec < 0)
                {
                    Console.WriteLine("enter a non negative decimal");
                }
                else
                {
                    long r2 = decimalToBinary(dec);
                    Console.WriteLine("Binary conversion of the decimal number "+dec+" is: "+r2);
                }
                Console.WriteLine();

                Console.WriteLine("This program converts the given binary number to decimal equivalent");
                long number = 1101;
                if (number >= 0)
                {
                    long result = binaryToDecimal(number);
                    if (result == -1)
                    {
                        Console.WriteLine("Not a valid number");
                    }
                    else
                    {
                        Console.WriteLine("Decimal conversion of the binary number " + number + " is: " + result);
                    }
                }
                Console.WriteLine();

                int n4 = 5;
                Console.WriteLine("This program prints the pattern for " + n4 + " number");
                printTriangle(n4);
                Console.WriteLine();

                Console.WriteLine("This program prints the frequency of occurence of given numbers");
                int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2};
                ComputeFrequency(arr);
                Console.WriteLine();

                Console.ReadLine();

                /*SELF REFLECTION
                 * This program series helped me think logically and approach the problem in a programatic way.
                 * It took around 12 hrs to complete the assignment. 
                 * This helped me learn the basics of programming and helped me understand the usage of modules in 
                 * a better way . 
                 * */

            }
        }
    }
}

