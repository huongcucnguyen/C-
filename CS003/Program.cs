using System;

namespace CS003
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            // ()
            //int a = 5;
            // float a = 5;
            // int b = 4;

            // Console.WriteLine("a + b = {0}", a + b);
            // Console.WriteLine("a - b = {0}", a - b);
            // Console.WriteLine("a * b = {0}", a * b);
            // Console.WriteLine("a / b = {0}", a / b);
            // Console.WriteLine("a % b = {0}", a % b);

            // float kq = 6 / (3 + 3) * 2;

            // Console.WriteLine(kq);

            //Phep Gan
            // = += *= /= %=
            int x;
            x = 10;
            // x = x + 2;
            // x += 2;
            // x -=7;
            // x *= 3;
            // x /= 3;
            // x %= 3;
            // x += 1; // tuong duong x ++; hoac ++x; bien x duoc cong them 1 don vi
            // x ++;
            // ++x;

            // x --;
            // --x;

            //int z = 2 * x++; // Tuc la ca bieu thuc (2 * x++)duoc tinh xong roi moi tinh den x++ 
            // 2 * x
            // x = x + 1

            int z = 2 * ++x;//truong hop nay thi x duoc tinh truoc roi moi den phep tinh nhan
            //x = x + 1
            //2 * x
            Console.WriteLine (x);
            Console.WriteLine (z);


        }
    }
}