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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(120, 9);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoSaude.Location = new System.Drawing.Point(16, 112);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(119, 24);
            this.ckbPlanoSaude.TabIndex = 3;
            this.ckbPlanoSaude.Text = "Plano Saude";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(219, 63);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalarioFolha.TabIndex = 4;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Items.AddRange(new object[] {
            "Clube A - 100",
            "Clube B - 50",
            "Clube C - 30"});
            this.cbbClubeLazer.Location = new System.Drawing.Point(19, 176);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(116, 21);
            this.cbbClubeLazer.TabIndex = 5;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(19, 153);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(116, 20);
            this.lblClubeLazer.TabIndex = 6;
            this.lblClubeLazer.Text = "Clube de Lazer";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(12, 207);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 44);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(124, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 44);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(236, 207);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 44);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(217, 154);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiquido.TabIndex = 11;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(189, 108);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(141, 20);
            this.lblImpostoRenda.TabIndex = 13;
            this.lblImpostoRenda.Text = "Imposto de Renda";
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Location = new System.Drawing.Point(223, 131);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(107, 20);
            this.txtImpostoRenda.TabIndex = 14;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(222, 177);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(107, 20);
            this.txtSalarioLiquido.TabIndex = 16;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Location = new System.Drawing.Point(223, 86);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(107, 20);
            this.txtSalarioFolha.TabIndex = 17;
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(124, 34);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(95, 20);
            this.dtpDataFolha.TabIndex = 18;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 63);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 19;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 86);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(119, 20);
            this.txtSalario.TabIndex = 20;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 263);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.lblDataFolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFluxoCaixa";
            this.Text = "frmFluxoCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
    }
}