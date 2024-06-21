using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class DokuSanatGalerisi : Form
    {
        public DokuSanatGalerisi()
        {
            InitializeComponent();
        }

        private void DokuSanatGalerisi_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DokuSanatGalerisiHakkında();
            nextForm.Show();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DokuSanatGalerisiSanatçıları();
            nextForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DokuSanatGalerisiSergileri();
            nextForm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Anasayfa();
            nextForm.Show();
            this.Close();
        }
    }
}
