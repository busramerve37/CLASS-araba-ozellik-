using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba bmw;


        private void button1_Click(object sender, EventArgs e)
        {
            bmw.Hizlan();
            label1.Text = bmw.BilgiYazdir();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmw = new Araba("BMW", "5.20İ");
            label1.Text=bmw.BilgiYazdir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmw.Yavasla();
            label1.Text = bmw.BilgiYazdir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bmw.KornaCal());
        }
    }
}
