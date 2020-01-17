using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pricing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pricer p = new Pricer(Double.Parse(tb_stockPrice.Text), Double.Parse(tb_strikePrice.Text), FractionToDecimal(tb_timeToMaturity.Text), Double.Parse(tb_standardDeviation.Text), Double.Parse(tb_risk.Text));
                l_call.Text = "call : " + p.getCall().ToString();
                l_put.Text = "put : " + p.getPut().ToString();
                l_d1.Text = "d1 : " + Math.Round(p.getD1(), 4);
                l_d2.Text = "d2 : " + Math.Round(p.getD2(), 4);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erreur de saisie");
            }
        }


        /// <summary>
        /// Convert a fraction text to decimal value
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double FractionToDecimal(String input)
        {
            if (input.Contains("/"))
            {
                String[] fraction = input.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                if (fraction.Length != 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Int32 numerator, denominator;
                if (Int32.TryParse(fraction[0], out numerator) && Int32.TryParse(fraction[1], out denominator))
                {
                    if (denominator == 0)
                    {
                        throw new InvalidOperationException("Divide by 0 occurred");
                    }
                    return (double)numerator / denominator;
                }
                throw new ArgumentException();
            }
            else
            {
                return Double.Parse(input);
            }
        }


        /// <summary>
        /// check the input value to accept only decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_stockPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_stockPrice.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// check the input value to accept only decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_strikePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_strikePrice.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// check the input value to accept only decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_timeToMaturity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_timeToMaturity.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 47)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// check the input value to accept only decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_standardDeviation_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_standardDeviation.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// check the input value to accept only decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>tb_risk_KeyPress(object sender, KeyPressEventArgs e)
        private void tb_risk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_risk.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
    }
}
