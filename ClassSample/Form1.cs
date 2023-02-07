using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automobiles;

namespace ClassSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TEST CHANGES GITHUB
        private void btnToyota_Click(object sender, EventArgs e)
        {
            car toyota = new car();

            toyota.Name = "Toyota";
            toyota.Model = "Corolla";
            toyota.Color = "Red";
            toyota.Variant = "2.0V";

            toyota.Details = "Toyota|Corolla|Red|2.0V";

            string desc = toyota.getCarDescription(toyota.Name);
            string[] details = toyota.Details.Split('|');

            //lblDisplay.Text = toyota.Name + " - " + toyota.Model + " - " + toyota.Color + " - " + desc;

            lblDisplay.Text = details[0] + " - " + details[1] + " - " + details[2] + " - " + details[3];
        }

        private void btnMitsubishi_Click(object sender, EventArgs e)
        {
            car mitsubishi = new car();

            mitsubishi.Name = "Mitsubishi";
            mitsubishi.Model = "Expander";
            mitsubishi.Color = "Blue";
            mitsubishi.Variant = "GLS";

            string desc = mitsubishi.getCarDescription(mitsubishi.Name);

            lblDisplay.Text = mitsubishi.Name + " - " + mitsubishi.Model + " - " + mitsubishi.Color + " - " + desc;

        }

        private void btnYamaha_Click(object sender, EventArgs e)
        {
            motorcycle yamaha = new motorcycle();

            yamaha.Name = "Yamaha";
            yamaha.Model = "NMax";
            yamaha.Color = "Black";
            yamaha.Cylinder = "250CC";

            lblDisplay.Text = yamaha.Name + " - " + yamaha.Model + " - " + yamaha.Color + " - " + yamaha.Cylinder;
        }
    }
}
