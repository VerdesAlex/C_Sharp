using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_9_BDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet1.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.testDataSet1.Pacienti);
            // TODO: This line of code loads data into the 'testDataSet.Medici' table. You can move, or remove it, as needed.
            this.mediciTableAdapter.Fill(this.testDataSet.Medici);

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try { 
                this.Validate();
                this.mediciBindingSource.EndEdit();
                this.mediciTableAdapter.Update(this.testDataSet.Medici);
                MessageBox.Show("Salvare cu succes!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            try {  
                this.Validate();
                this.pacientiBindingSource.EndEdit();
                this.pacientiTableAdapter.Update(this.testDataSet1.Pacienti);
                MessageBox.Show("Salvare cu succes!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
