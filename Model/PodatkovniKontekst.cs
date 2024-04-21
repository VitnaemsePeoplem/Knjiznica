using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Knjiznicaaaaa.Model
{
    public class PodatkovniKontekst
    {
        //kolekcije
        public List<Ucenik> Ucenici;
        public List<Knjiga> Knjige;
        public List<Posudba> Posudbe;

        private string datUcenici = "ucenici.txt";
        public PodatkovniKontekst()
        {
            Ucenici = UcitajUcenike();
        }

        public List<Ucenik> UcitajUcenike()
        {
            List<Ucenik> rezultat = new List<Ucenik>();

            if (File.Exists(datUcenici))
            {
                using (StreamReader sr = new StreamReader(datUcenici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        //djelimo liniju i definiramo objekt učenik
                        Ucenik trenutniUcenik = new Ucenik();
                        string[] polja = linija.Split('|');
                        trenutniUcenik.OIB = polja[0];
                        trenutniUcenik.Ime = polja[1];
                        trenutniUcenik.Prezime = polja[2];
                        trenutniUcenik.Adresa = polja[3];
                        trenutniUcenik.Telefon = polja[4];
                        trenutniUcenik.Razred = int.Parse(polja[5]);

                        //Dodavanje u listu
                        rezultat.Add(trenutniUcenik);
                    }
                }
          }
            return rezultat;
        }   
        
        public void SpremiUcenike()
        {
            using (StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach(Ucenik trenutniUcenik in this.Ucenici)
                {
                    sw.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", trenutniUcenik.OIB, trenutniUcenik.Ime,
                    trenutniUcenik.Prezime, trenutniUcenik.Adresa, trenutniUcenik.Telefon,
                    trenutniUcenik.Razred);
                }
            }
        }
    }


}
