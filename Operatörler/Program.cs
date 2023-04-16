using System;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSucces = true;
            bool isCompleted = false;

            if (isSucces && isCompleted)
                Console.WriteLine("Perfesct!");

            if (isSucces || isCompleted)
                Console.WriteLine("Great!");

            if (isSucces && isCompleted)
                Console.WriteLine("Fine!");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
        }
    }
}
