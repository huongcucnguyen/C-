using System;

namespace CS006
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            // a = 40;
            // if (a == 1)
            // {
            //     Console.WriteLine("Gia tri a bang mot");
            // }
            // else if (a == 2)
            // {
            //     Console.WriteLine("Gia tri a bang hai");
            // }
            // else if (a == 3)
            // {
            //     Console.WriteLine("Gia tri a bang ba");
            // }
            // else if (a == 4)
            // {
            //     Console.WriteLine("Gia tri a bang bon");
            // }
            // else
            // {
            //     Console.WriteLine("Hay kiem tra so khac");
            // }
            // int a;
            // a = 3;

            // switch (a)
            // {
            // case 1:
            //     Console.WriteLine("Gia tri a bang mot");
            //     break;

            // case 2:
            //     Console.WriteLine("Gia tri a bang hai");
            //     break;

            // case 3:
            //     Console.WriteLine("Gia tri a bang ba");
            //     break;

            // case 4:
            //     Console.WriteLine("Gia tri a bang bon");
            //     break;

            // default:
            //     Console.WriteLine("Hay thu so khac");
            //     break;

            // case 1:
            // case 3:
            //     Console.WriteLine("Gia tri a bang mot");
            //     break;

            // case 2:
            // case 4:
            //     Console.WriteLine("Gia tri a bang hai");
            //     break;

            // default:
            //     Console.WriteLine("Hay thu so khac");
            //     break;
            // }
            int a, b;
            Console.WriteLine("Nhap so a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hay chon lenh");
            Console.WriteLine("1) Tinh tong");
            Console.WriteLine("2) Tinh hieu");
            Console.WriteLine("3) Tinh tich");
            Console.WriteLine("4) Tinh thuong");

            char c;
            L1:
            c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (c)
            {
                case '1':
                    Console.WriteLine($"Tong la: {a + b}");
                    break;
                case '2':
                    Console.WriteLine($"Hieu la: {a - b}");
                    break;
                case '3':
                    Console.WriteLine($"Tich la: {a * b}");
                    break;
                case '4':
                    Console.WriteLine($"Thuong la: {a / b}");
                    break;

                default:
                    Console.WriteLine("Hay chon lenh khac");
                    goto L1;
                    break;
            }


        }
    }
}
