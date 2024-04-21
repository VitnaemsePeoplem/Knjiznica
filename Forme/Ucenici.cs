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
    public partial class Ucenici : Form
    {
        PodatkovniKontekst kontekst;
        public Ucenici(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            lbUcenici.Items.Clear();
            this.kontekst.Ucenici.Sort();
            foreach(Ucenik trenutniUcenik in kontekst.Ucenici)
            {
                lbUcenici.Items.Add(trenutniUcenik);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
