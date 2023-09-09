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
    public partial class OdaBosalt : Form
    {
        public OdaBosalt()
        {
            InitializeComponent();
        }
        
        void DoluOdalar()
        {
            OleDbCommand cmd;
            OleDbDataReader dr;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Odalar FROM Odadurumlari where Durum='Dolu' ";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Odalar"]).ToString();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                OleDbCommand komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = ("update Odadurumlari set Durum='Boş' where Odalar='" + comboBox1.Text + "'");
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("İşlem Başarıyla Tamamlanmıştır");
            }
            catch (Exception hata) 
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void OdaBosalt_Load(object sender, EventArgs e)
        {
            DoluOdalar();
        }
    }
}
