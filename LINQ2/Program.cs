using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer 2. Napisati konzolnu aplikaciju za formiranje niza stringova koji se sastoje od naziva
            //voća.Primenom LINQ odredbi ispisati nazive voća koji počinju sa slovom „k“ koristeći lambda izraz.

            //1) niz stringova
            string[] voce = { "maline", "kupine", "jabuke", "kruske", "kajsije", "breskve", "banane", "pomorandze", "kesten", "nektarine" };

            var rezultat = voce.Where(n => n.StartsWith("k"));

            Console.WriteLine("Nazivi voca koju pocinju sa k su: ");
            foreach (var v in rezultat)
                Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
