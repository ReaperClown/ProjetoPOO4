namespace ProjetoPOO4
{
    partial class FrmPar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBNumber = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBNumber
            // 
            this.textBNumber.Location = new System.Drawing.Point(168, 89);
            this.textBNumber.Name = "textBNumber";
            this.textBNumber.Size = new System.Drawing.Size(100, 29);
            this.textBNumber.TabIndex = 1;
            this.textBNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBNumber_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Teal;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(97, 171);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 32);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(257, 171);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(82, 32);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número para identificar se é par ou ímpar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBResult
            // 
            this.textBResult.BackColor = System.Drawing.Color.LightGray;
            this.textBResult.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBResult.Location = new System.Drawing.Point(12, 271);
            this.textBResult.Multiline = true;
            this.textBResult.Name = "textBResult";
            this.textBResult.ReadOnly = true;
            this.textBResult.Size = new System.Drawing.Size(418, 177);
            this.textBResult.TabIndex = 4;
            // 
            // FrmPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(442, 460);
            this.Controls.Add(this.textBResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textBNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Par ou Ímpar?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBNumber;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBResult;
    }
}