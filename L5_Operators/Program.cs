using System;

namespace L5_Operators{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y+2;
            y += 2;

            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // mantıksal Operatörler

            bool isSuccess = true;
            bool isComplete = false;

            if( isSuccess && isComplete ){
                Console.WriteLine("Success");
            }
            else if( isSuccess || isComplete ){
                Console.WriteLine("Success or Complete");
            }
            else if ( !isSuccess && !isComplete ){
                Console.WriteLine("Fail");
            }
            else{
                Console.WriteLine("Unknown");
            }


            // ilişkisel operatörler

            int a = 5;
            int b = 3;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("**** Aritmatik Operatorler ****");
            int c = 5;
            int d = 3;
            int sonuc1 = c / d;
            Console.WriteLine(sonuc1);
            sonuc1 = c % d;
            Console.WriteLine(sonuc1);
            sonuc1 = c + d;
            Console.WriteLine(sonuc1);
            
            // % mod alma

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
            
        }
    }
}