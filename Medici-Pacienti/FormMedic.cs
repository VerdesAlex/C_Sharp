using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medici_Pacienti
{
    public partial class FormMedic : Form
    {
        public Medic mFormMedic;
        public FormMedic(Medic m)
        {
            InitializeComponent();
            if (m == null)
            {
                m = new Medic();
                adaugaBtn.Text = "Adauga";
            }
            else
            {
                adaugaBtn.Text = "Editeaza";
                tbCNP.Text = m.Cnp;
                tbNume.Text = m.Nume;
                cbSpec.Text = m.Specializare;
                tbAn.Text = m.AnAbsolvire.ToString();
                dateDataNastere.Value = m.DataNastere;
            }
            mFormMedic = m;
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            mFormMedic.Cnp = tbCNP.Text;
            mFormMedic.Nume = tbNume.Text;
            mFormMedic.Specializare = cbSpec.SelectedItem.ToString();
            mFormMedic.AnAbsolvire = Convert.ToInt32(tbAn.Text);
            mFormMedic.DataNastere = dateDataNastere.Value;
            // Datele medicului ajung in Form1 prin referinta primita in constructor
        }
    }
}
