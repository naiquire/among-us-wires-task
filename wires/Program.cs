using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 9; i <= 11; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 17; i <= 19; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int i = 25; i <= 27; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("      ");
            }
            int[] wireCheck = new int[] { 0, 0, 0, 0 };
            int redWire = random.Next(0, 4);
            while (wireCheck[redWire] == 1) { redWire = random.Next(0, 4); }
            wireCheck[redWire] = 1;
            int yellowWire = random.Next(0, 4);
            while (wireCheck[yellowWire] == 1) { yellowWire = random.Next(0, 4); }
            wireCheck[yellowWire] = 1;
            int blueWire = random.Next(0, 4);
            while (wireCheck[blueWire] == 1) { blueWire = random.Next(0, 4); }
            wireCheck[blueWire] = 1;
            int pinkWire = random.Next(0, 4);
            while (wireCheck[pinkWire] == 1) { pinkWire = random.Next(0, 4); }
            wireCheck[pinkWire] = 1;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(70, 8 * redWire + i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(70, 8 * yellowWire + i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(70, 8 * blueWire + i);
                Console.Write("      ");
            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(70, 8 * pinkWire + i);
                Console.Write("      ");
            }
            int redX = 69;
            int redY = 8 * redWire + 2;
            double redGradient = (-Convert.ToDouble(redY) - -2) / (Convert.ToDouble(redX) - 7);
            int yellowX = 69;
            int yellowY = 8 * yellowWire + 2;
            double yellowGradient = (-Convert.ToDouble(yellowY) - -10) / (Convert.ToDouble(yellowX) - 7);
            int blueX = 69;
            int blueY = 8 * blueWire + 2;
            double blueGradient = (-Convert.ToDouble(blueY) - -18) / (Convert.ToDouble(blueX) - 7);
            int pinkX = 69;
            int pinkY = 8 * pinkWire + 2;
            double pinkGradient = (-Convert.ToDouble(pinkY) - -2) / (Convert.ToDouble(pinkX) - 7);
            ConsoleKeyInfo cki;
            int xCoord = 7; int yCoord = 2;
            do
            {
                bool run = false;
                Console.SetCursorPosition(xCoord, yCoord);
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (yCoord != 1 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord - 1); yCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (xCoord > 8) { Console.SetCursorPosition(xCoord - 1, yCoord); xCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (yCoord != 27 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord + 1); yCoord++; run = true; }
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (xCoord != 69) { Console.SetCursorPosition(xCoord + 1, yCoord); xCoord++; run = true; }
                }
                if (run)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int i = 0; i <= 27; i++)
                    {
                        Console.SetCursorPosition(7, i);
                        Console.WriteLine("                                                               ");
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(xCoord, yCoord);
                    double xgradient = (-Convert.ToDouble(yCoord) - -2) / (Convert.ToDouble(xCoord) - 7);
                    for (int i = 7; i <= xCoord; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(xgradient * (i - 7) - 2)));
                        Console.WriteLine(" ");
                    }
                    if (Convert.ToDouble(yCoord) == 2)
                    {
                        for (int i = 7; i <= xCoord; i++)
                        {
                            Console.SetCursorPosition(i, 2);
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        double ygradient = (Convert.ToDouble(xCoord) - 7) / (Convert.ToDouble(yCoord) - 2);
                        if (yCoord >= 2)
                        {
                            for (int i = 2; i <= yCoord; i++)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 2) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            for (int i = 2; i >= yCoord; i--)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 2) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                    }
                }
            } while (!(xCoord == 69 && yCoord == 8 * redWire + 2));
            xCoord = 7; yCoord = 10;
            do
            {
                bool run = false;
                Console.SetCursorPosition(xCoord, yCoord);
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (yCoord != 1 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord - 1); yCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (xCoord > 8) { Console.SetCursorPosition(xCoord - 1, yCoord); xCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (yCoord != 27 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord + 1); yCoord++; run = true; }
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (xCoord != 69) { Console.SetCursorPosition(xCoord + 1, yCoord); xCoord++; run = true; }
                }
                if (run)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int i = 0; i <= 27; i++)
                    {
                        Console.SetCursorPosition(7, i);
                        Console.WriteLine("                                                               ");
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(redGradient * (i - 7) - 2)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(xCoord, yCoord);
                    double xgradient = (-Convert.ToDouble(yCoord) - -10) / (Convert.ToDouble(xCoord) - 7);
                    for (int i = 7; i <= xCoord; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(xgradient * (i - 7) - 10)));
                        Console.WriteLine(" ");
                    }
                    if (Convert.ToDouble(yCoord) == 10)
                    {
                        for (int i = 7; i <= xCoord; i++)
                        {
                            Console.SetCursorPosition(i, 10);
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        double ygradient = (Convert.ToDouble(xCoord) - 7) / (Convert.ToDouble(yCoord) - 10);
                        if (yCoord >= 10)
                        {
                            for (int i = 10; i <= yCoord; i++)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 10) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            for (int i = 10; i >= yCoord; i--)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 10) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                    }
                }
            } while (!(xCoord == 69 && yCoord == 8 * yellowWire + 2));
            xCoord = 7; yCoord = 18;
            do
            {
                bool run = false;
                Console.SetCursorPosition(xCoord, yCoord);
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (yCoord != 1 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord - 1); yCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (xCoord > 8) { Console.SetCursorPosition(xCoord - 1, yCoord); xCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (yCoord != 27 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord + 1); yCoord++; run = true; }
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (xCoord != 69) { Console.SetCursorPosition(xCoord + 1, yCoord); xCoord++; run = true; }
                }
                if (run)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int i = 0; i <= 27; i++)
                    {
                        Console.SetCursorPosition(7, i);
                        Console.WriteLine("                                                               ");
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(redGradient * (i - 7) - 2)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(yellowGradient * (i - 7) - 10)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(xCoord, yCoord);
                    double xgradient = (-Convert.ToDouble(yCoord) - -18) / (Convert.ToDouble(xCoord) - 7);
                    for (int i = 7; i <= xCoord; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(xgradient * (i - 7) - 18)));
                        Console.WriteLine(" ");
                    }
                    if (Convert.ToDouble(yCoord) == 18)
                    {
                        for (int i = 7; i <= xCoord; i++)
                        {
                            Console.SetCursorPosition(i, 18);
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        double ygradient = (Convert.ToDouble(xCoord) - 7) / (Convert.ToDouble(yCoord) - 18);
                        if (yCoord >= 18)
                        {
                            for (int i = 18; i <= yCoord; i++)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 18) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            for (int i = 18; i >= yCoord; i--)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 18) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                    }
                }
            } while (!(xCoord == 69 && yCoord == 8 * blueWire + 2));
            xCoord = 7; yCoord = 26;
            do
            {
                bool run = false;
                Console.SetCursorPosition(xCoord, yCoord);
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (yCoord != 1 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord - 1); yCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (xCoord > 8) { Console.SetCursorPosition(xCoord - 1, yCoord); xCoord--; run = true; }
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (yCoord != 27 && xCoord > 7) { Console.SetCursorPosition(xCoord, yCoord + 1); yCoord++; run = true; }
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (xCoord != 69) { Console.SetCursorPosition(xCoord + 1, yCoord); xCoord++; run = true; }
                }
                if (run)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int i = 0; i <= 27; i++)
                    {
                        Console.SetCursorPosition(7, i);
                        Console.WriteLine("                                                               ");
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(redGradient * (i - 7) - 2)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(yellowGradient * (i - 7) - 10)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Blue;
                    for (int i = 7; i <= 69; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(blueGradient * (i - 7) - 18)));
                        Console.WriteLine(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(xCoord, yCoord);
                    double xgradient = (-Convert.ToDouble(yCoord) - -26) / (Convert.ToDouble(xCoord) - 7);
                    for (int i = 7; i <= xCoord; i++)
                    {
                        Console.SetCursorPosition(i, Math.Abs((int)(xgradient * (i - 7) - 26)));
                        Console.WriteLine(" ");
                    }
                    if (Convert.ToDouble(yCoord) == 26)
                    {
                        for (int i = 7; i <= xCoord; i++)
                        {
                            Console.SetCursorPosition(i, 26);
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        double ygradient = (Convert.ToDouble(xCoord) - 7) / (Convert.ToDouble(yCoord) - 26);
                        if (yCoord >= 26)
                        {
                            for (int i = 26; i <= yCoord; i++)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 26) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            for (int i = 26; i >= yCoord; i--)
                            {
                                Console.SetCursorPosition((int)(ygradient * (i - 26) + 7), i);
                                Console.WriteLine(" ");
                            }
                        }
                    }
                }
            } while (!(xCoord == 69 && yCoord == 8 * pinkWire + 2));
            Console.ReadKey();
        }
    }
}
