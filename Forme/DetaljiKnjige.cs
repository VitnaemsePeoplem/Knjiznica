using Knjiznicaaaaa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjiznicaaaaa
{
    public partial class DetaljiKnjige : Form
    {
        public Knjiga Knjiga;
        public DetaljiKnjige()
        {
            InitializeComponent();
        }

        private void DetaljiKnjige_Load(object sender, EventArgs e)
        {
            nudGodinaIzdanja.Maximum = DateTime.Now.Year;
            nudGodinaIzdanja.Value = DateTime.Now.Year;

            if ( this.Knjiga!= null)
            {
                tbISBN.Text = this.Knjiga.ISBN;
                tbNaslov.Text = this.Knjiga.Naslov;
                tbAutor.Text = this.Knjiga.Autor;
                nudGodinaIzdanja.Value = (decimal)this.Knjiga.GodinaIzdanja;
                cbBrojPrimjeraka.Text = this.Knjiga.BrojPrimjeraka.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbISBN.Text == "" || tbNaslov.Text == "")
            {
                MessageBox.Show("Molim te unesi barem ISBN i Naslov");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if(this.Knjiga == null)
                {
                    this.Knjiga = new Knjiga();
                }

                this.Knjiga.ISBN = tbISBN.Text;
                this.Knjiga.Autor = tbAutor.Text;
                this.Knjiga.Naslov = tbNaslov.Text;
                this.Knjiga.GodinaIzdanja = (int)nudGodinaIzdanja.Value;
                this.Knjiga.BrojPrimjeraka = int.Parse(cbBrojPrimjeraka.Text);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
