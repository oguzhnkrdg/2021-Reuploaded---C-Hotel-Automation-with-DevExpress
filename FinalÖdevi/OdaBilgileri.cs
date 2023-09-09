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
    public partial class OdaBilgileri : Form
    {
        public OdaBilgileri()
        {
            InitializeComponent();
        }
        void oda1boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA1' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label13.Text = dr["Durum"].ToString();
            }
            if (label13.Text == "Boş")
            {
                pictureBox1.BackColor = Color.Green;
            }
        }
        void oda1dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA1' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label13.Text = dr["Durum"].ToString();
            }
            if (label13.Text == "Dolu")
            {
                pictureBox1.BackColor = Color.Red;
            }
        }
        void oda2boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA2' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label14.Text = dr["Durum"].ToString();
            }
            if (label14.Text == "Boş")
            {
                pictureBox2.BackColor = Color.Green;
            }
        }
        void oda2dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA2' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label14.Text = dr["Durum"].ToString();
            }
            if (label14.Text == "Dolu")
            {
                pictureBox2.BackColor = Color.Red;
            }
        }
        void oda3boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA3' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label15.Text = dr["Durum"].ToString();
            }
            if (label15.Text == "Boş")
            {
                pictureBox3.BackColor = Color.Green;
            }
        }
        void oda3dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA3' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label15.Text = dr["Durum"].ToString();
            }
            if (label15.Text == "Dolu")
            {
                pictureBox3.BackColor = Color.Red;
            }
        }
        void oda4boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA4' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label16.Text = dr["Durum"].ToString();
            }
            if (label16.Text == "Boş")
            {
                pictureBox4.BackColor = Color.Green;
            }
        }
        void oda4dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA4' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label16.Text = dr["Durum"].ToString();
            }
            if (label16.Text == "Dolu")
            {
                pictureBox4.BackColor = Color.Red;
            }
        }
        void oda5boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA5' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label17.Text = dr["Durum"].ToString();
            }
            if (label17.Text == "Boş")
            {
                pictureBox5.BackColor = Color.Green;
            }
        }
        void oda5dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA5' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label17.Text = dr["Durum"].ToString();
            }
            if (label17.Text == "Dolu")
            {
                pictureBox5.BackColor = Color.Red;
            }
        }
        void oda6boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA6' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label18.Text = dr["Durum"].ToString();
            }
            if (label18.Text == "Boş")
            {
                pictureBox6.BackColor = Color.Green;
            }
        }
        void oda6dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA6' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label18.Text = dr["Durum"].ToString();
            }
            if (label18.Text == "Dolu")
            {
                pictureBox6.BackColor = Color.Red;
            }
        }
        void oda7boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA7' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label19.Text = dr["Durum"].ToString();
            }
            if (label19.Text == "Boş")
            {
                pictureBox7.BackColor = Color.Green;
            }
        }
        void oda7dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA7' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label19.Text = dr["Durum"].ToString();
            }
            if (label19.Text == "Dolu")
            {
                pictureBox7.BackColor = Color.Red;
            }
        }
        void oda8boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA8' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label20.Text = dr["Durum"].ToString();
            }
            if (label20.Text == "Boş")
            {
                pictureBox8.BackColor = Color.Green;
            }
        }
        void oda8dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA8' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label20.Text = dr["Durum"].ToString();
            }
            if (label20.Text == "Dolu")
            {
                pictureBox8.BackColor = Color.Red;
            }
        }
        void oda9boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA9' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label21.Text = dr["Durum"].ToString();
            }
            if (label21.Text == "Boş")
            {
                pictureBox9.BackColor = Color.Green;
            }
        }
        void oda9dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA9' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label21.Text = dr["Durum"].ToString();
            }
            if (label21.Text == "Dolu")
            {
                pictureBox9.BackColor = Color.Red;
            }
        }
        void oda10boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA10' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label22.Text = dr["Durum"].ToString();
            }
            if (label22.Text == "Boş")
            {
                pictureBox10.BackColor = Color.Green;
            }
        }
        void oda10dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA10' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label22.Text = dr["Durum"].ToString();
            }
            if (label22.Text == "Dolu")
            {
                pictureBox10.BackColor = Color.Red;
            }
        }
        void oda11boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA11' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label23.Text = dr["Durum"].ToString();
            }
            if (label23.Text == "Boş")
            {
                pictureBox11.BackColor = Color.Green;
            }
        }
        void oda11dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA11' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label23.Text = dr["Durum"].ToString();
            }
            if (label23.Text == "Dolu")
            {
                pictureBox11.BackColor = Color.Red;
            }
        }
        void oda12boş()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA12' and Durum='Boş' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label24.Text = dr["Durum"].ToString();
            }
            if (label14.Text == "Boş")
            {
                pictureBox12.BackColor = Color.Green;
            }
        }
        void oda12dolu()
        {
            OleDbCommand komut;
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
            string sorgu = "Select Durum from Odadurumlari where Odalar='ODA12' and Durum='Dolu' ";
            komut = new OleDbCommand(sorgu, connect);
            connect.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label24.Text = dr["Durum"].ToString();
            }
            if (label24.Text == "Dolu")
            {
                pictureBox12.BackColor = Color.Red;
            }
        }
        private void OdaBilgileri_Load(object sender, EventArgs e)
        {
            oda1boş();
            oda1dolu();
            oda2boş();
            oda2dolu();
            oda3boş();
            oda3dolu();

            oda4boş();
            oda4dolu();
            oda5boş();
            oda5dolu();
            oda6boş();
            oda6dolu();

            oda7boş();
            oda7dolu();
            oda8boş();
            oda8dolu();
            oda9boş();
            oda9dolu();

            oda10boş();
            oda10dolu();
            oda11boş();
            oda11dolu();
            oda12boş();
            oda12dolu();
        }
    }
}

