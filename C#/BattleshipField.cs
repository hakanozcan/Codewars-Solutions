//3 kyu
//https://www.codewars.com/kata/52bb6539a4cf1b12d90005b7
using System.Collections.Generic;
using System;
public class BattleshipField
{
    public static bool ValidateBattlefield(int[,] field) 
        {
            var result = true;      //return result bool
            var battleships = 0;    //1 battleship (size of 4 cells)
            var cruisers = 0;       //2 cruisers (size 3)
            var destroyers = 0;     //3 destroyers (size 2)
            var submarines = 0;     //4 submarines (size 1)
            var maxX = field.GetLength(1);
            var maxY = field.GetLength(0);

            for (var y = 0; y < maxY; y++)
            {

                for (var x = 0; x < maxX; x++)
                {
                    var sizeUnknownShip = 0;

                    if (x + 1 < maxX && y + 1 < maxY)
                    {
                        var p0 = field[y, x];
                        var p1 = field[y + 1, x + 1];

                        if (field[y, x] != 0 && field[y + 1, x + 1] != 0) //Ship contacted in corner
                        {
                            result = false;
                            //Console.WriteLine($"Ship contacted in corner");
                        }
                    }

                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        var p0 = field[y, x];
                        var p1 = field[y - 1, x - 1];

                        if (field[y, x] != 0 && field[y + 1, x - 1] != 0) //Ship contacted in corner
                        {
                            result = false;
                            //Console.WriteLine($"Ship contacted in corner");
                        }
                    }

                    if (field[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (x + 1 < maxX && field[y, x + 1] == 1)
                        {
                            for (var xp = 0; xp < maxX - x; xp++)
                            {
                                if (x + xp < maxX && field[y, x + xp] == 1)
                                {
                                    field[y, x + xp] = 2;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    sizeUnknownShip++;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }


                        if (y + 1 < maxY && field[y + 1, x] == 1)
                        {
                            for (var yp = 0; yp < maxY - y; yp++)
                            {
                                if (y + yp < maxY && field[y + yp, x] == 1)
                                {
                                    field[y + yp, x] = 2;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    sizeUnknownShip++;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }


                        if (field[y, x] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            field[y, x] = 2;
                            sizeUnknownShip++;
                        }

                    }
                    else
                    {
                        if (field[y, x] == 0) Console.ForegroundColor = ConsoleColor.Blue;
                    }


                    if (x == maxX - 1)
                    {
                        Console.Write($"{field[y, x]}");
                        Console.WriteLine(" },");
                    }
                    else
                    {
                        if (x == 0) Console.Write("{ ");
                        Console.Write($"{field[y, x]}, ");
                    }

                    Console.ResetColor();

                    switch (sizeUnknownShip)
                    {
                        case 0: break;
                        case 1:
                            submarines++;
                            break;
                        case 2:
                            destroyers++;
                            break;
                        case 3:
                            cruisers++;
                            break;
                        case 4:
                            battleships++;
                            break;
                        default:
                            Console.WriteLine($"sizeUnknownShip: {sizeUnknownShip}");
                            result = false;
                            break;
                    }

                }

                Console.ResetColor();
            }

            Console.WriteLine();

            if (submarines != 4)
            {
                result = false;
                Console.WriteLine("submarines != 4");
            }
            if (destroyers != 3)
            {
                result = false;
                Console.WriteLine("destroyers != 3");
            }
            if (cruisers != 2)
            {
                result = false;
                Console.WriteLine("cruisers != 2");
            }
            if (battleships != 1)
            {
                result = false;
                Console.WriteLine("battleships != 1");
            }

            Console.WriteLine();
            Console.WriteLine($"maxX: {maxX}");
            Console.WriteLine($"maxY: {maxY}");
            Console.WriteLine($"submarines: {submarines}");
            Console.WriteLine($"destroyers: {destroyers}");
            Console.WriteLine($"cruisers: {cruisers}");
            Console.WriteLine($"battleships: {battleships}");
            Console.WriteLine($"result: {result}");
            Console.WriteLine();

            return result;
        }

    }