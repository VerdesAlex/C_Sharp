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
    public partial class Form1 : Form
    {
        Menu menu;
        List<Masa> mese;
        List<Ospatar> ospatari;
        Rezervare rezervari;

        public Form1()
        {
            InitializeComponent();
            UserControlConectatDB ucConectat = new UserControlConectatDB(true);
            ListView listView = new ListView();
            listView = lvRezervari;
            ucConectat.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comenziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervare r = null;
            Creeare_Comanda creeare_Comanda = new Creeare_Comanda(rezervari);
            if(creeare_Comanda.ShowDialog() == DialogResult.OK)
            {
                r = creeare_Comanda.rFormRezerv;
            }
        
        }

        private void lvRezervari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
