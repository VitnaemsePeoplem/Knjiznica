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
    public partial class Knjige : Form
    {
        public PodatkovniKontekst kontekst;
        public Knjige(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
