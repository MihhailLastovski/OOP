using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Opilane o = new Opilane("Kati", "Kask", "TARpv21");
            o.Hinne = 4;
            o.Tervist();
            Console.WriteLine();
            Opilane a = new Opilane("Kati", "Kask", 1);
            a.Hinne = 3;
            a.Tervist();
            Console.ReadKey();
            //Inimene human = new Inimene("Pariram", Emakeel.eesti,Sugu.naine);
            //human.Tervitame();
            //human.Palk = 1000;
            //double minutulu = human.Tulumaks();
            //Console.WriteLine("Minu tulumaks on: "+ minutulu);
            //Inimene[] inimesed = new Inimene[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    inimesed[i] = new Inimene();
            //    Console.WriteLine("Nimi: ");
            //    inimesed[i].Eesnimi = Console.ReadLine();
            //    Console.WriteLine("Vanus: ");
            //    inimesed[i].Vanus = int.Parse(Console.ReadLine());
            //}
            //foreach (Inimene item in inimesed)
            //{
            //    item.Tervitame();
            //}

            //Inimene mees = new Inimene();
            //mees.Eesnimi = "Mati";
            //Console.WriteLine($"Ma olen {mees.Eesnimi}. Kui vana ma olen?");
            //mees.Vanus = int.Parse(Console.ReadLine());
            //mees.Tervitame();
            //Inimene naine = new Inimene("Mischel", Emakeel.rotsi);
            //naine.Tervitame();
            //Console.ReadKey(true);
        }

    }
}
