using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Inimene
    {
        string eesnimi;//поля
        int vanus;
        string staatus;
        string pol;
        double rost;
        Emakeel emakeel;
        //string answer;
        public Inimene() { }//конструктор
        public Inimene(string Eesnimi, string Pol, double Rost) 
        {
            eesnimi = Eesnimi;
            pol = Pol;
            rost = Rost;
        }
        public Inimene(string Eesnimi, Emakeel emakeel) 
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
        }
        public Emakeel Emakeel 
        {
            get { return emakeel; }
        }
        public string Eesnimi
        {
            set 
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
        }//свойства
        public int Vanus
        {
            set 
            { vanus = value;
                if (vanus<7)
                {
                    staatus = "väike laps";
                }
                else if (vanus<17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus<65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "senior";
                }
            }
            get { return vanus; }

        }
        public string Staatus 
        {
            set { staatus = value; }
            get { return staatus; }
        }
        //public string Answer 
        //{
        //    set
        //    {
        //        answer = value;
        //        if (vanus % 2 == 0)
        //        {
        //            answer = "Да";
        //        }

        //        else
        //        {
        //            answer = "Нет";
        //        }
        //    }
        //    get { return answer; }
        //}
        public string Rost 
        {
            set 
            {

            }
        }

        public void Tervitame()//метод
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0} Olen {1} aastat vana. Minu staatus on {2}", eesnimi, vanus, staatus);
        }
        public void Analitic() 
        {
            
        }
    }
}
