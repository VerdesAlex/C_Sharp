using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Creeare_Comanda : Form
    {
        public Rezervare rFormRezerv;

        public Creeare_Comanda(Rezervare r)
        {
            InitializeComponent();
            r = new Rezervare();
            r = rFormRezerv;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creeare_Comanda_Load(object sender, EventArgs e)
        {

        }

        private void cbNrPers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {

            rFormRezerv.NumeClient = tbNume.Text;
            rFormRezerv.nrPersoane = Int32.Parse(tbNrPers.Text);
            rFormRezerv.telefonClient = tbTel.Text;
            rFormRezerv.dateTimeRezervare = dtDataRezervare.Value.Date;

            string eroare = "";

            if (rFormRezerv.dateTimeRezervare < DateTime.Now)
            {
                eroare = "Data selectata este";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtOraRezervare_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
