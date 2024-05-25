using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Creeare_Comanda : Form
    {
        public Rezervare rFormRezerv= new Rezervare();

        public Creeare_Comanda(Rezervare r)
        {
            InitializeComponent();
            r = new Rezervare();
            r = rFormRezerv;
            this.dtDataRezervare.Format = DateTimePickerFormat.Custom;
            this.dtDataRezervare.CustomFormat = "dd/MM/yyyy hh:mm";
            
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

            string eroare = "";
            int vNP;

            if(tbNume.Text == null )
            {
                eroare = "Introduceti numele!";
                errNume.SetError(tbNume,eroare);
            }
            if(tbNrPers.Text == null)
            {
                eroare = "Introduceti numarul de persoane!";
                errNrPers.SetError(tbNrPers,eroare);
            }
            if (int.TryParse(tbNrPers.Text.ToString(), out vNP))
            {
                if (vNP > 8)
                {
                    eroare = "Prea multe persoane!";
                    errPMP.SetError(tbNrPers, eroare);
                }
                if (vNP < 1)
                {
                    eroare = "Prea putine persoane!";
                    errPMP.SetError(tbNrPers, eroare);
                }
            }
            else
            {
                Debug.WriteLine($"{nameof(tbNrPers)} is empty or Invalid");
                eroare = "Input invalid!";
                errNrPers.SetError(tbNrPers, eroare);
            }
            
            if(dtDataRezervare.Value == null)
            {
                eroare = "Selectati data si ora rezervarii!";
                errDate.SetError(dtDataRezervare,eroare);
            }

            if (eroare.Length == 0)
            {

                    rFormRezerv.NumeClient = tbNume.Text;
                    rFormRezerv.nrPersoane = Int32.Parse(tbNrPers.Text);
                    rFormRezerv.telefonClient = tbTel.Text;
                    rFormRezerv.dateTimeRezervare = dtDataRezervare.Value; //.Date;
                    DialogResult = DialogResult.OK;
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtOraRezervare_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtDataRezervare_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbNrPers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46 && (sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
            {
                e.Handled = true;
            }
        }

        private void tbNume_Leave(object sender, EventArgs e)
        {

            rFormRezerv.NumeClient = tbNume.Text;
        }

        private void tbNrPers_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNrPers_Leave(object sender, EventArgs e)
        {
            int vNP;
            if (int.TryParse(tbNrPers.Text.ToString(), out vNP))
            {
                if (vNP > 0 && vNP < 9)
                    rFormRezerv.nrPersoane = vNP;
            }
            else
                Debug.WriteLine($"{nameof(tbNrPers)} is empty or Invalid");
        }

        private void tbTel_Leave(object sender, EventArgs e)
        {

            rFormRezerv.telefonClient = tbTel.Text;
        }

        private void dtDataRezervare_Leave(object sender, EventArgs e)
        {

            rFormRezerv.dateTimeRezervare = dtDataRezervare.Value;
        }
    }
}
