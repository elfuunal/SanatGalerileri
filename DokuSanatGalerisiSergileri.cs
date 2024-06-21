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
    public partial class DokuSanatGalerisiSergileri : Form
    {
        public DokuSanatGalerisiSergileri()
        {
            InitializeComponent();
        }

        private void DokuSanatGalerisiSergileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DSG_yazkarmasergisi();
            nextForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DSG_suluboyasergisi();
            nextForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DSG_yolculuğumkendime();
            nextForm.Show();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DSG_marekbrzozowskisergisi();
            nextForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new DSG_KeremKirazResimSergisi();
            nextForm.Show();
        }

       
    }
}
