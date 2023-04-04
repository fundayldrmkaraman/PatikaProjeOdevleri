using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            Console.WriteLine(deger);

            byte b = 5; //1 byte
            sbyte d = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint u = 2; //4 byte
            long l = 2; //8 byte
            ulong ul = 2; //8 byte

            float f = 2; //4 byte
            decimal de = 2; //16 byte

            char ch = '2'; //2 byte
            string str = "Funda"; //sınırsız
            bool b1 = true;
            bool b2 = false;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;


        }
    }
}
