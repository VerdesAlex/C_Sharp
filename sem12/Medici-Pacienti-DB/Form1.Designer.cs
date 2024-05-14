namespace Medici_Pacienti_DB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePrenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anAbsolvireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Medici_Pacienti_DB.testDataSet();
            this.mediciTableAdapter = new Medici_Pacienti_DB.testDataSetTableAdapters.MediciTableAdapter();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbNumePrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbAnAbsolvire = new System.Windows.Forms.TextBox();
            this.tbSpecializa = new System.Windows.Forms.TextBox();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numePrenumeDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn,
            this.anAbsolvireDataGridViewTextBoxColumn,
            this.specializaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mediciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // numePrenumeDataGridViewTextBoxColumn
            // 
            this.numePrenumeDataGridViewTextBoxColumn.DataPropertyName = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.HeaderText = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numePrenumeDataGridViewTextBoxColumn.Name = "numePrenumeDataGridViewTextBoxColumn";
            this.numePrenumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "Cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.Width = 150;
            // 
            // anAbsolvireDataGridViewTextBoxColumn
            // 
            this.anAbsolvireDataGridViewTextBoxColumn.DataPropertyName = "AnAbsolvire";
            this.anAbsolvireDataGridViewTextBoxColumn.HeaderText = "AnAbsolvire";
            this.anAbsolvireDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.anAbsolvireDataGridViewTextBoxColumn.Name = "anAbsolvireDataGridViewTextBoxColumn";
            this.anAbsolvireDataGridViewTextBoxColumn.Width = 150;
            // 
            // specializaDataGridViewTextBoxColumn
            // 
            this.specializaDataGridViewTextBoxColumn.DataPropertyName = "Specializa";
            this.specializaDataGridViewTextBoxColumn.HeaderText = "Specializa";
            this.specializaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specializaDataGridViewTextBoxColumn.Name = "specializaDataGridViewTextBoxColumn";
            this.specializaDataGridViewTextBoxColumn.Width = 150;
            // 
            // mediciBindingSource
            // 
            this.mediciBindingSource.DataMember = "Medici";
            this.mediciBindingSource.DataSource = this.testDataSet;
            this.mediciBindingSource.CurrentChanged += new System.EventHandler(this.mediciBindingSource_CurrentChanged);
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediciTableAdapter
            // 
            this.mediciTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(65, 229);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(115, 29);
            this.btnSalveaza.TabIndex = 1;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediciBindingSource, "NumePrenume", true));
            this.textBox1.Location = new System.Drawing.Point(186, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediciBindingSource, "Cnp", true));
            this.textBox2.Location = new System.Drawing.Point(368, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 26);
            this.textBox2.TabIndex = 3;
            // 
            // tbNumePrenume
            // 
            this.tbNumePrenume.Location = new System.Drawing.Point(102, 714);
            this.tbNumePrenume.Name = "tbNumePrenume";
            this.tbNumePrenume.Size = new System.Drawing.Size(251, 26);
            this.tbNumePrenume.TabIndex = 4;
            this.tbNumePrenume.TextChanged += new System.EventHandler(this.tbNumePrenume_TextChanged);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(861, 714);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(251, 26);
            this.tbCNP.TabIndex = 5;
            this.tbCNP.TextChanged += new System.EventHandler(this.tbCNP_TextChanged);
            // 
            // tbAnAbsolvire
            // 
            this.tbAnAbsolvire.Location = new System.Drawing.Point(1262, 714);
            this.tbAnAbsolvire.Name = "tbAnAbsolvire";
            this.tbAnAbsolvire.Size = new System.Drawing.Size(251, 26);
            this.tbAnAbsolvire.TabIndex = 6;
            this.tbAnAbsolvire.TextChanged += new System.EventHandler(this.tbAnAbsolvire_TextChanged);
            // 
            // tbSpecializa
            // 
            this.tbSpecializa.Location = new System.Drawing.Point(1682, 714);
            this.tbSpecializa.Name = "tbSpecializa";
            this.tbSpecializa.Size = new System.Drawing.Size(251, 26);
            this.tbSpecializa.TabIndex = 7;
            this.tbSpecializa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dtpDataNasterii
            // 
            this.dtpDataNasterii.Location = new System.Drawing.Point(457, 713);
            this.dtpDataNasterii.Name = "dtpDataNasterii";
            this.dtpDataNasterii.Size = new System.Drawing.Size(247, 26);
            this.dtpDataNasterii.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 779);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 91);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update_curenta";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(409, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2071, 893);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDataNasterii);
            this.Controls.Add(this.tbSpecializa);
            this.Controls.Add(this.tbAnAbsolvire);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNumePrenume);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource mediciBindingSource;
        private testDataSetTableAdapters.MediciTableAdapter mediciTableAdapter;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anAbsolvireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbNumePrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbAnAbsolvire;
        private System.Windows.Forms.TextBox tbSpecializa;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

