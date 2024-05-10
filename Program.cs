using System;

namespace ModulOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Korisnik unosi dva broja koja određuju dimenzije dvodimenzionalnog polja u kojem se ispisuju brojevi
             ciklički prema sredini počevši od određenog kuta.
            */
            Console.WriteLine("Geeks Incorporated ® ™©\n\nMolimo unesite dva broja koja određuju visinu i širinu polja.");
            Console.Write("Širina polja:");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Visina polja:");
            int y = Int32.Parse(Console.ReadLine());
            int counter = 0;
            int ix = 0, iy = 0;
            int[,] poljeGeek = new int[x, y];

            DoljeLijevo(x, y, poljeGeek, counter, ix, iy);

            IspisiTablu(x, y, poljeGeek);

            Console.ReadLine();
        }
        static void IspisiTablu(int x, int y, int[,] poljeGeek)
        {
            for (int ix = 0; ix < x; ix++)
            {
                Console.WriteLine(" ");
                for (int iy = 0; iy < y; iy++)
                {
                    Console.Write("[{0}]", poljeGeek[ix, iy]);
                }
            }
        }
        static void GoreLijevo(int x, int y, int[,] poljeGeek, int counter, int ix, int iy)
        {
            x--;
            y--;
            int listic = 0;
            while (counter <= ((x + 1) * (y + 1)))
            {
                //STEP 1 - Piši desno
                for (; iy < (y - listic); iy++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                //STEP 2 - Piši dolje
                for (; ix < (x - listic); ix++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                //STEP 3 - Piši lijevo
                for (; iy >= listic; iy--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                iy++;
                ix--;
                listic++;
                //STEP 4 - Piši gore
                for (; ix >= listic; ix--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                ix++;
                iy++;
            }
        }

        static void GoreDesno(int x, int y, int[,] poljeGeek, int counter, int ix, int iy)
        {
            x--;
            y--;
            int listic = 0;
            iy = y;
            while (counter <= ((x + 1) * (y + 1)))
            {
                //STEP 1 - Piši dolje
                for (; ix < (x - listic); ix++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                //STEP 2 - Piši lijevo
                for (; iy >= listic; iy--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                iy++;
                ix--;
                //STEP 3 - Piši gore
                for (; ix >= listic; ix--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                ix++;
                iy++;
                listic++;
                //STEP 4 - Piši desno
                for (; iy < (y - listic); iy++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
            }
        }

        static void DoljeDesno(int x, int y, int[,] poljeGeek, int counter, int ix, int iy)
        {
            x--;
            y--;
            int listic = 0;
            iy = y;
            ix = x;
            while (counter <= ((x + 1) * (y + 1)))
            {
                //STEP 1 - Piši lijevo
                for (; iy >= listic; iy--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                iy++;
                ix--;

                //STEP 2 - Piši gore
                for (; ix >= listic; ix--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                ix++;
                iy++;

                //STEP 3 - Piši desno
                for (; iy < (y - listic); iy++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                listic++;

                //STEP 4 - Piši dolje
                for (; ix < (x - listic); ix++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
            }
        }
        static void DoljeLijevo(int x, int y, int[,] poljeGeek, int counter, int ix, int iy)
        {
            x--;
            y--;
            int listic = 0;
            ix = x;
            while (counter <= ((x + 1) * (y + 1)))
            {
                //STEP 1 - Piši gore
                for (; ix >= listic; ix--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                ix++;
                iy++;

                //STEP 2 - Piši desno
                for (; iy < (y - listic); iy++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }

                //STEP 3 - Piši dolje
                for (; ix < (x - listic); ix++)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                listic++;
                //STEP 4 - Piši lijevo
                for (; iy >= listic; iy--)
                {
                    counter++;
                    if (counter > ((x + 1) * (y + 1)))
                    {
                        break;
                    }
                    poljeGeek[ix, iy] = counter;
                }
                iy++;
                ix--;
            }
        }
    }
}
