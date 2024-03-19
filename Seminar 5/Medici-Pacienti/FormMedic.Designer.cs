namespace Medici_Pacienti
{
    partial class FormMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbAnAbs = new System.Windows.Forms.TextBox();
            this.dateDataNastere = new System.Windows.Forms.DateTimePicker();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "An absolvire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specializare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Nasterii";
            // 
            // cbSpec
            // 
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Items.AddRange(new object[] {
            "Pediatrie",
            "Oftalmologie",
            "Ontologie",
            "Psihiatrie"});
            this.cbSpec.Location = new System.Drawing.Point(318, 347);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(304, 28);
            this.cbSpec.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(318, 73);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(304, 26);
            this.tbNume.TabIndex = 6;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(318, 159);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(304, 26);
            this.tbCNP.TabIndex = 7;
            // 
            // tbAnAbs
            // 
            this.tbAnAbs.Location = new System.Drawing.Point(318, 251);
            this.tbAnAbs.Name = "tbAnAbs";
            this.tbAnAbs.Size = new System.Drawing.Size(304, 26);
            this.tbAnAbs.TabIndex = 8;
            // 
            // dateDataNastere
            // 
            this.dateDataNastere.Location = new System.Drawing.Point(318, 449);
            this.dateDataNastere.Name = "dateDataNastere";
            this.dateDataNastere.Size = new System.Drawing.Size(304, 26);
            this.dateDataNastere.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(163, 627);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(117, 43);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRenunta.Location = new System.Drawing.Point(451, 627);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(117, 43);
            this.btnRenunta.TabIndex = 11;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = false;
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 775);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dateDataNastere);
            this.Controls.Add(this.tbAnAbs);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            this.Load += new System.EventHandler(this.FormMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbAnAbs;
        private System.Windows.Forms.DateTimePicker dateDataNastere;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnRenunta;
    }
}