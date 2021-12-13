using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int val;
            if (!int.TryParse(number1Text7.Text,out val) || !int.TryParse(number2Text2.Text, out val))
            {
                MessageBox.Show("Please enter Number.");
                return;
            }

            //burada yaptıgım hata ilk olarak index alip gormememden kaynaklandi. item vs index ayrimina dikkat etmek gerekiyor
            switch (comboBoxProcess.Text)
            {
                case "+":
                    {
                        resultLabel6.Text = ( (Convert.ToInt32(number1Text7.Text)) + (Convert.ToInt32(number2Text2.Text))).ToString() ; 
                        break;
                    }
                case "-":
                    {

                        resultLabel6.Text = ((int.Parse(number1Text7.Text)) - (int.Parse(number2Text2.Text))).ToString();
                        break;
                    }
                case "*":
                    {

                        resultLabel6.Text = ((int.Parse(number1Text7.Text)) * (int.Parse(number2Text2.Text))).ToString();
                        break;
                    }
                default:
                    {
                        resultLabel6.Text = ((double.Parse(number1Text7.Text)) / (double.Parse(number2Text2.Text))).ToString();
                        break;
                    }
            }
        }
    }
}
