namespace ProiectPAW
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNrLocuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(436, 51);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(331, 195);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.rezervariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareInFisierToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "&Fisiere";
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
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chID,
            this.chNrLocuri,
            this.chDT});
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(12, 51);
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(399, 195);
            this.lvRezervari.TabIndex = 3;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            this.lvRezervari.SelectedIndexChanged += new System.EventHandler(this.lvRezervari_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume Client";
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chNrLocuri
            // 
            this.chNrLocuri.Text = "Nr Locuri";
            // 
            // chDT
            // 
            this.chDT.Text = "Data si Ora Rezervarii";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // salvareInFisierToolStripMenuItem
            // 
            this.salvareInFisierToolStripMenuItem.Name = "salvareInFisierToolStripMenuItem";
            this.salvareInFisierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareInFisierToolStripMenuItem.Text = "Salvare in fisier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRezervari);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem;
        private System.Windows.Forms.ListView lvRezervari;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNrLocuri;
        private System.Windows.Forms.ColumnHeader chDT;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareInFisierToolStripMenuItem;
    }
}

