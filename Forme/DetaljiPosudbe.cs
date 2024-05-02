using Knjiznicaaaaa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjiznicaaaaa.Forme
{
    public partial class DetaljiPosudbe : Form
    {
        public PodatkovniKontekst kontekst;
        public Posudba Posudba;
        public DetaljiPosudbe(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void DetaljiPosudbe_Load(object sender, EventArgs e)
        {
            OsvjeziUcenike();
            OsvjeziKnjige();

            if ( this.Posudba != null)
            {
                lbUcenici.SelectedItem = this.Posudba.Ucenik;
                lbKnjige.SelectedItem = this.Posudba.Knjiga;
                dtpDatumPosudbe.Value = this.Posudba.DatumPosudbe;
                nudBrojDana.Value = this.Posudba.BrojDana;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void OsvjeziUcenike()
        {
            Helper.PrikaziListuUListboxu<Ucenik>(this.kontekst.Ucenici, lbUcenici);
        }

        private void OsvjeziKnjige()
        {
            Helper.PrikaziListuUListboxu<Knjiga>(this.kontekst.Knjige, lbKnjige);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lbUcenici.SelectedItem == null || lbKnjige.SelectedItem == null)
            {
                MessageBox.Show("Molimte odaberi ucenika i knjigu");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if ( this.Posudba == null)
                {
                    this.Posudba = new Posudba();
                }

                this.Posudba.Ucenik = (Ucenik)lbUcenici.SelectedItem;
                this.Posudba.Knjiga = (Knjiga)lbKnjige.SelectedItem;
                this.Posudba.DatumPosudbe = dtpDatumPosudbe.Value;
                this.Posudba.BrojDana = (int)nudBrojDana.Value;
            }
        }
    }
}
