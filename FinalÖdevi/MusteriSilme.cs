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
    public partial class MusteriSilme : Form
    {
        public MusteriSilme()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        void Goster()
        {
            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Musteriler", bag);

            adtr.Fill(dtst, "Musteriler");

            dataGridView1.DataSource = dtst.Tables["Musteriler"];

            adtr.Dispose();

            bag.Close();
        }
        private void MusteriSilme_Load(object sender, EventArgs e)
        {
            Goster();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Seçili Müşteriyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                    OleDbCommand komut = new OleDbCommand();
                    con.Open();
                    komut.Connection = con;
                    komut.CommandText = "DELETE FROM Musteriler WHERE TcNo=@TcNo";
                    komut.Parameters.AddWithValue("@TcNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MusteriSilme a = new MusteriSilme();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
    }
}