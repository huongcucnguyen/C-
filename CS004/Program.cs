using System;

namespace Cs004
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isOnline;
            // == > < >= <= !=
            // isOnline = true;
            // isOnline = false;
            // Console.WriteLine(isOnline);

            // bool kq;
            // int a = 5;
            // int b = 6;

            // kq = a == b;

            // Console.WriteLine("a == b ==> {0}", kq);
            // Console.WriteLine($"a != b ==> {a != b}");
            // Console.WriteLine($"a > b ==> {a > b}");
            // Console.WriteLine($"a >= b ==> {a >= b}");
            // Console.WriteLine($"a < b ==> {a < b}");
            // Console.WriteLine($"a <= b ==> {a <= b}");

            bool kq;
            // && || !
            // bool a = false;
            bool a = true;
            //bool b = true;
            bool b = false;

            //kq = a && b;
            kq = !(a || b);

            // kq = ! a;

            Console.WriteLine(!kq);
        }
    }
}