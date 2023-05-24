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
    public partial class frmsoru1 : Form
    {
        public frmsoru1()
        {
            InitializeComponent();
        }

        private void frmsoru1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0; int dogru = 0; int yanlis = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            soruno++;
            lblsoruno.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "Yazıyı icat eden ilk çağ uygarlığı hangisidir?";
                btnA.Text = "Hititler";
                btnB.Text = "Uygurlar";
                btnC.Text = "Sümerler";
                btnD.Text = "Urartular";
            }

            

            if (soruno== 2)
            {
                richTextBox1.Text = "İstiklal Marşımızın bestecisi kimdir?";
                btnA.Text = "Osman Zeki Güngör";
                btnB.Text = "Mehmet Akif Ersoy";
                btnC.Text = "Yahya Kemal Beyatlı";
                btnD.Text = "Hamdullah Suphi Tanrıöver";
            }


            if (soruno == 3)
            {
                richTextBox1.Text = "5 sayısının türevi nedir?";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "0";
            }


            if (soruno == 4)
            {
                richTextBox1.Text = "Akşam namazı kaç rekattır?";
                btnA.Text = "4";
                btnB.Text = "10";
                btnC.Text = "5";
                btnD.Text = "13";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Rusya'nın cumhurbaşkanı kimdir?";
                btnA.Text = "Vladimir Putin";
                btnB.Text = "Emmanuel Macron";
                btnC.Text = " Sergio Mattarella";
                btnD.Text = "Dina Boluarte";
            }

           










        }
    }
}
