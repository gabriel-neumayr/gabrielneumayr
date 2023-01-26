using System;

namespace schach
{
    internal class Program
    {






        static void Main(string[] args)
        {
            Console.WriteLine("Schach pferd");

            bool[,] feld = new bool[8, 8];




            for (int i = 0; i < feld.GetLength(0); i++)
            {
                for (int j = 0; j < feld.GetLength(1); j++)
                {
                    feld[i, j] = false;

                    //Console.Write(feld[i, j] + " ");

                }

            }
            int x = 7;
            int y = 6;
            bool running = true;
            while (running)
            {

                int ii = 0;
 

                

                feld[x, y] = true;
                for (int i = 0; i < feld.GetLength(0); i++)
                {
                    for (int j = 0; j < feld.GetLength(1); j++)
                    {


                        if (feld[i, j] == false)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }
                        //Console.Write(feld[i, j] + " ");


                    }
                    Console.WriteLine();

                }

                feld[x, y] = false;
                int ouldx = x;
                int ouldy = y;
                Console.WriteLine("Momentan X: "+ouldy);
                Console.WriteLine("X:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Momentan Y: "+ouldx);
                Console.WriteLine("Y:");
                x = Convert.ToInt32(Console.ReadLine());

                int diffX = Math.Abs(ouldx - x);

                int diffY = Math.Abs(ouldy - y);

                if ((diffX == 2 && diffY == 1) || (diffX == 1 && diffY == 2))
                {
                    feld[x, y] = true;
                }


       
                else
                {
                    x = ouldx;
                    y = ouldy;
                    feld[x, y] = true;
                    Console.WriteLine("Fehlerhafte einfabe");

                }


                ii++;

            }




        }


    }
}

