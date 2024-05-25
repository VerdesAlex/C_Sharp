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
    public partial class FormMasa : Form
    {
        public Masa mForm;
        public int IdMaxim;
        public FormMasa(Masa m, int IdMax)
        {
            InitializeComponent();
            IdMaxim = IdMax;
            if(m == null)
            {
                m = new Masa();
                btnAdauga.Text = "Adauga Masa";
            }
            else
            {
                btnAdauga.Text = "Modifica Masa";
                tbIdMasa.Text = m.Id.ToString();
                cbNrLocuri.Text = m.NrLocuri.ToString();
            }
            mForm = m;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMasa_Load(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {

            
            Masa m = new Masa();
            m.Id = Int32.Parse(tbIdMasa.Text);
            m.Status = Status.Libera;
            m.NrLocuri = m.ConvertStringToNrLoc(cbNrLocuri.SelectedItem.ToString());
            IdMaxim = m.Id;
            String eroare = "";
            if (m.Id < IdMaxim && m.Id != mForm.Id)
            {
                eroare += "Id invalid!";
                errorProvider1.SetError(tbIdMasa, eroare);
            }
            else
            {
                    mForm = m;
                    IdMaxim = m.Id;
            }
            DialogResult= DialogResult.OK;
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNrLocuri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbNrLocuri_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))
                //if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void cbNrLocuri_MouseLeave(object sender, EventArgs e)
        {
               
        }

        private void cbNrLocuri_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbNrLocuri_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
