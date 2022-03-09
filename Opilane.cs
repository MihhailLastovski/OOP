using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        int kurs;
        bool toetus;
        public Opilane(string Eesnimi, string Perenimi, int Kurs):base(Eesnimi,Perenimi)
        {
            kurs = Kurs;
        }
        public Opilane() { }
        public Opilane(string Eesnimi,string Perenimi, string Ruhm):base(Eesnimi,Perenimi)
        {
            ruhm = Ruhm;
        }
        public string Ruhm 
        {
            get { return ruhm; }
            set { ruhm = value; }
        }
        public int Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public double Hinne 
        {
            set 
            { if (value>1 && value<5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus 
        {
            get 
            { 
                if (hinne >= 3) 
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            
            }
        }
        public void Tervist() 
        {
            if (Kurs==0)
            {
                if (Toetus == true)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Teie keskmine hinne => {hinne}, sa saad toestus.");
                }
                else if (Toetus == false && hinne >= 1)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Teie keskmine hinne => {hinne}, sa ei saa toetus.");
                }
                else if (Toetus == false && hinne < 1)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Andmed hinnetest puuduvad.");
                }
            }
            else if (Kurs>=1)
            {
                if (Toetus == true)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Sa oled {kurs}. kursusel. Teie keskmine hinne => {hinne}, sa saad toestus.");
                }
                else if (Toetus == false && hinne >= 1)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Sa oled {kurs}. kursusel. Teie keskmine hinne => {hinne}, sa ei saa toetus.");
                }
                else if (Toetus == false && hinne < 1)
                {
                    Console.WriteLine($"Tere, {Eesnimi} {Perenimi}! Sa oled {kurs}. kursusel. Andmed hinnetest puuduvad.");
                }
            }

            
        }
        public override void Kes_Ma_Olen()
        {

            Console.WriteLine("Ma olen õpilane!");
        }
    }
}
