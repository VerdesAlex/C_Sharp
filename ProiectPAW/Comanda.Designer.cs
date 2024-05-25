namespace ProiectPAW
{
    partial class Creeare_Comanda
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataRezervare = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.tbNrPers = new System.Windows.Forms.TextBox();
            this.errNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNrPers = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPMP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNrPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPMP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(232, 68);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 0;
            this.tbNume.Leave += new System.EventHandler(this.tbNume_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numar telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numar de Persoane";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(232, 222);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(200, 20);
            this.tbTel.TabIndex = 7;
            this.tbTel.Leave += new System.EventHandler(this.tbTel_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Rezervarii";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtDataRezervare
            // 
            this.dtDataRezervare.Location = new System.Drawing.Point(232, 293);
            this.dtDataRezervare.MinDate = new System.DateTime(2024, 5, 20, 0, 0, 0, 0);
            this.dtDataRezervare.Name = "dtDataRezervare";
            this.dtDataRezervare.Size = new System.Drawing.Size(200, 20);
            this.dtDataRezervare.TabIndex = 9;
            this.dtDataRezervare.ValueChanged += new System.EventHandler(this.dtDataRezervare_ValueChanged);
            this.dtDataRezervare.Leave += new System.EventHandler(this.dtDataRezervare_Leave);
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.Location = new System.Drawing.Point(43, 435);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(123, 47);
            this.btnAdaugaComanda.TabIndex = 10;
            this.btnAdaugaComanda.Text = "Plaseaza comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = true;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnuleaza.Location = new System.Drawing.Point(297, 435);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(108, 47);
            this.btnAnuleaza.TabIndex = 11;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // tbNrPers
            // 
            this.tbNrPers.Location = new System.Drawing.Point(232, 144);
            this.tbNrPers.Name = "tbNrPers";
            this.tbNrPers.Size = new System.Drawing.Size(200, 20);
            this.tbNrPers.TabIndex = 13;
            this.tbNrPers.TextChanged += new System.EventHandler(this.tbNrPers_TextChanged);
            this.tbNrPers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrPers_KeyPress);
            this.tbNrPers.Leave += new System.EventHandler(this.tbNrPers_Leave);
            // 
            // errNume
            // 
            this.errNume.ContainerControl = this;
            // 
            // errNrPers
            // 
            this.errNrPers.ContainerControl = this;
            // 
            // errDate
            // 
            this.errDate.ContainerControl = this;
            // 
            // errPMP
            // 
            this.errPMP.ContainerControl = this;
            // 
            // Creeare_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 522);
            this.Controls.Add(this.tbNrPers);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.dtDataRezervare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNume);
            this.Name = "Creeare_Comanda";
            this.Text = "Creeare_Comanda";
            this.Load += new System.EventHandler(this.Creeare_Comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNrPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataRezervare;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.TextBox tbNrPers;
        private System.Windows.Forms.ErrorProvider errNume;
        private System.Windows.Forms.ErrorProvider errNrPers;
        private System.Windows.Forms.ErrorProvider errDate;
        private System.Windows.Forms.ErrorProvider errPMP;
    }
}