using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyunlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BilgiYarismasi_Click(object sender, EventArgs e)
        {
            Form2 bilgiYarismasi = new Form2();
            bilgiYarismasi.Show();
            this.Hide();
        }
    }
}
