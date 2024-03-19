namespace Medici_Pacienti
{
    partial class Form1
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
            this.lbMedici = new System.Windows.Forms.ListBox();
            this.tbMedic = new System.Windows.Forms.TextBox();
            this.lvMedici = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAplicatie = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedici = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDespreApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMedici
            // 
            this.lbMedici.FormattingEnabled = true;
            this.lbMedici.ItemHeight = 20;
            this.lbMedici.Items.AddRange(new object[] {
            "Medic Ionescu",
            "Medic Popescu"});
            this.lbMedici.Location = new System.Drawing.Point(909, 466);
            this.lbMedici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMedici.MultiColumn = true;
            this.lbMedici.Name = "lbMedici";
            this.lbMedici.Size = new System.Drawing.Size(198, 104);
            this.lbMedici.TabIndex = 0;
            this.lbMedici.SelectedIndexChanged += new System.EventHandler(this.lbMedici_SelectedIndexChanged);
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(13, 466);
            this.tbMedic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(808, 26);
            this.tbMedic.TabIndex = 1;
            // 
            // lvMedici
            // 
            this.lvMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chCNP,
            this.chAn,
            this.chSpecializare,
            this.chDatan});
            this.lvMedici.FullRowSelect = true;
            this.lvMedici.HideSelection = false;
            this.lvMedici.Location = new System.Drawing.Point(13, 79);
            this.lvMedici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvMedici.Name = "lvMedici";
            this.lvMedici.Size = new System.Drawing.Size(808, 330);
            this.lvMedici.TabIndex = 2;
            this.lvMedici.UseCompatibleStateImageBehavior = false;
            this.lvMedici.View = System.Windows.Forms.View.Details;
            this.lvMedici.SelectedIndexChanged += new System.EventHandler(this.lvMedici_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 120;
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            this.chCNP.Width = 200;
            // 
            // chAn
            // 
            this.chAn.Text = "An absolvire";
            this.chAn.Width = 120;
            // 
            // chSpecializare
            // 
            this.chSpecializare.Text = "Specilizare";
            this.chSpecializare.Width = 120;
            // 
            // chDatan
            // 
            this.chDatan.Text = "DataNasterii";
            this.chDatan.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicatie,
            this.menuMedici,
            this.menuDespreApp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAplicatie
            // 
            this.menuAplicatie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.menuAplicatie.Name = "menuAplicatie";
            this.menuAplicatie.Size = new System.Drawing.Size(89, 38);
            this.menuAplicatie.Text = "Fisiere";
            this.menuAplicatie.Click += new System.EventHandler(this.menuAplicatie_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // menuMedici
            // 
            this.menuMedici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.menuMedici.Name = "menuMedici";
            this.menuMedici.Size = new System.Drawing.Size(93, 38);
            this.menuMedici.Text = "Medici";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // menuDespreApp
            // 
            this.menuDespreApp.Name = "menuDespreApp";
            this.menuDespreApp.Size = new System.Drawing.Size(182, 38);
            this.menuDespreApp.Text = "Despre Aplicatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 692);
            this.Controls.Add(this.lvMedici);
            this.Controls.Add(this.tbMedic);
            this.Controls.Add(this.lbMedici);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMedici;
        private System.Windows.Forms.TextBox tbMedic;
        private System.Windows.Forms.ListView lvMedici;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chAn;
        private System.Windows.Forms.ColumnHeader chSpecializare;
        private System.Windows.Forms.ColumnHeader chDatan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAplicatie;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMedici;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDespreApp;
    }
}

