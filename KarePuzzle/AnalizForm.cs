using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KarePuzzle
{
    public partial class AnalizForm : Form
    {
        public AnalizForm()
        {
            InitializeComponent();
        }
        OleDbConnection bag2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/usersdb.mdb");

        private void AnalizForm_Load(object sender, EventArgs e)
        {
           
            OleDbCommand cmd = new OleDbCommand("Select * From Users ", bag2);
            bag2.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable veriler = new DataTable();
            da.Fill(veriler);
            bag2.Close();
            dataGridView1.DataSource = veriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
