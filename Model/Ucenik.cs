using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knjiznicaaaaa.Model
{
    public class Ucenik: IComparable
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int Razred { get; set; }

        public override string ToString()
        {
            return this.Prezime + " " + this.Ime + " " + this.Razred;
        }
        public int CompareTo(object obj)
        {
            //Usporedba prema prezimenu
            int rez = this.Prezime.CompareTo(((Ucenik)obj).Prezime);

            //U slučaju istog prezime uspoređujemo prema imenu
            if (rez==0)
            {
                rez = this.Ime.CompareTo(((Ucenik)obj).Ime);
            }

            return rez;
        }
    }
}
