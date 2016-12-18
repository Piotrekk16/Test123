using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan", 34));
            osoby.Add(new Osoba("Antoni", 24));
            osoby.Add(new Osoba("Sylwia", 21));
            osoby.Add(new Osoba("Agnieszka", 21));
            osoby.Add(new Osoba("Tomasz", 52));
            var wysz = osoby.FindAll(x => x.Wiek == 21);
            foreach(var element in wysz)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();

        }
    }
}
