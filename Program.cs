using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueTry1
{
    class Program
    {
        static void Main(string[] args)
        {   // int class
            int charHealthCurrent = 25;
            int charHealthFull = 25;
            int score = 0;
            int gameOver = 0;

            // Random class
            Random random = new Random();
           
            // string class
            string drawChar = ("@");
            string[,] drawMap = new string[120, 40];

            // The actual game starts here 

            do
            {
                Console.Clear();
                int spawnPointHeight = random.Next(3, 12);
                int spawnPointWidth = random.Next(4, 12);
                int spawnPointGen_X = random.Next(0, 119 - spawnPointWidth - 1);
                int spawnPointGen_Y = random.Next(0, 29 - spawnPointHeight - 1);


                for (int y = 0; y <= spawnPointHeight; y++)
                {
                    for (int x = 0; x <= spawnPointWidth; x++)
                    {
                        if (spawnPointGen_X + spawnPointWidth >= 119)
                        {
                            int X_difference = spawnPointGen_X + spawnPointWidth - 120;
                            spawnPointGen_X = spawnPointGen_X - X_difference;
                        }
                        if (spawnPointGen_Y + spawnPointHeight >= 28)
                        {
                            int Y_difference = spawnPointGen_Y + spawnPointHeight - 29;
                            spawnPointGen_Y = spawnPointGen_Y - Y_difference;
                        }
                        if (y == 0 || y == spawnPointHeight)
                        {
                            drawMap[spawnPointGen_X + x, spawnPointGen_Y + y] = "#";
                        }
                        else
                        {
                            if (x == 0 || x == spawnPointWidth)
                            {
                                drawMap[spawnPointGen_X + x, spawnPointGen_Y + y] = "#";
                            }

                            else
                            {
                                drawMap[spawnPointGen_X + x, spawnPointGen_Y + y] = ".";
                            }
                        }
                    }
                }
                for (int y_draw = 0; y_draw <= 28; y_draw++)
                {
                    for (int x_draw = 0; x_draw <= 119; x_draw++)
                    {
                        Console.SetCursorPosition(x_draw, y_draw);
                        Console.Write(drawMap[x_draw, y_draw]);
                    }
                }
                // Console.ReadLine();
            }
            // putting in  the character


          


                
            while (gameOver == 0);

        }

    }
}
