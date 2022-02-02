using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO4
{
    public partial class FrmMenu : Form
    {
        bool quit;
        FrmConfirmation confirm = new FrmConfirmation();
        public FrmMenu()
        {
            InitializeComponent();

            // Desenha a borda nos filhos
            HashSet<Control> parents = new HashSet<Control>();

            // Os controles que receberão a borda, separados por , --> typeof(NomeDoControle)
            var controlsThatHaveBorder = new Type[] { typeof(Button) };

            foreach (Control item in GetAllControls(Controls))
            {
                // Adicionar exceção ao controle que não estiver em controlsThatHaveBorder
                if (!controlsThatHaveBorder.Contains(item.GetType())) continue;

                // Redesenha o controle quando ganha ou perde foco
                item.GotFocus += (s, e) => ((Control)s).Parent.Invalidate();
                item.LostFocus += (s, e) => ((Control)s).Parent.Invalidate();

                parents.Add(item.Parent);
            }

            foreach (var parent in parents)
            {
                parent.Paint += (sender, e) =>
                {
                    // Não desenhar nada se este não for parente do controle ativo
                    if (ActiveControl.Parent != sender) return;

                    // Cria vínculo de bordas
                    var bounds = ActiveControl.Bounds;
                    var activeCountrolBounds = new Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 1, bounds.Height + 1);

                    // Desenha a borda
                    ((Control)sender).CreateGraphics().DrawRectangle(Pens.DarkBlue, activeCountrolBounds);
                };
            }
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            FrmPar parImpar = new FrmPar();
            parImpar.ShowDialog();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnNames_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            confirm.ShowDialog();
            quit = confirm.leaveConfirmation();

            if (quit == true)
            {
                this.Close();
            }
        }

        public static List<Control> GetAllControls(IList controls)
        {
            List<Control> controlsCollectorList = new List<Control>();
            foreach (Control control in controls)
            {
                controlsCollectorList.Add(control);
                List<Control> SubControls = GetAllControls(control.Controls);
                controlsCollectorList.AddRange(SubControls);
            }
            return controlsCollectorList;
        }

        private void label1_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }
    }
}
