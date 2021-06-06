using System;
using extension_method.Extensions;

namespace extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            StartScreen();

        }
        static void StartScreen()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Sezar Şifreleme");
            Console.WriteLine("(2) Sezar Şifre Çözücü");
           


            int process = Convert.ToInt16(Console.ReadLine());
            Router(process);

        }
    

        static void Router(int process) 
        {
            switch (process)
            {
                case 1:
                    get_text_encode();

                     break;
                case 2:
                    get_text_decode();
                    break; 
                
            }
        }
        public static void get_text_encode()
        {
            Console.WriteLine("Şifrelenecek metni giriniz:");
            string str = Console.ReadLine();
            str = str.ToLower();
            Console.WriteLine("Şifreleme adımını giriniz :");
            int key = Convert.ToInt16(Console.ReadLine());

            //extension method olarak yazdığım şifrelemeye ulaşılır. Böylece klavyeden girilen yazı şifrelenebilir.
            string result=str.encryption(key);

            Console.WriteLine("Şifreli Hali:\n" + result);
            Console.ReadLine();
            StartScreen();


        }
        public static void get_text_decode()
        {
            Console.WriteLine("Şifresi çözülecek metni giriniz:");
            string input = Console.ReadLine();
            input= input.ToLower();
            Console.WriteLine("Şifre çözücü adımını giriniz :");
            int number = Convert.ToInt16(Console.ReadLine());

            //extension method olarak yazdığım şifre çözücüye ulaşılır.Böylece klavyeden girilen yazının şifresi çözülebilir.
            string result = input.decoder(number);


            Console.WriteLine("Şifresi çözülmüş hali:\n" + result);
            Console.ReadLine();
            StartScreen();



        }
    }
}
