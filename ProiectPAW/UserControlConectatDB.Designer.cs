namespace ProiectPAW
{
    partial class UserControlConectatDB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezervariDataSet = new ProiectPAW.RezervariDataSet();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new ProiectPAW.RezervariDataSetTableAdapters.RezervareTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPersoaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSiOraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeClientDataGridViewTextBoxColumn,
            this.nrPersoaneDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.dataSiOraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rezervariDataSet
            // 
            this.rezervariDataSet.DataSetName = "RezervariDataSet";
            this.rezervariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervareBindingSource
            // 
            this.rezervareBindingSource.DataMember = "Rezervare";
            this.rezervareBindingSource.DataSource = this.rezervariDataSet;
            // 
            // rezervareTableAdapter
            // 
            this.rezervareTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeClientDataGridViewTextBoxColumn
            // 
            this.numeClientDataGridViewTextBoxColumn.DataPropertyName = "Nume_Client";
            this.numeClientDataGridViewTextBoxColumn.HeaderText = "Nume_Client";
            this.numeClientDataGridViewTextBoxColumn.Name = "numeClientDataGridViewTextBoxColumn";
            // 
            // nrPersoaneDataGridViewTextBoxColumn
            // 
            this.nrPersoaneDataGridViewTextBoxColumn.DataPropertyName = "Nr_Persoane";
            this.nrPersoaneDataGridViewTextBoxColumn.HeaderText = "Nr_Persoane";
            this.nrPersoaneDataGridViewTextBoxColumn.Name = "nrPersoaneDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // dataSiOraDataGridViewTextBoxColumn
            // 
            this.dataSiOraDataGridViewTextBoxColumn.DataPropertyName = "DataSiOra";
            this.dataSiOraDataGridViewTextBoxColumn.HeaderText = "DataSiOra";
            this.dataSiOraDataGridViewTextBoxColumn.Name = "dataSiOraDataGridViewTextBoxColumn";
            // 
            // UserControlConectatDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlConectatDB";
            this.Size = new System.Drawing.Size(737, 343);
            this.Load += new System.EventHandler(this.UserControlConectatDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPersoaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSiOraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private RezervariDataSet rezervariDataSet;
        private RezervariDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
    }
}
