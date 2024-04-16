namespace Seminar_9_BDD
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
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anAbsolvireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Seminar_9_BDD.TestDataSet();
            this.mediciTableAdapter = new Seminar_9_BDD.TestDataSetTableAdapters.MediciTableAdapter();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.testDataSet1 = new Seminar_9_BDD.TestDataSet1();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new Seminar_9_BDD.TestDataSet1TableAdapters.PacientiTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePrenumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zileRamaseDeTraitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPacienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numePrenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.anAbsolvireDataGridViewTextBoxColumn,
            this.specializareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mediciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.Width = 150;
            // 
            // anAbsolvireDataGridViewTextBoxColumn
            // 
            this.anAbsolvireDataGridViewTextBoxColumn.DataPropertyName = "AnAbsolvire";
            this.anAbsolvireDataGridViewTextBoxColumn.HeaderText = "AnAbsolvire";
            this.anAbsolvireDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.anAbsolvireDataGridViewTextBoxColumn.Name = "anAbsolvireDataGridViewTextBoxColumn";
            this.anAbsolvireDataGridViewTextBoxColumn.Width = 150;
            // 
            // specializareDataGridViewTextBoxColumn
            // 
            this.specializareDataGridViewTextBoxColumn.DataPropertyName = "Specializare";
            this.specializareDataGridViewTextBoxColumn.HeaderText = "Specializare";
            this.specializareDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specializareDataGridViewTextBoxColumn.Name = "specializareDataGridViewTextBoxColumn";
            this.specializareDataGridViewTextBoxColumn.Width = 150;
            // 
            // mediciBindingSource
            // 
            this.mediciBindingSource.DataMember = "Medici";
            this.mediciBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediciTableAdapter
            // 
            this.mediciTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(139, 591);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(140, 112);
            this.btnSalveaza.TabIndex = 1;
            this.btnSalveaza.Text = "Salveaza Medic";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.numePrenumeDataGridViewTextBoxColumn1,
            this.dataNasteriiDataGridViewTextBoxColumn1,
            this.cNPDataGridViewTextBoxColumn1,
            this.boalaDataGridViewTextBoxColumn,
            this.zileRamaseDeTraitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pacientiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(139, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1145, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.testDataSet1;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // numePrenumeDataGridViewTextBoxColumn1
            // 
            this.numePrenumeDataGridViewTextBoxColumn1.DataPropertyName = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn1.HeaderText = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.numePrenumeDataGridViewTextBoxColumn1.Name = "numePrenumeDataGridViewTextBoxColumn1";
            this.numePrenumeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataNasteriiDataGridViewTextBoxColumn1
            // 
            this.dataNasteriiDataGridViewTextBoxColumn1.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn1.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataNasteriiDataGridViewTextBoxColumn1.Name = "dataNasteriiDataGridViewTextBoxColumn1";
            this.dataNasteriiDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cNPDataGridViewTextBoxColumn1
            // 
            this.cNPDataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cNPDataGridViewTextBoxColumn1.Name = "cNPDataGridViewTextBoxColumn1";
            this.cNPDataGridViewTextBoxColumn1.Width = 150;
            // 
            // boalaDataGridViewTextBoxColumn
            // 
            this.boalaDataGridViewTextBoxColumn.DataPropertyName = "Boala";
            this.boalaDataGridViewTextBoxColumn.HeaderText = "Boala";
            this.boalaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.boalaDataGridViewTextBoxColumn.Name = "boalaDataGridViewTextBoxColumn";
            this.boalaDataGridViewTextBoxColumn.Width = 150;
            // 
            // zileRamaseDeTraitDataGridViewTextBoxColumn
            // 
            this.zileRamaseDeTraitDataGridViewTextBoxColumn.DataPropertyName = "ZileRamaseDeTrait";
            this.zileRamaseDeTraitDataGridViewTextBoxColumn.HeaderText = "ZileRamaseDeTrait";
            this.zileRamaseDeTraitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.zileRamaseDeTraitDataGridViewTextBoxColumn.Name = "zileRamaseDeTraitDataGridViewTextBoxColumn";
            this.zileRamaseDeTraitDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnPacienti
            // 
            this.btnPacienti.Location = new System.Drawing.Point(1144, 591);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(140, 112);
            this.btnPacienti.TabIndex = 3;
            this.btnPacienti.Text = "Salveaza Pacient";
            this.btnPacienti.UseVisualStyleBackColor = true;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 853);
            this.Controls.Add(this.btnPacienti);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource mediciBindingSource;
        private TestDataSetTableAdapters.MediciTableAdapter mediciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anAbsolvireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.DataGridView dataGridView2;
        private TestDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private TestDataSet1TableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zileRamaseDeTraitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPacienti;
    }
}

