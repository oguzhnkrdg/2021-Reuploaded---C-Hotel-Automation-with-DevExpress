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
    public partial class MusteriGirisi : Form
    {
        public MusteriGirisi()
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
                cmd.CommandText = "insert into Musteriler (TcNo,Ad,Soyad,Cinsiyet,Telefon,Adres,Gtarihi,Ctarihi,Ucret) values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Müşteri Girişi Tamamlandı");
                cmd.CommandText = ("update Odadurumlari set Durum='Dolu' where Odalar='" + comboBox2.Text + "'");



                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                OleDbCommand komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = ("update Odadurumlari set Durum='Dolu' where Odalar='" + comboBox2.Text + "'");
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime bTarih = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime kTarih = Convert.ToDateTime(dateTimePicker2.Text);
                TimeSpan Sonuc = kTarih - bTarih;
                label12.Text = Sonuc.TotalDays.ToString();
                int gun = int.Parse(label12.Text);
                int fiyat = 50;
                textBox4.Text = (gun * fiyat).ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void MusteriGirisi_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Odadurumlari where Durum='Boş'";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["Odalar"]).ToString();

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
