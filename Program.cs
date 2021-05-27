using System;

namespace konsol_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("adınızı giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            string surname = Console.ReadLine();

            Console.WriteLine("mehaba" + name + " " + surname);

        }
    }
}
