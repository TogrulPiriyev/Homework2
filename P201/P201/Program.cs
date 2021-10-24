using System;

namespace P201
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmis array - deki reqemlerinin cemi 10 - dan kicik olan ededlerin sayini tapan alqoritm
            //int[] numbers = { 23, 45, 36, 73, 91, 236 };
            //int Counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int number = 0;
            //    int new_number;


            //    while (numbers[i] > 0)
            //    {
            //        new_number = numbers[i] % 10;
            //        number +=  new_number;
            //        numbers[i]/=10;
            //    }
            //    if (number < 10) 
            //    { 
            //        Counter++;
            //    }
            //}
            ////Console.WriteLine(Counter);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //2. 1-den 8000-dek ededler icerisinde cut olanlarin sayini tapan proqram
            //int Counter = 0;
            //for (int i =1; i<8000; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Counter++;
            //    }
            //}
            //Console.WriteLine(Counter);






            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //3.Verilmis ededin en yaxin asagi kokalti deyerini tapan alqoritm(kecen ders etdiyimize uygun, misalcun eded 20 - dirse 4 qaytarmalidi, 25 - dise 5 qaytarmalidi, 16 - drisa 4 ve s.)
            Console.WriteLine("Kok altisini tapmag uchun reqem yazin");
            int a = Convert.ToInt32(Console.ReadLine());
            int j = 0;

            while ((j - 1) * (j - 1) < a)
            {
                if (j * j > a)
                {
                    j--;
                    break;
                }
                else if (j*j==a)
                {
                    break;
                }
                else
                {
                    j++;
                }


            }
            Console.WriteLine(j);






        }
    }
}
