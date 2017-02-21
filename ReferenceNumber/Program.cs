using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceNumber
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Viitenumeron tarkistaminen");
            Console.WriteLine("Anna viitenumero");
            string number = Console.ReadLine();
            double checknum = 0;
            double ceilingsum = 0;
            int x = 7;
            int total = 0;
            int number2 = 0;
            double sum = 0;
            int length = number.Length;
            if (length > 2 && length < 20)   //check is reference length right
            {
                for (int i = 1; i <= length; i++)
                {
                    number2 = int.Parse(number.Substring(i - 1, 1));        //Sort numbers
                    total = number2 * x;
                    sum += total;
                    if (x == 7)
                    {
                        x = 3;
                    }
                    else if (x == 3)
                    {
                        x = 1;
                    }
                    else
                    {
                        x = 7;
                    }
                }

                ceilingsum = sum / 10;                      //math for sum to checknum
                ceilingsum = Math.Ceiling(ceilingsum);
                ceilingsum = ceilingsum * 10;
                checknum = ceilingsum - sum;

                for (int j = 1; j <= length; j++)
                {
                    if (j == 5 || j == 11 || j == 17)            //do spacebar referance number
                        number = number.Insert(j, " ");
                }
                Console.WriteLine("Viitenumero = {0} tarkistusnumero = {1}", number, checknum); //result
            }
            else
            {
                Console.WriteLine("Anna oikean pituinen viitenumero");
            }
            Console.ReadKey();
        }
    }
}
