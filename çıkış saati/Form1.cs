using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çıkış_saati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = comboBox1.SelectedIndex;
            if (indeks == 0 || indeks == 1 || indeks == 2)
            {
                lblsonuc.Text = "çıkış saati .16:40";
               
            }
            else if (indeks == 3 || indeks == 4)
            {
                lblsonuc.Text = "çıkış saati.15:50";

            }
            else
            {
                lblsonuc.Text = "tatil.";
            }
        }
    }
}
