namespace ProiectPAW
{
    partial class FormMasa
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
            this.lbNrLoc = new System.Windows.Forms.Label();
            this.tbIdMasa = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.cbNrLocuri = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNrLoc
            // 
            this.lbNrLoc.AutoSize = true;
            this.lbNrLoc.Location = new System.Drawing.Point(54, 107);
            this.lbNrLoc.Name = "lbNrLoc";
            this.lbNrLoc.Size = new System.Drawing.Size(70, 13);
            this.lbNrLoc.TabIndex = 0;
            this.lbNrLoc.Text = "Numar Locuri";
            // 
            // tbIdMasa
            // 
            this.tbIdMasa.Location = new System.Drawing.Point(212, 52);
            this.tbIdMasa.Name = "tbIdMasa";
            this.tbIdMasa.Size = new System.Drawing.Size(100, 20);
            this.tbIdMasa.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(54, 52);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(45, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Id Masa";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(57, 203);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 47);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "button1";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.Red;
            this.btnAnuleaza.Location = new System.Drawing.Point(237, 203);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 47);
            this.btnAnuleaza.TabIndex = 5;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // cbNrLocuri
            // 
            this.cbNrLocuri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNrLocuri.FormattingEnabled = true;
            this.cbNrLocuri.Items.AddRange(new object[] {
            "Doua",
            "Patru",
            "Sase",
            "Opt"});
            this.cbNrLocuri.Location = new System.Drawing.Point(212, 107);
            this.cbNrLocuri.Name = "cbNrLocuri";
            this.cbNrLocuri.Size = new System.Drawing.Size(100, 21);
            this.cbNrLocuri.TabIndex = 6;
            this.cbNrLocuri.SelectedIndexChanged += new System.EventHandler(this.cbNrLocuri_SelectedIndexChanged);
            this.cbNrLocuri.SelectionChangeCommitted += new System.EventHandler(this.cbNrLocuri_SelectionChangeCommitted);
            this.cbNrLocuri.SelectedValueChanged += new System.EventHandler(this.cbNrLocuri_SelectedValueChanged);
            this.cbNrLocuri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNrLocuri_KeyPress);
            this.cbNrLocuri.MouseLeave += new System.EventHandler(this.cbNrLocuri_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 333);
            this.Controls.Add(this.cbNrLocuri);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbIdMasa);
            this.Controls.Add(this.lbNrLoc);
            this.Name = "FormMasa";
            this.Text = "FormMasa";
            this.Load += new System.EventHandler(this.FormMasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNrLoc;
        private System.Windows.Forms.TextBox tbIdMasa;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ComboBox cbNrLocuri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}