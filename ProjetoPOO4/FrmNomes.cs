using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPOO4
{
    public partial class FrmNomes : Form
    {

        string name, lastName, fullName;
        Operations op = new Operations();

        public FrmNomes()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBName.Text == "")
                {
                    MessageBox.Show("Digite seu nome.", "Nome em branco");
                }
                else
                {
                    name = textBName.Text;
                    lastName = textBLastName.Text;
                    fullName = op.nameForename(name, lastName);
                    MessageBox.Show(fullName, "Bem vindo(a)!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nome inválido.", "Nome inválido");
                textBName.Focus();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanFields();
        }

        private void cleanFields()
        {
            textBName.Clear();
            textBLastName.Clear();
            textBName.Focus();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }
    }
}
