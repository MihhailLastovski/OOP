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
            Inimene human = new Inimene("Pariram", Emakeel.eesti);
            Console.WriteLine(human.Emakeel);

            human.Analitic();


            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene item in inimesed)
            {
                item.Tervitame();
            }


            Inimene mees = new Inimene();
            mees.Eesnimi = "Mati";
            Console.WriteLine($"Ma olen {mees.Eesnimi}. Kui vana ma olen?");
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            Inimene naine = new Inimene("Mischel", Emakeel.rotsi);
            naine.Tervitame();
            Console.ReadKey(true);
        }

    }
}
