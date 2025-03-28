using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public void limparCampos()
        {
            txtSalario.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();
            txtImpostoRenda.Clear();
            ckbPlanoSaude.Checked = false;
            cbbClubeLazer.Text = "";
            txtSalario.Focus();
        }
        public void desabilitarCampos()
        {
            txtSalarioFolha.Enabled = false;
            txtImpostoRenda.Enabled = false;
            txtSalarioLiquido.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)


        {
            double salarioFolha, impostoRenda = 0, salarioLiquido = 0;

            try
            {
                salarioFolha = Convert.ToDouble(txtSalarioFolha.Text);



                if (salarioFolha < 2259.20)
                {
                    salarioLiquido = salarioFolha;
                }
                else if (salarioFolha >= 2259.21 && salarioFolha <= 2826.65)
                {
                    impostoRenda = salarioFolha * 7.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));
                }
                else if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
                {
                    impostoRenda = salarioFolha * 15 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));
                }
                else if (salarioFolha >= 3751.06 && salarioFolha <= 4664.68)
                {
                    impostoRenda = salarioFolha * 22.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));

                }
                else if (salarioFolha >= 4664.69)
                {
                    impostoRenda = salarioFolha * 27.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));
                }

                if (ckbPlanoSaude.Checked)
                {
                    salarioLiquido = salarioLiquido - 200;
                }
                if (cbbClubeLazer.SelectedIndex == 0)
                {
                    salarioLiquido = salarioLiquido - 100;
                }
                if (cbbClubeLazer.SelectedIndex == 1)
                {
                    salarioLiquido = salarioLiquido - 50;
                }
                if (cbbClubeLazer.SelectedIndex == 2)
                {
                    salarioLiquido = salarioLiquido - 30;
                }

                txtImpostoRenda.Text = impostoRenda.ToString();
                txtSalarioLiquido.Text = salarioLiquido.ToString();



            }catch (Exception)
            {
                MessageBox.Show("Favor insireir salário  validos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            }

       
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }


        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }
    }
}
