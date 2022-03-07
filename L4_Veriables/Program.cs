using System;

namespace L4_Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 5;    // 2 byte
            ushort us = 5;  // 2 byte

            Int16 i16 = 5;  // 2 byte
            int i = 5;      // 4 byte
            Int32 i32 = 5;  // 4 byte
            Int64 i64 = 5;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte
            ulong ul64 = 5; // 8 byte

            float f = 5.5f; // 4 byte
            double d = 5.5; // 8 byte
            decimal de = 5.5m; // 16 byte

            char ch = 'a';   // 2 byte
            string str = "a"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 5;
            object o3 = 5.5;
            object o4 = true;

            string str1 = string.Empty;
            str1 = "Yigithan Sonmez";
            string name = "Yigithan";
            string surname = "Sonmez";
            string fullName = name + " " + surname;

            int int20 = 20;
            string yenideger = str1 + int20.ToString();

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);



            
            if( degisken == " ")
            {
                Console.WriteLine("Boş");
            }
            else
            {
                Console.WriteLine("Dolu");
            }

            Console.WriteLine(deger);
        }
    }
}
