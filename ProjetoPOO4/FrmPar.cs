using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPOO4
{
    public partial class FrmPar : Form
    {
        public FrmPar()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                textBResult.Clear();
                verticalCentered();
                int num = int.Parse(textBNumber.Text);
                if (num % 2 == 0)
                {
                    textBResult.Text += "O número é par.";
                    textBResult.ForeColor = Color.Green;
                }
                else
                {
                    textBResult.Text += "O número é ímpar.";
                    textBResult.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numérico para realizar o cálculo", "Valor inválido");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanFields();
        }

        private void cleanFields()
        {
            textBNumber.Clear();
            textBResult.Clear();
            textBNumber.Focus();
        }

        private void verticalCentered()
        {
            textBResult.TextAlign = HorizontalAlignment.Center;
            int a = textBResult.Size.Height;
            float c = textBResult.Font.Height;
            for (int i = 0; i < (int)(a / c) / 3; i++)
            {
                textBResult.Text += "\r\n";
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void textBNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
