using System;

namespace CS007_for_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for ( Khoi_tao; dieu_kien; cap_nhat)
            {
                //Cac cau lenh trong khoi
            }
            */
            //int i;

            //for (int i = 1; i <= 10; i++)
            //for (int i = 1;  ; i++)
            // for (i = 1, Console.WriteLine("Khoi tao"); i <=10 ; i++, Console.WriteLine("Cap nhat  i"))
            // {
            //     Console.WriteLine($"i = {i}");
            //     //Console.WriteLine("Hi, my name is Cuc!");
            // }
            //for (int i = 1; i <=10; i++)
            //int i = 1000;

            // while (i <= 10)
            // {
            //     Console.WriteLine($" 3 x {i} = {3 * i}");
            //     i++;
            // }
            // do
            // {
            //     Console.WriteLine($" 3 x {i} = {3 * i}");
            //     i++;
            // } while (i <= 10);

            //break; continue;

            // int i = 0;

            // while (i < 1000)
            // {
            //     Console.WriteLine(i);
            //     i++;
            //     if (i == 11)
            //         break;
            // }

            for (int i = 10; i <= 20; i++)
            {
                if (i % 2 != 0) continue;

                Console.WriteLine($"so i = {i}");
            }


        }
    }
}