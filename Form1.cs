using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVacation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Country.SelectedIndex = 0;
            summer.Checked = true;


        }

        private void days_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void Sum_price_Click(object sender, EventArgs e)
        {
            double Sum;
            if (days.Text != "")
            {
                Sum = Convert.ToDouble(days.Text);
                if (Country.SelectedIndex == 0)
                {
                    if (summer.Checked == true)
                    {
                        Sum *= 100;
                    }
                    else
                    {
                        Sum *= 150;
                    }
                }
                else if (Country.SelectedIndex == 1)
                {
                    if (summer.Checked == true)
                    {
                        Sum *= 160;
                    }
                    else
                    {
                        Sum *= 200;
                    }
                }
                if (Country.SelectedIndex == 2)
                {
                    if (summer.Checked == true)
                    {
                        Sum *= 120;
                    }
                    else
                    {
                        Sum *= 180;
                    }
                }
                if (Gid.Checked == true)
                {
                    Sum += (Convert.ToDouble(days.Text) * 50);
                }
                TotalPrice.Text = (Convert.ToString(Sum) + " $");
            }
            else
            {
                TotalPrice.Text = "0";
            }
        }

        /*
private void Country_Click(object sender, EventArgs e)
{
  if(Country.SelectedIndex == 0)
  {
      picture.Image = System.Drawing.Image.FromFile("Bolgar.jpg");
  }
  else if(Country.SelectedIndex == 1)
  {
      picture.Image = System.Drawing.Image.FromFile("Deutch.jpg");
  }
  else if(Country.SelectedIndex == 2)
  {
      picture.Image = System.Drawing.Image.FromFile("Polan.jpg");
  }
}*/
    }
}
