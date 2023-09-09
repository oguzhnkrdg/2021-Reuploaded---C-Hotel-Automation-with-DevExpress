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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                OleDbCommand cmd = new OleDbCommand();
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "insert into Gelir (Acıklama,Tutar,Tarih) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "')";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Gelir Kaydedildi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                OleDbCommand cmd = new OleDbCommand();
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "insert into Gider (Acıklama,Tutar,Tarih) values ('" + textBox4.Text + "','" + textBox3.Text + "','" + dateTimePicker2.Value + "')";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Gider Kaydedildi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
    }
}
