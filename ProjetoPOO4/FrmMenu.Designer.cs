namespace ProjetoPOO4
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.label1.Size = new System.Drawing.Size(284, 47);
            this.label1.TabIndex = 9999;
            this.label1.Text = "Menu Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint_1);
            // 
            // btnPar
            // 
            this.btnPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(204)))), ((int)(((byte)(219)))));
            this.btnPar.FlatAppearance.BorderSize = 0;
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPar.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPar.ForeColor = System.Drawing.Color.White;
            this.btnPar.Location = new System.Drawing.Point(67, 81);
            this.btnPar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(153, 70);
            this.btnPar.TabIndex = 0;
            this.btnPar.Text = "Par ou Ímpar?";
            this.btnPar.UseVisualStyleBackColor = false;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(204)))), ((int)(((byte)(219)))));
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMulti.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(67, 183);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(153, 70);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "É múltiplo de 5?";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnNames
            // 
            this.btnNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(204)))), ((int)(((byte)(219)))));
            this.btnNames.FlatAppearance.BorderSize = 0;
            this.btnNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNames.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNames.ForeColor = System.Drawing.Color.White;
            this.btnNames.Location = new System.Drawing.Point(67, 281);
            this.btnNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(153, 70);
            this.btnNames.TabIndex = 2;
            this.btnNames.Text = "Exibir nome";
            this.btnNames.UseVisualStyleBackColor = false;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(108, 400);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(282, 464);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - POO4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnClose;
    }
}
