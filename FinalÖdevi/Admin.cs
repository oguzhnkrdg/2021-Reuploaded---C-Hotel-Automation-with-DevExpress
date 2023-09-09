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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox1.Text;
                string sifre = textBox2.Text;
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Admin where Id='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form1 giris = new Form1();
                    giris.Show();
                }
                else
                {
                    MessageBox.Show("ID ya da Şifre yanlış");
                }

                con.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
    }
}
