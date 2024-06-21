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
    public partial class GallerySoyutSergileri : Form
    {
        public GallerySoyutSergileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new GS_artcontactsergisi();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new GS_Figüryorumsergisi();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new GS_düşyanıkları();
            nextForm.Show();
        }
    }
}
