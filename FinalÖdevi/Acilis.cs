using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalÖdevi
{
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }

        private void Acilis_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Admin giris = new Admin();
                giris.Show();
               
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
