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
        private string datKnjige = "knjige.txt";
        private string datPosudbe = "posudbe.txt";
        public PodatkovniKontekst()
        {
            Ucenici = UcitajUcenike();
            Knjige = UcitajKnjige();
        }

        public void DodajPosudbu(Posudba posudba)
        {
            this.Posudbe.Add(posudba);
            SpremiPosudbe();
        }

        public void BrisiPosudbu(Posudba posudba)
        {
            this.Posudbe.Remove(posudba);
            SpremiPosudbe();
        }

        public void DodajKnjigu(Knjiga knjiga)
        {
            this.Knjige.Add(knjiga);
            SpremiKnjige();
        }

        public void BrisiKnjigu(Knjiga knjiga)
        {
            this.Knjige.Remove(knjiga);
            SpremiKnjige();
        }

        public void DodajUcenika(Ucenik ucenik)
        {
            this.Ucenici.Add(ucenik);
            SpremiUcenike();
        }

        public void BrisiUcenika(Ucenik ucenik)
        {
            this.Ucenici.Remove(ucenik);
            SpremiUcenike();
        }

        public List<Knjiga> UcitajKnjige()
        {
            List<Knjiga> rezultat = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        //djelimo liniju i definiramo objekt knjiga
                        Knjiga trenutnaKnjiga = new Knjiga();
                        string[] polja = linija.Split('|');
                        trenutnaKnjiga.ISBN = polja[0];
                        trenutnaKnjiga.Autor = polja[1];
                        trenutnaKnjiga.Naslov = polja[2];
                        trenutnaKnjiga.GodinaIzdanja = int.Parse(polja[3]); 
                        trenutnaKnjiga.BrojPrimjeraka = int.Parse(polja[4]); 
                        

                        //Dodavanje u listu
                        rezultat.Add(trenutnaKnjiga);
                    }
                }
            }
            return rezultat;
        }

        public void SpremiKnjige()
        {
            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga k in this.Knjige)
                {
                    sw.WriteLine($"{k.ISBN} | {k.Autor} | {k.Naslov} | {k.GodinaIzdanja} | {k.BrojPrimjeraka} ");
                }
            }
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
                foreach(Ucenik u in this.Ucenici)
                {
                    sw.WriteLine($"{u.OIB} | {u.Ime} |  {u.Prezime} |  {u.Adresa} |  {u.Telefon} | {u.Razred}");
                }
            }
        }


        public List<Posudba> UcitajPosudbe()
        {
            List<Posudba> rezultat = new List<Posudba>();

            if (File.Exists(datPosudbe))
            {
                using (StreamReader sr = new StreamReader(datPosudbe))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        //djelimo liniju i definiramo objekt posudba
                        Posudba trenutnaPosudba = new Posudba();
                        string[] polja = linija.Split('|');
                        trenutnaPosudba.Ucenik = this.Ucenici.Find(
                            delegate(Ucenik ucenik)
                            {
                                return ucenik.OIB == polja[0];
                            });
                        trenutnaPosudba.Knjiga = this.Knjige.Find(
                            delegate (Knjiga knjiga)
                            {
                                return knjiga.ISBN == polja[1];
                            });
                        trenutnaPosudba.DatumPosudbe = DateTime.Parse(polja[2]);
                        trenutnaPosudba.BrojDana = int.Parse(polja[3]);


                        //Dodavanje u listu
                        rezultat.Add(trenutnaPosudba);
                    }
                }
            }
            return rezultat;
        }

        public void SpremiPosudbe()
        {
            using (StreamWriter sw = new StreamWriter(datPosudbe))
            {
                foreach (Posudba p in this.Posudbe)
                {
                    sw.WriteLine($"{p.Ucenik.OIB} | {p.Knjiga.ISBN} |  {p.DatumPosudbe.ToShortDateString()} |  {p.BrojDana}");
                }
            }
        }

    }

}
