using System;

namespace _11_017_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Művelet: ");
            String muv = Console.ReadLine();
            int szam1 = int.Parse(muv.Split()[0]);
            int szam2 = int.Parse(muv.Split()[2]);
            Char mt = Char.Parse(muv.Split()[1]);
           
            
            switch (mt)
            {
                case '+':
                    kiir(muv);
                    break;
                case '-':
                    kiir(muv);
                    break;
                case '*':
                    kiir(muv);
                    break;
                case '/':
                    kiir(muv);
                    break;
                default:
                    Console.WriteLine("Nincs ilyen művelet.");
                    break;

            }
         
        }
        static void kiir(String i)
        {
            Console.WriteLine(i);
        }
            
            
        static int osszead(int a, int b)
        {
            return a + b;
        }
        static int kivonas(int a, int b)
        {
            return a - b;
        }
        static int szorzas(int a, int b)
        {
            return a * b;
        }
        static Double osztas(int a, int b)
        {
            return (float)a / b;
        }
    }
}
