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
            public static int factorial(int n)
            {
                int fact = 0;
                if (n == 0)
                {
                    fact = 1;
                }
                else if (n == 1)
                {
                    fact = 1;
                }
                else
                {
                    fact = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        fact = fact * i;
                    }
                }

                return fact;
            }

            public static int exp(int n, int e)
            {
                int pow = 1;
                if (e == 0)
                {
                    return 1;
                }
                else if (e == 1)
                {
                    return n;
                }
                else
                {

                    while (e > 0)
                    {
                        pow = pow * n;

                        e--;
                    }
                }

                return pow;
            }
            // write your self-reflection here as a comment
            public static void printPrimeNumbers(int x, int y)
            {
                int Flag = 0;
                if (x > y)
                {
                    while (x >= y)
                    {
                        if ((x <= 0) | (y <= 0))
                        {
                            Console.WriteLine("Zero and negative integers are excluded");
                        }
                        else if ((x == 1) | (y == 1))
                        {
                            Console.WriteLine(" 1 is neither prime nor composite");
                        }

                        else if (x == 2)
                        {
                            Console.WriteLine(" " + x);
                        }
                        else if (x > 2)
                        {
                            for (int i = 2; i < x; i++)
                            {
                                if (x % i == 0)
                                {
                                    Flag = 0;
                                    break;
                                }
                                else
                                {
                                    Flag = 1;
                                }

                            }

                            if (Flag == 1)
                            {
                                Console.WriteLine(" " + x);
                            }
                        }
                        x--;
                    }

                }
                else
                {
                    while (x <= y)
                    {
                        if ((x <= 0) | (y <= 0))
                        {
                            Console.WriteLine("Zero and negative integers are excluded");
                        }
                        else if ((x == 1) | (y == 1))
                        {
                            Console.WriteLine(" 1 is neither prime nor composite");
                        }

                        else if (x == 2)
                        {
                            Console.WriteLine(" " + x);
                        }
                        else if (x > 2)
                        {
                            for (int i = 2; i < x; i++)
                            {
                                if (x % i == 0)
                                {
                                    Flag = 0;
                                    break;
                                }
                                else
                                {
                                    Flag = 1;
                                }

                            }

                            if (Flag == 1)
                            {
                                Console.WriteLine(" " + x);
                            }
                        }
                        x++;
                    }
                }
               
                Console.ReadKey();
            }

            public static double getSeriesResult(int n)
            {
                int fact = 0;
                float sum = 0;
                float factDiv = 0;
                for (int j = 1; j <= n; j++)
                {
                    if (j > 1)
                    {
                        if (j % 2 == 0)
                        {
                            fact = factorial(j);
                            factDiv = (float)fact / (j + 1);
                            sum = sum + (factDiv * -1);
                        }
                        else
                        {
                            fact = factorial(j);
                            factDiv = (float)fact / (j + 1);
                            sum = sum + (factDiv);
                        }
                    }
                    else
                    {
                        fact = factorial(j);
                        factDiv = (float)fact / (j + 1);
                        sum = sum + (factDiv);
                    }
                }
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
                Console.WriteLine(result);

                return result;
            }

            public static List<long> decimalToBinary(long n)
            {
                long remainder;
                //long quotient;
                var mylist = new List<long>();
                var mylist2 = new List<long>();
                do
                {
                    remainder = n % 2;
                    n = n / 2;
                    mylist.Add(remainder);

                    //n = n/2;
                    if (n == 0)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                } while (n > -1);



                return mylist;


            }

            public static long binaryToDecimal(long n)
            {
                List<long> binaryList = new List<long>();
                long sum = 0;

                long remainder = 0;
                while (n > 0)
                {
                    remainder = n % 10;
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
                        unique_list.Add(a[i]);
                }
               
                
                Console.WriteLine("Element   Frequency");
                int list_len = unique_list.Count;
                for (int k = 0; k <= list_len-1; k++)
                {
                    for (int j = 0; j < len ; j++)
                    {
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
                Console.WriteLine("The options are:\n" + "1. Print Prime numbers\n" + "2. Sum of the series\n" + "3. Decimal to Binary conversion\n"
                    + "4. Binary to Deciaml conversion\n" + "5. Pattern printing\n" + "6. Frequency of number");

                Console.WriteLine("Enter you option");
                string input = Console.ReadLine();
                int option = int.Parse(input);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("This program prints the prime number between the given range");
                        int a = 15, b = 5;
                        printPrimeNumbers(a, b);
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.WriteLine("This program prints the sum of the given series");
                        int n1 = 5;
                        double r1 = getSeriesResult(n1);
                        Console.WriteLine("The sum of the series is: " + r1);
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("This program converts the given decimal number to binary equivalent");
                        Console.WriteLine("Enter the decimal number");
                        var mylist1 = new List<long>();
                        long dec;
                        string div;
                        do
                        {
                            div = Console.ReadLine();
                            dec = long.Parse(div);

                            if (dec < 0)
                            {
                                Console.WriteLine("enter a non negative decimal");
                            }
                            else
                            {

                                mylist1 = decimalToBinary(dec);
                            }
                        } while (dec < 0);
                        int length = mylist1.Count;
                        Console.WriteLine("Binary conversion of the decimal number is"); 
                        for (int i = length - 1; i >= 0; i--)
                        {
                            Console.Write(mylist1[i]);
                        }
                        //Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("This program converts the given binary number to deciaml equivalent");
                        int flag = 0;
                        do
                        {
                            Console.WriteLine("Enter a binary number");
                            string binary_number = Console.ReadLine();
                            
                            int string_length = binary_number.Length;
                            int i = 0;
                            for (i = 0; i < string_length ; i++)
                            {
                                
                                if (binary_number[i].Equals('0'))
                                {
                                   
                                    flag = 1;
                                    continue;
                                }
                                else if (binary_number[i].Equals('1'))
                                {
                                    
                                    flag = 1;
                                    continue;
                                }
                                else
                                {
                                    
                                    flag = 0;
                                    break;
                                }
                            }
                            if (flag == 1)
                            {
                                long number = long.Parse(binary_number);
                                long result = binaryToDecimal(number);
                                Console.WriteLine("Decimal conversion of the binary number " + number + " is: " + result);
                                Console.ReadKey(true);
                            }
                            
                        } while (flag == 0);
                        break;
                    case 5:
                        Console.WriteLine("This program prints the pattern for the given input");
                        int n4 = 15;
                        printTriangle(n4);
                        Console.ReadKey(true);
                        break;
                    case 6:
                        Console.WriteLine("This program prints the frequency of occurence of given numbers");
                        int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2, 6 };
                        ComputeFrequency(arr);
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Please enter option between 1 and 6");
                        Console.ReadKey(true);
                        break;
                }


            }
        }
        }
    }

