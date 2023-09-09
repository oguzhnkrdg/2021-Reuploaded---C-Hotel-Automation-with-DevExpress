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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                connect.Open();
                OleDbCommand cmd = new OleDbCommand("Select sum(Tutar) as Toplam from Gelir", connect);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = dr["Toplam"].ToString();
                }



                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                conn.Open();
                OleDbCommand komut = new OleDbCommand("Select sum(Tutar) as Toplam from Gider", conn);
                OleDbDataReader rd = komut.ExecuteReader();
                while (rd.Read())
                {
                    label2.Text = rd["Toplam"].ToString();
                }


                this.chart1.Series["Gelir"].Points.AddY(label1.Text);
                this.chart1.Series["Gider"].Points.AddY(label2.Text);
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
    }
}
