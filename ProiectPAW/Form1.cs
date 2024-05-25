using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW
{
    public partial class MenuPrincipal : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=Rezervari;Integrated Security=True";

        DataSet DSRezervari = new DataSet();

        string SelectComand = "select * from dbo.Osaptari";

        int nrM = 0;

        List<Masa> mese = new List<Masa>();
        List<Ospatar> ospatari = new List<Ospatar>();
        Rezervare rezervare;
        int MaxIdMasa;
        Rezervare an = new Rezervare();
        List<Menu> menu = new List<Menu>();

        private object draggedData;
        private Point dragStartPoint;

        private Font printFont;
        private PrintPreviewDialog printPreviewDialog1;
        public PrintDocument pd;
        PageSetupDialog PageSetupDialog1 = new PageSetupDialog();

        StreamReader streamToPrint = null;
        Bitmap bitmap;
        PrintDialog PrintDialog1 = new PrintDialog();

        int nrobs=0; 
        float[] y;
        List<string> x = new List<string>();

        public MenuPrincipal()
        {

            InitializeComponent();
            this.ResizeRedraw = true;
            IncarcaDate();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            int i;
            UserControlConectatDB ucConectat = new UserControlConectatDB(true);
            //ListView listView = new ListView();
            //listView = lvRezervari;
            ucConectat.Show();

            Ospatar o = new Ospatar("Ion", "Vasile", new DateTime(2001, 09, 11), new DateTime(2020, 10, 10), 1, "0747075250", 2000.2f);
            ospatari.Add(o);
            lbOspatari.Items.Add(o.Nume + " " + o.Prenume);

            Ospatar o1 = new Ospatar("Alex", "Manciu", new DateTime(2004, 09, 11), new DateTime(2022, 11, 3), 2, "0737565689", 2057.2f);
            ospatari.Add(o1);
            lbOspatari.Items.Add(o1.Nume + " " + o1.Prenume);

            Ospatar o2 = new Ospatar("David", "Tudor", new DateTime(1996, 04, 20), new DateTime(2020, 10, 10), 3, "0744158842", 2400.6f);
            ospatari.Add(o2);
            lbOspatari.Items.Add(o2.Nume + " " + o2.Prenume);

            Ospatar o3 = new Ospatar("Dexter", "Margineanu", new DateTime(1989, 12, 25), new DateTime(2005, 12, 25), 4, "0745123158", 2460.9f);
            ospatari.Add(o3);
            lbOspatari.Items.Add(o3.Nume + " " + o3.Prenume);

            for (i = 1; i < 5; i++)
            {
                Masa masa1 = new Masa();
                masa1.Id = i;
                masa1.Status = Status.Libera;
                switch (i)
                {
                    case 1:
                        masa1.NrLocuri = NrLoc.Doua; break;
                    case 2:
                        masa1.NrLocuri = NrLoc.Patru; break;
                    case 3:
                        masa1.NrLocuri = NrLoc.Sase; break;
                    case 4:
                        masa1.NrLocuri = NrLoc.Opt; break;
                }
                mese.Add(masa1);
                lbMese.Items.Add(masa1.Id);

            }

            for (i = 1; i < 5; i++)
            {

                Masa masa2 = new Masa();
                masa2.Id = i + 4;
                masa2.Status = Status.Libera;
                switch (i)
                {
                    case 1:
                        masa2.NrLocuri = NrLoc.Doua; break;
                    case 2:
                        masa2.NrLocuri = NrLoc.Patru; break;
                    case 3:
                        masa2.NrLocuri = NrLoc.Sase; break;
                    case 4:
                        masa2.NrLocuri = NrLoc.Opt; break;
                }
                mese.Add(masa2);
                lbMese.Items.Add(masa2.Id);
            }

            MaxIdMasa = i + 4;

            int k = 1;
            rezervare = new Rezervare(DateTime.Today.ToShortDateString()+" "+k++.ToString(), "Andrei Minculesu", 3, new DateTime(2024, 05, 31, 15, 30, 30), 4, "0764445445");
            ListViewItem lv = new ListViewItem(rezervare.IdRezervare);
            lv.SubItems.Add(rezervare.NumeClient);
            lv.SubItems.Add(rezervare.nrPersoane.ToString());
            lv.SubItems.Add(rezervare.telefonClient);
            lv.SubItems.Add(rezervare.dateTimeRezervare.ToString());
            lv.Tag = rezervare;
            lvRezervari.Items.Add(lv);

            // Create 7 reservations with future datetimes

            // Reservation 1
            Rezervare rezervare1 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "John Doe", 2, DateTime.Now.AddHours(1), 3, "0723456789");
            ListViewItem lv1 = new ListViewItem(rezervare1.IdRezervare);
            lv1.SubItems.Add(rezervare1.NumeClient);
            lv1.SubItems.Add(rezervare1.nrPersoane.ToString());
            lv1.SubItems.Add(rezervare1.telefonClient);
            lv1.SubItems.Add(rezervare1.dateTimeRezervare.ToString());
            lv1.Tag = rezervare1;
            lvRezervari.Items.Add(lv1);

            // Reservation 2
            Rezervare rezervare2 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "Jane Smith", 4, DateTime.Now.AddHours(2).AddMinutes(30), 2, "0776543210");
            ListViewItem lv2 = new ListViewItem(rezervare2.IdRezervare);
            lv2.SubItems.Add(rezervare2.NumeClient);
            lv2.SubItems.Add(rezervare2.nrPersoane.ToString());
            lv2.SubItems.Add(rezervare2.telefonClient);
            lv2.SubItems.Add(rezervare2.dateTimeRezervare.ToString());
            lv2.Tag = rezervare2;
            lvRezervari.Items.Add(lv2);

            // Reservation 3
            Rezervare rezervare3 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "Michael Brown", 3, DateTime.Now.AddDays(1), 4, "0745678901");
            ListViewItem lv3 = new ListViewItem(rezervare3.IdRezervare);
            lv3.SubItems.Add(rezervare3.NumeClient);
            lv3.SubItems.Add(rezervare3.nrPersoane.ToString());
            lv3.SubItems.Add(rezervare3.telefonClient);
            lv3.SubItems.Add(rezervare3.dateTimeRezervare.ToString());
            lv3.Tag = rezervare3;
            lvRezervari.Items.Add(lv3);

            // Reservation 4
            Rezervare rezervare4 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "Sarah Lee", 1, DateTime.Now.AddDays(2).AddHours(8), 1, "0756789012");
            ListViewItem lv4 = new ListViewItem(rezervare4.IdRezervare);
            lv4.SubItems.Add(rezervare4.NumeClient);
            lv4.SubItems.Add(rezervare4.nrPersoane.ToString());
            lv4.SubItems.Add(rezervare4.telefonClient);
            lv4.SubItems.Add(rezervare4.dateTimeRezervare.ToString());
            lv4.Tag = rezervare4;
            lvRezervari.Items.Add(lv4);

            // Reservation 5 (added)
            Rezervare rezervare5 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "David Miller", 2, DateTime.Now.AddDays(2).AddHours(12), 5, "0767890123");
            ListViewItem lv5 = new ListViewItem(rezervare5.IdRezervare);
            lv5.SubItems.Add(rezervare5.NumeClient);
            lv5.SubItems.Add(rezervare5.nrPersoane.ToString());
            lv5.SubItems.Add(rezervare5.telefonClient);
            lv5.SubItems.Add(rezervare5.dateTimeRezervare.ToString());
            lv5.Tag = rezervare5;
            lvRezervari.Items.Add(lv5);

            // Reservation 6 (added)
            Rezervare rezervare6 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "Olivia Garcia", 5, DateTime.Now.AddDays(5).AddHours(1), 5, "0764467373");
            ListViewItem lv6 = new ListViewItem(rezervare6.IdRezervare);
            lv6.SubItems.Add(rezervare6.NumeClient);
            lv6.SubItems.Add(rezervare6.nrPersoane.ToString());
            lv6.SubItems.Add(rezervare6.telefonClient);
            lv6.SubItems.Add(rezervare6.dateTimeRezervare.ToString());
            lv6.Tag = rezervare6;
            lvRezervari.Items.Add(lv6);


            // Reservation 7 (assuming you want 7 total)
            Rezervare rezervare7 = new Rezervare(DateTime.Today.ToShortDateString() + " " + k++.ToString(), "Emily Jones", 1, DateTime.Now.AddDays(1).AddHours(10), 1, "0734560568");
            ListViewItem lv7 = new ListViewItem(rezervare7.IdRezervare);
            lv7.SubItems.Add(rezervare7.NumeClient);
            lv7.SubItems.Add(rezervare7.nrPersoane.ToString());
            lv7.SubItems.Add(rezervare7.telefonClient);
            lv7.SubItems.Add(rezervare7.dateTimeRezervare.ToString());
            lv7.Tag = rezervare7;
            lvRezervari.Items.Add(lv7);







            List<float> floats = new List<float>();
            AranjareMese(mese);
            creareMenu(menu);
            foreach (Menu m in menu)
            {
                nrobs++;
                x.Add(m.Nume);
                floats.Add(m.Pret);
            }
            y = floats.ToArray();
            Array.Sort(y);
            tvMeseComenzi.ExpandAll();
}

        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectComand, conexiune);
            adaptor.Fill(DSRezervari, "Rezervari");
            DSRezervari.Tables["Rezervari"].PrimaryKey = new DataColumn[1]
                {DSRezervari.Tables["Rezervari"].Columns["Id"] };
            conexiune.Close();

           

        }


        private List<Menu> creareMenu(List<Menu> menu)
        {

            Menu pizza = new Menu("Pizza Diavola", new List<string> { "Sos de rosii", "Mozzarella", "Salam picant", "Ardei iute" }, 4, 1, 35.00f);

            Menu salataCaesar = new Menu("Salata Caesar", new List<string> { "Salata verde", "Pui la gratar", "Crutoane", "Parmezan", "Dressing Caesar" }, 5, 1, 28.00f);

            Menu pasteBolognese = new Menu("Paste Bolognese", new List<string> { "Paste", "Sos de carne tocata", "Rosii", "Ceapa", "Morcovi" }, 5, 1, 32.00f);

            Menu desertTiramisu = new Menu("Tiramisu", new List<string> { "Biscuiti savoiardi", "Crema de mascarpone", "Cafea espresso", "Cacao pudra" }, 4, 1, 25.00f);

            // Additional menu items
            Menu burgerVita = new Menu("Burger Vita", new List<string> { "Chifla de grau integral", "Chifla vegetariana", "Cotlet de vita", "Salata verde", "Rosii", "Ceapa", "Sos de mustar", "Sos barbeque" }, 8, 1, 38.00f);

            Menu wrapFalafel = new Menu("Wrap Falafel", new List<string> { "Wrap integral", "Falafel", "Hummus", "Tahini", "Salata verde", "Varza rosie", "Castraveti", "Patrunjel", "Sos de iaurt" }, 9, 1, 26.00f);

            Menu quesadillaVegetariana = new Menu("Quesadilla Vegetariana", new List<string> { "Tortilla de grau", "Branza cheddar", "Fasole neagra", "Ardei gras", "Ceapa rosie", "Avocado", "Sos de salsa" }, 7, 1, 29.00f);

            Menu sandvisPuiGril = new Menu("Sandvis Pui Gril", new List<string> { "Paine integrala", "Pui la gratar", "Salata verde", "Rosii", "Castraveti", "Sos de maioneza", "Mustar" }, 6, 1, 24.00f);

            Menu salataNicio = new Menu("Salata Nicio", new List<string> { "Salata verde", "Rosii", "Castraveti", "Ardei gras", "Masline", "Branza feta", "Ulei de masline", "Otet balsamic" }, 6, 1, 22.00f);

            Menu supaCremaRosii = new Menu("Supa Crema Rosii", new List<string> { "Rosii cherry", "Ceapa", "Morcovi", "Ulei de masline", "Smantana", "Patrunjel verde" }, 5, 1, 18.00f);

            Menu pasteCarbonara = new Menu("Paste Carbonara", new List<string> { "Paste", "Guanciale (bacon italian)", "Oua", "Parmezan", "Piper negru", "Ulei de masline" }, 6, 1, 30.00f);

            Menu pizzaQuattroFormaggi = new Menu("Pizza Quattro Formaggi", new List<string> { "Sos de rosii", "Mozzarella", "Gorgonzola", "Parmezan", "Fontina" }, 4, 1, 33.00f);

            Menu risottoGungi = new Menu("Risotto Gungi", new List<string> { "Orez Arborio", "Ciuperci gungi", "Ceapa", "Vin alb", "Parmezan", "Unt" }, 6, 1 , 27.00f);

            Menu tiramisuCacao = new Menu("Tiramisu Cacao", new List<string> { "Biscuiti savoiardi", "Crema de mascarpone", "Cafea espresso", "Cacao pudra", "Cacao nibs" }, 4, 1, 28.00f);


            menu.Add(pizza);
            menu.Add(salataCaesar);
            menu.Add(pasteBolognese);
            menu.Add(desertTiramisu);
            menu.Add(burgerVita);
            menu.Add(wrapFalafel);
            menu.Add(quesadillaVegetariana);
            menu.Add(sandvisPuiGril);
            menu.Add(salataNicio);
            menu.Add(supaCremaRosii);
            menu.Add(pasteCarbonara);
            menu.Add(pizzaQuattroFormaggi);
            menu.Add(risottoGungi);
            menu.Add(tiramisuCacao);

           
            return menu;
        }

        private void AranjareMese(List<Masa> mese)
        {

            int i;
            Array tipuri_mese = Enum.GetValues(typeof(NrLoc));

            for (i = 0; i < tipuri_mese.Length; i++)
            {
                TreeNode t = new TreeNode();
                t.Text = tipuri_mese.GetValue(i).ToString() + " locuri";
                t.Tag = tipuri_mese.GetValue(i);
                tvMeseComenzi.Nodes.Add(t);

                for (int j = 0; j < mese.Count; j++)
                {
                    TreeNode t1 = new TreeNode("Masa nr " + mese[j].Id.ToString());
                    t1.Tag = mese[j];
                    if (mese[j].NrLocuri.ToString() == t.Tag.ToString())
                        t.Nodes.Add(t1);

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rezervariDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.rezervariDataSet.Rezervare);
            //this.
        }

        private void comenziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervare r = null;
            Creeare_Comanda creeare_Comanda = new Creeare_Comanda(rezervare);
            if(creeare_Comanda.ShowDialog() == DialogResult.OK)
            {
                r = creeare_Comanda.rFormRezerv;
                ListViewItem lv = new ListViewItem(r.IdRezervare);
                lv.SubItems.Add(r.NumeClient);
                lv.SubItems.Add(r.nrPersoane.ToString());
                lv.SubItems.Add(r.dateTimeRezervare.ToString());
                lv.SubItems.Add(r.telefonClient);
                lv.Tag = r;
                lvRezervari.Items.Add(lv);
            }
        }

        private void lvRezervari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tvMeseComenzi_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tbTeste_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "fisier XML|*.xml";
            saveFileDialog.CheckPathExists = true;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               // saveFileDialog.FileName = "..\\Ospatari.xml";
               
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Menu>));
                    Stream fisier = File.Create(saveFileDialog.FileName);
                    serializer.Serialize(fisier, menu);
                    MessageBox.Show("Menu-ul au fost salvati in fisierul XML cu succes!");
                    fisier.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nu s-a putut salva fisierul!");
                }
            }
        }



        private void adaugaMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa m = null;
            FormMasa form = new FormMasa(m, MaxIdMasa);
            if (form.ShowDialog() == DialogResult.OK)
            {
                mese.Add(form.mForm);
                lbMese.Items.Add(form.mForm.Id);
            }
        }

        private void modificaMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(lbMese.SelectedItems.Count > 0)
            {
                Masa m = new Masa();
                m = mese[Int32.Parse(lbMese.SelectedItems[0].ToString())];
                FormMasa form = new FormMasa(m, MaxIdMasa);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    mese[Int32.Parse(lbMese.SelectedItems[0].ToString())] = form.mForm;
                }
           }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eliminaMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbMese.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi masa selectata?",
                    "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    mese[Int32.Parse(lbMese.SelectedItems[0].ToString())] = null;
                    lbMese.Items.Remove(lbMese.SelectedItems[0]);
                }

            }
        }

        

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaMasaToolStripMenuItem_Click(sender, e);
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificaMasaToolStripMenuItem_Click(sender, e);
        }

        private void cmMese_Opening(object sender, CancelEventArgs e)
        {
            if(lbMese.SelectedItems.Count > 0)
            {
                modificaMasaToolStripMenuItem.Enabled = true;
                eliminaMasaToolStripMenuItem.Enabled=true;
            }
            else
            {
                modificaMasaToolStripMenuItem.Enabled = false;
                eliminaMasaToolStripMenuItem.Enabled = false;
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminaMasaToolStripMenuItem_Click(sender, e);  
        }

        private void tvMeseComenzi_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(new Rezervare().GetType().ToString()) || e.Data.GetDataPresent((new Ospatar().GetType().ToString()))) { 
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void tvMeseComenzi_DragDrop(object sender, DragEventArgs e)
        {
            Point pctDnTV = tvMeseComenzi.PointToClient(new Point(e.X,e.Y));
            TreeNode tn = tvMeseComenzi.GetNodeAt(pctDnTV);

            if(e.Effect==DragDropEffects.Copy && e.Data.GetDataPresent(new Rezervare().GetType().ToString())){
                Rezervare r = (Rezervare)e.Data.GetData(new Rezervare().GetType().ToString());
                TreeNode t = new TreeNode(r.IdRezervare.ToString() + " " + r.NumeClient.ToString());
                if (tn.Tag.ToString() != (new Ospatar().GetType().ToString()) && tn.Tag.ToString() != (new Rezervare().GetType().ToString()) && (tn.Parent != null))
                {
                    if (
                                tn.Parent.Text.StartsWith("D") && r.nrPersoane > 2 ||
                                tn.Parent.Text.StartsWith("P") && r.nrPersoane > 4 ||
                                tn.Parent.Text.StartsWith("S") && r.nrPersoane > 6 ||
                                tn.Parent.Text.StartsWith("O") && r.nrPersoane > 8)
                    {
                        MessageBox.Show("Prea multe persoane! Selectati o masa mai mare!");
                    }
                    else
                    {
                        try
                        {

                            r.masa = Int32.Parse(tn.Text.Substring(tn.Text.Length - 1));

                            if (mese[r.masa].Status != Status.Rezervata)
                            {
                                mese[r.masa].Status = Status.Rezervata;
                                t.Tag = r;
                                tn.Nodes.Add(t);
                            }
                            else
                            {
                                MessageBox.Show("Masa Ocupata!");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nu a fost selectata o masa!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Comanda trebuie atribuita unei mese!!!");
                }
            }
            else if(e.Effect == DragDropEffects.Copy &&   e.Data.GetDataPresent(new Ospatar().GetType().ToString())){
                bool x = false;
                bool ok = true;
                if (tn.Parent == null && ok == true)
                {
                    ok = false;
                    MessageBox.Show("Nu se poate atribui un ospatar unui tip de masa!");
                }
                if (tn.GetNodeCount(x) > 0 && ok == true)
                {
                    ok = false;
                    MessageBox.Show("Aceasta masa are deja un ospatar atribuit!");
                }
                if (tn.Tag.ToString() == (new Ospatar().GetType().ToString()) && ok == true)
                {
                    ok = false;
                    MessageBox.Show("Nu se poate atribui un ospatar altui ospatar!");
                }
                if(tn.Tag.ToString() != (new Rezervare().GetType().ToString()) && ok == true)
                {
                    ok = false;
                    MessageBox.Show("Nu se poate atribui un ospatar unei mese fara comenzi!");
                }
                if (ok == true)
                {
                    Ospatar o = (Ospatar)e.Data.GetData(new Ospatar().GetType().ToString());
                    TreeNode t = new TreeNode(o.Nume + " " + o.Prenume);
                    t.Tag = o;
                    tn.Nodes.Add(t);
                }
            }
            tvMeseComenzi.ExpandAll();
        }

        private void lbOspatari_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbOspatari.SelectedItems.Count > 0)
            {
                lbOspatari.DoDragDrop(Ospatar.ToOspatar(lbOspatari.SelectedItem.ToString()), DragDropEffects.Copy);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void restaurareDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " fisier XML|*.xml";
            openFileDialog.CheckPathExists = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    Stream fisier = File.OpenRead(openFileDialog.FileName);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Menu>));
                    List<Menu> list = (List<Menu>)xmlSerializer.Deserialize(fisier);
                    if(menu.Count > 0)
                    {
                        if(MessageBox.Show("Doriti sa stergeti Menu-ul existent?","Confirmare",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            menu.Clear();
                            menu = list;
                           
                        }
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show("Fisierul nu a putut fi deschis!");
                }
            }
        }

        private void tbTeste_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tvMeseComenzi_DoubleClick(object sender, EventArgs e)
        {

            if (tvMeseComenzi.SelectedNode!=null) {
                tvMeseComenzi.SelectedNode.Remove();
            }
            
        }

        


        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvRezervari.SelectedItems.Count > 0)
                lvRezervari.DoDragDrop((Rezervare)lvRezervari.SelectedItems[0].Tag, DragDropEffects.Copy);
        }

        private void modificaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRezervari.SelectedItems.Count > 0 )
            {
                rezervare = (Rezervare)lvRezervari.SelectedItems[0].Tag;
                Creeare_Comanda form = new Creeare_Comanda(rezervare);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvRezervari.SelectedItems[0] as ListViewItem;
                    lv.SubItems[0].Text = rezervare.IdRezervare.ToString();
                    lv.SubItems[1].Text = rezervare.NumeClient;
                    lv.SubItems[2].Text = rezervare.nrPersoane.ToString();
                    lv.SubItems[4].Text = rezervare.dateTimeRezervare.ToString();
                    lv.SubItems[3].Text = rezervare.telefonClient;
                    lv.Tag = rezervare;
                    lvRezervari.Items.Add(lv);
                }
            }
        }


        private void PrintPage(object sender, PrintPageEventArgs ev)
        {

            String linie_txt = "MENU";

            SolidBrush pns = new SolidBrush(Color.Black);

            float x = 150.0F; float y = 150.0F;

            ev.Graphics.DrawString(linie_txt, printFont, pns, x, y);

            ev.HasMorePages = true;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 10;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            linie_txt = null;

            linesPerPage = ev.MarginBounds.Height /
                printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((linie_txt = streamToPrint.ReadLine())
                != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(linie_txt, printFont, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                count++;
            }


            if (linie_txt != null)
                ev.HasMorePages = true;
            else ev.HasMorePages = false;

        }

        private void printMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pd = new PrintDocument();
            printFont = new Font("Arial", 16);
            try { string s = "..\\..\\" + "Menuri\\" + "Menu.txt";
                streamToPrint = new StreamReader(s); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            this.pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPreviewDialog1.Document = pd;

            printPreviewDialog1.ShowDialog();
            streamToPrint.Close();
        }

        private void salvareMenuInFisierTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var properties = typeof(Menu).GetProperties();

            string filePath = "..\\..\\" + "Menuri\\" + "Menu.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                
                foreach (Menu item in menu)
                {
                    var values = new List<string>();
                    foreach (var property in properties)
                    {
                        if(property.Name != "Ingrediente")
                            values.Add(property.GetValue(item)?.ToString() ?? "");
                        else
                        {
                            
                        }
                    }

                    writer.WriteLine(string.Join(",", values));
                }
            }
        }

        private void graficPreturiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs pe)
        {

            Graphics g = pe.Graphics;

            Rectangle zonaClient = pe.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);
            g.FillRectangle(fundal, zonaClient);        //coloreaza alb zonaClient

            zonaClient.X += 20; zonaClient.Y += 20;             // margini
            zonaClient.Height -= 40; zonaClient.Width -= 40;    // dreptunghi de vizualizare

            int i, vl = zonaClient.Left, vb = zonaClient.Bottom,
                    vr = zonaClient.Right, vt = zonaClient.Top;

            Pen creionRosu = new Pen(Color.Red, 2);     // rosu, grosime 2
            g.DrawRectangle(creionRosu, zonaClient);

            string denx = ""; int lat, dist;
            float rap_dist_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[]{
                                                   new SolidBrush(Color.Pink),
                                                   new SolidBrush(Color.RoyalBlue),
                                                   new SolidBrush(Color.Moccasin),
                                                   new SolidBrush(Color.PowderBlue),
                                                   new SolidBrush(Color.Yellow),
                                                   new SolidBrush(Color.LightGreen)
                                               };
            Pen[] creioane = new Pen[]{
                                                   new Pen(Color.Red),
                                                   new Pen(Color.Blue),
                                                   new Pen(Color.Green),
                                                   new Pen(Color.Olive),
                                                   new Pen(Color.Yellow),
                                                   new Pen(Color.Cyan)
                                               };
            SolidBrush pnsCrt;
            Pen penCrt;

            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);
            // latimea unui cuplu bara+interspatiu

            dist = (int)(lat * rap_dist_lat);
            // interspatiu

            for (max = y[0], i = 1; i < nrobs; i++)
                if (max < y[i]) max = y[i]; // max dintre y-i

            penCrt = creioane[0]; pnsCrt = pensule[5];
            g.DrawLine(penCrt, vl, vt, vl, vb);
            g.DrawLine(penCrt, vl, vb, vr, vb);
            //axele

            penCrt = creioane[1];
            Font valueFont = new Font("Arial", 8); // adjust font and size as needed

            for (i = 0; i < nrobs; i++)
            {
                pnsCrt = pensule[(4 + i) % 6];
                PointF pnt;
                pnt = new PointF(vl + dist + i * (lat + dist),
                    vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));

                // Draw value above the bar (adjust placement as needed)
                denx = "" + y[i];
                float valueX = vl + dist + i * (lat + dist) + lat / 2 - g.MeasureString(denx, valueFont).Width / 2;
                float valueY = vb - y[i] * (vb - vt) / max - valueFont.GetHeight();
                g.DrawString(denx, valueFont, Brushes.Black, valueX, valueY);
            }


            penCrt = creioane[1];
            for (i = 0; i < nrobs; i++)
            {
                pnsCrt = pensule[(4 + i) % 6];
                PointF pnt; pnt = new PointF(vl + dist + i * (lat + dist),
                    vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));

                denx = "" + x[i];
                g.DrawString(denx, Font, pnsCrt, vl + dist + lat / 2 + i * (lat + dist), vb + 5);
            }


        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            pGfPreturi.Invalidate();
        }

        private void grafictoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
