using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Opetaja : Inimene
    {
        string aine;
        string grupp;
        public Opetaja() { }
        public Opetaja(string Grupp, string Eesnimi, string Perenimi, int Vanus) :base(Eesnimi, Perenimi, Vanus) 
        {
            grupp = Grupp;
        }

        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }

        public override void Kes_Ma_Olen()
        {
            Console.WriteLine($"Ma olen õpetaja! Minu nimi on {Eesnimi} {Perenimi}");
            Console.WriteLine($"Ma olen {Vanus} aastat vana, minu staatus on {Staatus}");
            Console.WriteLine($"Ma õpetan {grupp} rühm");
        }
    }
}
