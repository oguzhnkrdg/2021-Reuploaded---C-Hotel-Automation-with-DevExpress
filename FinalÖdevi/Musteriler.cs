using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalÖdevi
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");

        DataSet dtst = new DataSet();

        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void Musteriler_Load(object sender, EventArgs e)
        {
            try
            {
                bag.Open();

                OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Musteriler", bag);

                adtr.Fill(dtst, "Musteriler");

                dataGridView1.DataSource = dtst.Tables["Musteriler"];

                adtr.Dispose();

                bag.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString()) ;
            }
        }
    }
}
