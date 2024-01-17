using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int ora = now.Hour;
            int min = now.Minute;
            int sec = now.Second;
            int[] timp = new int[6];

            Console.WriteLine(ora + ":" + min + ":" + sec);

            if (ora<10)
            {
                timp[0] = 0;
                timp[1] = ora;
            }
            else
            {
                timp[0] = ora / 10;
                timp[1] = ora % 10;
            }
            if (min < 10)
            {
                timp[2] = 0;
                timp[3] = min;
            }
            else
            {
                timp[2] = min / 10;
                timp[3] = min % 10;
            }
            if (sec<10)
            {
                timp[4] = 0; 
                timp[5] = sec;
            }
            else
            {
                timp[4] = sec / 10;
                timp[5] = sec % 10;
            }

            int[,] ceas = new int[4, 6];
            int opt=0, c=0;

            for (c = 0; c < 6; c++)
            {

                opt = timp[c];

                switch (opt)
                {
                    case 0:
                        break;
                    case 1:

                       ceas[0, c] = 1;
                        break;
                           
                   case 2:

                        ceas[1, c] = 1;
                        break;
                            
                   case 3:

                        ceas[0, c] = 1;
                        ceas[1, c] = 1;
                        break;

                    case 4:

                        ceas[2, c] = 1;
                        break;

                  case 5:

                        ceas[0, c] = 1;
                        ceas[2, c] = 1;
                        break;

                    case 6:
                            
                      ceas[1, c] = 1;
                        ceas[2, c] = 1;
                        break;

                    case 7:

                        ceas[0, c] = 1;
                        ceas[1, c] = 1;
                        break;

                    case 8:

                        ceas[3, c] = 1;
                        break;

                    case 9:

                        ceas[0, c] = 1;
                        ceas[3, c] = 1;
                        break;

                }

            }

            int i, j;
            for(i = 0; i < 4; i++)
            {
                for(j = 0; j < 6; j++)
                {
                    Console.Write(ceas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        
    }
}
