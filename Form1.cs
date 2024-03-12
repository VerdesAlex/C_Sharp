using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S4
{
    public partial class Form1 : Form
    {
        Medic m1, m2;
        public Form1()
        {
            InitializeComponent();
            m1 = new Medic("5039217190278", "Marian", 2020,"Chirurgie Plastica", new DateTime(1980,05,25));
            m2 = new Medic("6273817263782", "Ana", 2015, "Neurologie", new DateTime(1978, 08, 15));
            lbMedici.Items.Add(m1.Nume);
            lbMedici.Items.Add(m2.Nume);


            //metoda 1
            ListViewItem lv = new ListViewItem(m1.Nume);
            lv.SubItems.Add(m1.Cnp);
            lv.SubItems.Add(m1.AnAbsolvire.ToString());
            lv.SubItems.Add(m1.Specializare);
            lv.SubItems.Add(m1.DataNasterii.ToString());
            lv.Tag = m1;  //asociaza linia lv cu obiectul m1
            lvMedici.Items.Add(lv);

            //metoda 2
            ListViewItem lv2 = new ListViewItem(new string[] { m2.Nume, m2.Cnp, m2.AnAbsolvire.ToString(), m2.Specializare, m2.DataNasterii.ToString() });
            lv2.Tag = m2; //asociaza linia lv cu obiectul m2
            lvMedici.Items.Add(lv2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMedici.SelectedItem!=null)
                tbMedici.Text = lbMedici.SelectedItem.ToString();
        }

        private void lvMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                tbMedici.Text = "";
                foreach (ListViewItem lv in lvMedici.SelectedItems)
                //ListViewItem lv = lvMedici.SelectedItems[0];
                tbMedici.Text += lv.Text.ToUpper() + ", " + lv.SubItems[1].Text + ", " + lv.SubItems[2].Text + ", " + lv.SubItems[3].Text + ", " + lv.SubItems[4].Text+"; ";
                //Medic mlocal = (Medic)lv.Tag;  --asociem prin tag
                //tbMedici.Text = mlocal.Nume + " " + mlocal.Cnp;  --afisam folosind tagul doar numele si cnp ul medicului
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
