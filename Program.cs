using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args){
            int a = 0, b = 0, c = 1;


            /*
             a+b=c
             0+1=1
             1+0=1
             1+1=2
            2+1=3
            3+2=5
            ...
            */
            while (c < 100) {
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                b = a;
                a = c;
                c = a + b;
            }
            Console.ReadLine();
        }
    }
}
