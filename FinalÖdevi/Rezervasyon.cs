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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");

        DataSet dtst = new DataSet();

        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            try
            {
                bag.Open();

                OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Rezervasyon", bag);

                adtr.Fill(dtst, "Rezervasyon");

                dataGridView1.DataSource = dtst.Tables["Rezervasyon"];

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
