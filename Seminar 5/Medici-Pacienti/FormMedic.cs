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
                btnAdauga.Text = "Adauga";
            }
            else { 
                btnAdauga.Text = "Editeaza";
                tbCNP.Text = m.Cnp;
                tbNume.Text = m.Nume;
                cbSpec.Text = m.Specializare;
                tbAnAbs.Text=m.AnAbsolvire.ToString();
                dateDataNastere.Value = m.DataNastere;

            }
            mFormMedic = m;

        }

        private void FormMedic_Load(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            mFormMedic.Cnp= tbCNP.Text;
            mFormMedic.Nume= tbNume.Text;
            mFormMedic.Specializare = cbSpec.SelectedItem.ToString();
            mFormMedic.AnAbsolvire = Convert.ToInt32(tbAnAbs.Text);
            mFormMedic.DataNastere = dateDataNastere.Value;
        }
    }
}
