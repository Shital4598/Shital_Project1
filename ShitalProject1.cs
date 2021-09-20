using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shital_Project1
{
    class ShitalProject1
    {
      
      
            static void input(int[] a)
            {
                Console.WriteLine("The elements of Array: ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = 0;
                }
            }
            static void output(int[] a)
            {
                int c = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + "\t");
                    c++;
                    if (c % Math.Sqrt(a.Length) == 0)
                        Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                int n;
                Console.Write("ENTER THE SIZE OF THE ARRAY = ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n * n];
                //Console.Write("Enter the POSITION value = ");
                //int p = Convert.ToInt32(Console.ReadLine());
                int p = n * (n - 1);
                input(a);
                a[p] = 1;
                output(a);
                while (true)
                {
                    Console.WriteLine("Enter the choice: 1:EXIT 2: UP  8: DOWN 4: LEFT 6: RIGHT");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                        break;
                    else if (ch == 2)
                    {
                        if (p >= 0 && p <= n - 1)
                            Console.WriteLine("UP OPERATION CANNOT BE PERFORMED!!!");
                        else
                        {
                            a[p] = 0;
                            p = p - n;
                            a[p] = 1;
                            output(a);
                        }
                    }
                    else if (ch == 4)
                    {
                        int flag = 0;
                        for (int i = 0; i < n; i++)
                        {
                            if (p == n * i)
                            {
                                Console.WriteLine("LEFT OPERATION CANNOT BE PERFORMED");
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                        {
                            a[p] = 0;
                            p = p - 1;
                            a[p] = 1;
                            output(a);
                        }
                    }
                    else if (ch == 6)
                    {
                        int flag = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            if (p == (n * i) - 1)
                            {
                                Console.WriteLine("RIGHT OPERATION CANNOT BE PERFORMED");
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                        {
                            a[p] = 0;
                            p = p + 1;
                            a[p] = 1;
                            output(a);
                        }
                    }

                    else if (ch == 8)
                    {
                        if (p >= n * (n - 1) && p < n * n)
                            Console.WriteLine("DOWN OPERATION CANNOT BE PERFORMED!!!");
                        else
                        {
                            a[p] = 0;
                            p = p + n;
                            a[p] = 1;
                            output(a);
                        }
                    }
                    else
                        Console.WriteLine("ENTER THE CORRECT CHOICE!!!");

                }
            }

        }
    }

