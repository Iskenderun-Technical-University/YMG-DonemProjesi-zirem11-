using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            frmsoru1 sr1 = new frmsoru1();
            sr1.Show();
            this.Hide();
        }
    }
}
