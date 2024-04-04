using System;

namespace CS005
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                if (dieu_kien_logic)
                dong_lenh;

                if (dieu_kien_logic)
                {
                    ...
                }
                else if (dieu_kien_1)
                {
                    ...khoi lenh else
                }
                else if (dieu_kien_2)
                {
                    ...khoi lenh else
                }
                else
                {

                }
            */

            // int a;
            // Console.WriteLine("Nhap so nguyen a:");
            // a = int.Parse(Console.ReadLine());

            // //a % 2  == 0
            // if (a % 2 == 0)
            // {
            //     Console.WriteLine("Ket qua:");
            //     Console.WriteLine($"So {a} la so chan");
            // }
            // else
            // {
            //     Console.WriteLine("Ket qua:");
            //     Console.WriteLine($"So {a} la so le");
            // }

            // Console.WriteLine("The end");

            /*
            [8-10] : gioi
            [6.5-8] : kha
            [0 -5.0] : yeu
            */

            // float dtb;
            // Console.WriteLine("Hay nhap diem trung binh");
            // dtb = float.Parse(Console.ReadLine());

            // if (dtb < 5.0)
            // {
            //     Console.WriteLine("Hoc luc yeu");
            // }
            // else if (dtb < 6.5)
            // {
            //     Console.WriteLine("Hoc luc Trung binh");
            // }
            // else if (dtb < 8)
            // {
            //     Console.WriteLine("Hoc luc kha");
            // }
            // else if (dtb <= 10)
            // {
            //     Console.WriteLine("Hoc luc Gioi");
            // }
            // else
            // {
            //     Console.WriteLine("Nhap sai so diem");
            // }
            // float a, b;
            // Console.WriteLine("So a:");
            // a = float.Parse(Console.ReadLine());

            // Console.WriteLine("So b:");
            // b = float.Parse(Console.ReadLine());

            float a = 20, b = 30.5f, c = 40;
            float max;
            max = (a > b) ? (a > c) ? a : c : (b > c) ? b : c;

            Console.WriteLine(max);

            // if (a > b)
            // {
            //     //so lon a
            //     if (a > c)
            //     {
            //         max = a;
            //     }
            //     else max = c;
            // }
            // else
            // {
            //     // so lon b
            //     if (b > c)
            //         max = b;
            //     else
            //         max = c;
            // }

            //Console.WriteLine(max);

            //(dieu_kien) ? bieuthuc1 : bieuthuc2;
            //max = (a > b) ? a : b;

            // if (a > b)
            //     max = a;
            // else
            //     max = b;

            Console.WriteLine("So lon nhat la: {0}", max);
        }
    }
}