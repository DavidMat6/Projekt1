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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Izracunaj_Click(object sender, EventArgs e)
        {
            double snaga = double.Parse(textBoxSnaga.Text); 
            double vrijeme = double.Parse(textBoxVrijeme.Text); 

            
            double energija = (snaga * vrijeme) / 1000; 

            
            labelRezultat.Text = "Ukupna energija: " + energija.ToString("F2") + " kWh";
        }
    }
}
