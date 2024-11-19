using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Izracunaj_Click(object sender, EventArgs e)
        {

            double duljina = double.Parse(textBoxDuljina.Text);
            double struja = double.Parse(textBoxStruja.Text);
            double magpolje = double.Parse(textBoxMagPolje.Text);
            double kut = double.Parse(textBoxKut.Text);


            double sila = struja * duljina * magpolje * kut;


            textBoxRezultat.Text = $"Magnetska sila: {sila} N";
        }

    
    }
}

