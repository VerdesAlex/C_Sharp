using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medici_Pacienti_DB
{
    public partial class Form1 : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
        DataSet DSMedici = new DataSet();

        string SelectComand = " select * from dbo.medici";

        public Form1()
        {
            InitializeComponent();
            IncarcaDate();
        }

        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectComand, conexiune);
            adaptor.Fill(DSMedici, "Medici");
            DSMedici.Tables["Medici"].PrimaryKey = new DataColumn[1]
                   { DSMedici.Tables["Medici"].Columns["Id"]};
            conexiune.Close();

            comboBox1.DataSource = DSMedici.Tables["Medici"];
            comboBox1.DisplayMember = "NumePrenume";
            comboBox1.ValueMember = "Id";

            tbNumePrenume.DataBindings.Add("Text", DSMedici.Tables["Medici"], "NumePrenume");
            tbCNP.DataBindings.Add("Text", DSMedici.Tables["Medici"], "Cnp");
            tbAnAbsolvire.DataBindings.Add("Text", DSMedici.Tables["Medici"], "AnAbsolvire");
            tbSpecializa.DataBindings.Add("Text", DSMedici.Tables["Medici"], "Specializa");

            dtpDataNasterii.DataBindings.Add("Value", DSMedici.Tables["Medici"], "DataNasterii");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Medici' table. You can move, or remove it, as needed.
            this.mediciTableAdapter.Fill(this.testDataSet.Medici);

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mediciBindingSource.EndEdit();
                this.mediciTableAdapter.Update(this.testDataSet.Medici);
                MessageBox.Show("Salvare cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnAbsolvire_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumePrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //pt o sg inregistrare

            BindingManagerBase legatura = BindingContext[DSMedici.Tables["Medici"]];
            legatura.EndCurrentEdit();

            string UpdateComand = "update dbo.medici set NumePrenume=@NumePrenume, DataNasterii=@DataNasterii, Cnp=@Cnp, AnAbsolvire=@AnAbsolvire, "
                +"Specializa=@Specializa where Id=@Id";

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter(SelectComand, stringConexiune);
            adaptor.UpdateCommand = conexiune.CreateCommand();
            adaptor.UpdateCommand.CommandText = UpdateComand;
            adaptor.UpdateCommand.Parameters.AddWithValue("@NumePrenume", tbNumePrenume.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Cnp", tbCNP.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@AnAbsolvire", tbAnAbsolvire.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Specializa", tbSpecializa.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@DataNasterii", dtpDataNasterii.Value);

            int Id=Int32.Parse(comboBox1.SelectedValue.ToString());

            adaptor.UpdateCommand.Parameters.AddWithValue("@Id", Id);

            DataSet DSMediciModificari = DSMedici.GetChanges(DataRowState.Modified);
            if(DSMediciModificari != null)
            {
                try
                {
                    int i = adaptor.Update(DSMediciModificari, "Medici");
                    MessageBox.Show("Au fost actualizate " + i + " linii");
                    DSMedici.AcceptChanges();
                }

                catch(Exception ex)
                {
                    
                }
            }
            conexiune.Close();
       }

        private void mediciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
