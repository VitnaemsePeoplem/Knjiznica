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
    public partial class DetaljiUcenika : Form
    {
        public Ucenik Ucenik;
        public DetaljiUcenika()
        {
            InitializeComponent();
        }

        private void DetaljiUcenika_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbOIB.Text == "" || tbIme.Text == "")
            {
                MessageBox.Show("Molim te unesi oib i ime");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if(this.Ucenik==null)
                {
                    this.Ucenik = new Ucenik();
                    this.Ucenik.OIB = tbOIB.Text;
                    this.Ucenik.Ime = tbIme.Text;
                    this.Ucenik.Prezime = tbPrezime.Text;
                    this.Ucenik.Adresa = tbAdresa.Text;
                    this.Ucenik.Telefon = tbTelefon.Text;
                    this.Ucenik.Razred = int.Parse(cbRazred.Text);

                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
