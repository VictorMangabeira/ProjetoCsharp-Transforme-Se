namespace FolhaPagamento
{
    partial class frmFluxoCaixa
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
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.ckaPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblFolhaSalario = new System.Windows.Forms.Label();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(12, 21);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 190);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(12, 213);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(99, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // ckaPlanoSaude
            // 
            this.ckaPlanoSaude.AutoSize = true;
            this.ckaPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckaPlanoSaude.Location = new System.Drawing.Point(19, 284);
            this.ckaPlanoSaude.Name = "ckaPlanoSaude";
            this.ckaPlanoSaude.Size = new System.Drawing.Size(119, 24);
            this.ckaPlanoSaude.TabIndex = 3;
            this.ckaPlanoSaude.Text = "Plano Saude";
            this.ckaPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // lblFolhaSalario
            // 
            this.lblFolhaSalario.AutoSize = true;
            this.lblFolhaSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolhaSalario.Location = new System.Drawing.Point(254, 55);
            this.lblFolhaSalario.Name = "lblFolhaSalario";
            this.lblFolhaSalario.Size = new System.Drawing.Size(102, 20);
            this.lblFolhaSalario.TabIndex = 4;
            this.lblFolhaSalario.Text = "Salário Folha";
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Location = new System.Drawing.Point(12, 371);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(116, 21);
            this.cbbClubeLazer.TabIndex = 5;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(12, 348);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(116, 20);
            this.lblClubeLazer.TabIndex = 6;
            this.lblClubeLazer.Text = "Clube de Lazer";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(248, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.lblFolhaSalario);
            this.Controls.Add(this.ckaPlanoSaude);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Name = "frmFluxoCaixa";
            this.Text = "frmFluxoCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox ckaPlanoSaude;
        private System.Windows.Forms.Label lblFolhaSalario;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Button btnCalcular;
    }
}