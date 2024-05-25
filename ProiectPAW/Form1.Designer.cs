namespace ProiectPAW
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvMeseComenzi = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurareDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvareMenuInFisierTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaMasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaMasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaMasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbMese = new System.Windows.Forms.ListBox();
            this.lbOspatari = new System.Windows.Forms.ListBox();
            this.cmMese = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errMasaOcupata = new System.Windows.Forms.ErrorProvider(this.components);
            this.rezervariDataSet = new ProiectPAW.RezervariDataSet();
            this.rezervariDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new ProiectPAW.RezervariDataSetTableAdapters.RezervareTableAdapter();
            this.rezervareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNrPers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pGfPreturi = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.cmMese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMasaOcupata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvMeseComenzi
            // 
            this.tvMeseComenzi.AllowDrop = true;
            this.tvMeseComenzi.Location = new System.Drawing.Point(789, 27);
            this.tvMeseComenzi.Name = "tvMeseComenzi";
            this.tvMeseComenzi.Size = new System.Drawing.Size(327, 225);
            this.tvMeseComenzi.TabIndex = 0;
            this.tvMeseComenzi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMeseComenzi_AfterSelect);
            this.tvMeseComenzi.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMeseComenzi_DragDrop);
            this.tvMeseComenzi.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMeseComenzi_DragEnter);
            this.tvMeseComenzi.DoubleClick += new System.EventHandler(this.tvMeseComenzi_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.rezervariToolStripMenuItem,
            this.meseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareInFisierToolStripMenuItem,
            this.toolStripSeparator2,
            this.restaurareDinFisierToolStripMenuItem,
            this.toolStripSeparator1,
            this.salvareMenuInFisierTXTToolStripMenuItem,
            this.toolStripSeparator3,
            this.printMenuToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "&Fisiere";
            // 
            // salvareInFisierToolStripMenuItem
            // 
            this.salvareInFisierToolStripMenuItem.Name = "salvareInFisierToolStripMenuItem";
            this.salvareInFisierToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.salvareInFisierToolStripMenuItem.Text = "Salvare Menu in Fisier XML";
            this.salvareInFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // restaurareDinFisierToolStripMenuItem
            // 
            this.restaurareDinFisierToolStripMenuItem.Name = "restaurareDinFisierToolStripMenuItem";
            this.restaurareDinFisierToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.restaurareDinFisierToolStripMenuItem.Text = "Restaurare Menu din Fisier XML";
            this.restaurareDinFisierToolStripMenuItem.Click += new System.EventHandler(this.restaurareDinFisierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // salvareMenuInFisierTXTToolStripMenuItem
            // 
            this.salvareMenuInFisierTXTToolStripMenuItem.Name = "salvareMenuInFisierTXTToolStripMenuItem";
            this.salvareMenuInFisierTXTToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.salvareMenuInFisierTXTToolStripMenuItem.Text = "Salvare Menu in Fisier TXT";
            this.salvareMenuInFisierTXTToolStripMenuItem.Click += new System.EventHandler(this.salvareMenuInFisierTXTToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(237, 6);
            // 
            // printMenuToolStripMenuItem
            // 
            this.printMenuToolStripMenuItem.Name = "printMenuToolStripMenuItem";
            this.printMenuToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.printMenuToolStripMenuItem.Text = "Print Menu";
            this.printMenuToolStripMenuItem.Click += new System.EventHandler(this.printMenuToolStripMenuItem_Click);
            // 
            // rezervariToolStripMenuItem
            // 
            this.rezervariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRezervareToolStripMenuItem});
            this.rezervariToolStripMenuItem.Name = "rezervariToolStripMenuItem";
            this.rezervariToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.rezervariToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rezervariToolStripMenuItem.Text = "&Rezervari";
            this.rezervariToolStripMenuItem.Click += new System.EventHandler(this.comenziToolStripMenuItem_Click);
            // 
            // adaugaRezervareToolStripMenuItem
            // 
            this.adaugaRezervareToolStripMenuItem.Name = "adaugaRezervareToolStripMenuItem";
            this.adaugaRezervareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.adaugaRezervareToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.adaugaRezervareToolStripMenuItem.Text = "&Adauga Rezervare";
            this.adaugaRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem_Click);
            // 
            // meseToolStripMenuItem
            // 
            this.meseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaMasaToolStripMenuItem,
            this.modificaMasaToolStripMenuItem,
            this.eliminaMasaToolStripMenuItem});
            this.meseToolStripMenuItem.Name = "meseToolStripMenuItem";
            this.meseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.meseToolStripMenuItem.Text = "Mese";
            // 
            // adaugaMasaToolStripMenuItem
            // 
            this.adaugaMasaToolStripMenuItem.Name = "adaugaMasaToolStripMenuItem";
            this.adaugaMasaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.adaugaMasaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.adaugaMasaToolStripMenuItem.Text = "&Adauga Masa";
            this.adaugaMasaToolStripMenuItem.Click += new System.EventHandler(this.adaugaMasaToolStripMenuItem_Click);
            // 
            // modificaMasaToolStripMenuItem
            // 
            this.modificaMasaToolStripMenuItem.Name = "modificaMasaToolStripMenuItem";
            this.modificaMasaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modificaMasaToolStripMenuItem.Text = "Modifica Masa";
            this.modificaMasaToolStripMenuItem.Click += new System.EventHandler(this.modificaMasaToolStripMenuItem_Click);
            // 
            // eliminaMasaToolStripMenuItem
            // 
            this.eliminaMasaToolStripMenuItem.Name = "eliminaMasaToolStripMenuItem";
            this.eliminaMasaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.eliminaMasaToolStripMenuItem.Text = "Elimina Masa";
            this.eliminaMasaToolStripMenuItem.Click += new System.EventHandler(this.eliminaMasaToolStripMenuItem_Click);
            // 
            // lbMese
            // 
            this.lbMese.FormattingEnabled = true;
            this.lbMese.Location = new System.Drawing.Point(24, 419);
            this.lbMese.Name = "lbMese";
            this.lbMese.Size = new System.Drawing.Size(183, 108);
            this.lbMese.TabIndex = 5;
            this.lbMese.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbOspatari
            // 
            this.lbOspatari.FormattingEnabled = true;
            this.lbOspatari.Location = new System.Drawing.Point(24, 282);
            this.lbOspatari.Name = "lbOspatari";
            this.lbOspatari.Size = new System.Drawing.Size(183, 108);
            this.lbOspatari.TabIndex = 6;
            this.lbOspatari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbOspatari_MouseDown);
            // 
            // cmMese
            // 
            this.cmMese.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.cmMese.Name = "cmMese";
            this.cmMese.Size = new System.Drawing.Size(122, 70);
            this.cmMese.Opening += new System.ComponentModel.CancelEventHandler(this.cmMese_Opening);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // errMasaOcupata
            // 
            this.errMasaOcupata.ContainerControl = this;
            // 
            // rezervariDataSet
            // 
            this.rezervariDataSet.DataSetName = "RezervariDataSet";
            this.rezervariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervariDataSetBindingSource
            // 
            this.rezervariDataSetBindingSource.DataSource = this.rezervariDataSet;
            this.rezervariDataSetBindingSource.Position = 0;
            // 
            // rezervareBindingSource
            // 
            this.rezervareBindingSource.DataMember = "Rezervare";
            this.rezervareBindingSource.DataSource = this.rezervariDataSetBindingSource;
            // 
            // rezervareTableAdapter
            // 
            this.rezervareTableAdapter.ClearBeforeFill = true;
            // 
            // rezervareBindingSource1
            // 
            this.rezervareBindingSource1.DataMember = "Rezervare";
            this.rezervareBindingSource1.DataSource = this.rezervariDataSetBindingSource;
            // 
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNume,
            this.chNrPers,
            this.chTel,
            this.chData});
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(24, 27);
            this.lvRezervari.MultiSelect = false;
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(722, 225);
            this.lvRezervari.TabIndex = 7;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            this.lvRezervari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 97;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume Client";
            this.chNume.Width = 90;
            // 
            // chNrPers
            // 
            this.chNrPers.Text = "Numar Persoane";
            this.chNrPers.Width = 67;
            // 
            // chTel
            // 
            this.chTel.Text = "Nr Telefon";
            // 
            // chData
            // 
            this.chData.Text = "Data si Ora";
            this.chData.Width = 134;
            // 
            // pGfPreturi
            // 
            this.pGfPreturi.Location = new System.Drawing.Point(237, 282);
            this.pGfPreturi.Name = "pGfPreturi";
            this.pGfPreturi.Size = new System.Drawing.Size(879, 245);
            this.pGfPreturi.TabIndex = 8;
            this.pGfPreturi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pGfPreturi.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(21, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ospatari";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pGfPreturi);
            this.Controls.Add(this.lvRezervari);
            this.Controls.Add(this.lbOspatari);
            this.Controls.Add(this.lbMese);
            this.Controls.Add(this.tvMeseComenzi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmMese.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMasaOcupata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvMeseComenzi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem salvareInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaMasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaMasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaMasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restaurareDinFisierToolStripMenuItem;
        private System.Windows.Forms.ListBox lbMese;
        private System.Windows.Forms.ListBox lbOspatari;
        private System.Windows.Forms.ContextMenuStrip cmMese;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errMasaOcupata;
        private System.Windows.Forms.BindingSource rezervariDataSetBindingSource;
        private RezervariDataSet rezervariDataSet;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private RezervariDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
        private System.Windows.Forms.BindingSource rezervareBindingSource1;
        private System.Windows.Forms.ListView lvRezervari;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chNrPers;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salvareMenuInFisierTXTToolStripMenuItem;
        private System.Windows.Forms.Panel pGfPreturi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

