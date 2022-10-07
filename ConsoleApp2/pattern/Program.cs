using System;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Solve the following patterns\nans : ");

            int row, column, num = 1, a;
            char ch;

            do
            {
                Console.Write("Enter any case number  :  ");
                ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                        for (row = 1; row <= 4; row++)
                        {
                            for (column = 1; column <= row; column++)
                            {
                                a = num++;
                                Console.Write(" {0} ", a);

                            }
                            Console.Write(" \n");
                        }
                        break;
                    case 'b':

                        for (row = 0; row < 5; row++)
                        {
                            for (column = 0; column <= row; column++)
                            {
                                if (row % 2 == 0)
                                {
                                    Console.Write(" * ");
                                }
                                else
                                {
                                    Console.Write(" # ");
                                }
                            }
                            Console.Write(" \n");
                        }
                        break;
                    case 'c':

                        for (row = 0; row < 5; row++)
                        {
                            for (column = 0; column <= row; column++)
                            {
                                if (column % 2 == 0)
                                {
                                    Console.Write(" * ");
                                }
                                else
                                {
                                    Console.Write(" # ");
                                }
                            }
                            Console.Write(" \n");
                        }
                        break;

                    case 'd':
                        for (row = 0; row < 5; row++)
                        {
                            for (column = 0; column <= row; column++)
                            {
                                Console.Write(" * ");

                            }
                            Console.Write(" \n");
                        }
                        break;
                    case 'e':
                        for (row = 1; row <= 5; row++)

                        {
                            for (column = 1; column <= row; column++)
                            {
                                Console.Write(row);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 'f':
                        for (row = 0; row <= 5; row++)
                        {
                            for (column = 1; column <= row; column++)
                            {
                                Console.Write(" {0} ", column);
                            }
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Not found entered case........");
                        break;
                }
                Console.Write("do you want to continue y/n :  ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
            Console.Read();
        }
    }
}
