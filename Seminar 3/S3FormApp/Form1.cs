using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nigger_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rezultat;
            rezultat = MessageBox.Show("Sup bro?",  "Nigga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.Cancel)
                MessageBox.Show("Esti gay");
            else
                MessageBox.Show("Nu esti gay");
        }
    }
}
