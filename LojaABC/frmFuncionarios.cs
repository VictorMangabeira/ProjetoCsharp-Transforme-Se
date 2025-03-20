using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFuncionarios()
        {
            InitializeComponent();
            //desabilitar os campos
            desabilitarCampos();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        //Desabilitando os campos
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCpf.Enabled = false;
            dtpDataNacimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbSexo.Enabled = false;

            txtLougradouro.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            cbbUf.Enabled = false;
            txtComplemento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;


        }

        //Habilitar  os campos
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCpf.Enabled = true;
            dtpDataNacimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLougradouro.Enabled = true;
            txtNumero.Enabled = true;
            mskCep.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            cbbUf.Enabled = true;
            txtComplemento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtNome.Focus();


        }

        //Limpando os campos
        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Clear();
            dtpDataNacimento.Text = "";
            mskCelular.Clear();

            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            rdbNaoDesejoInforma.Checked = false;


            txtLougradouro.Clear();
            txtNumero.Clear();
            mskCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            cbbUf.Items.Clear();
            txtComplemento.Clear();
            
            txtNome.Focus();


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //executando habilitar campos
            habilitarCampos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando limpar campos
            limparCampos();
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || txtLougradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtComplemento.Text.Equals("") || txtCidade.Text.Equals("") || txtEstado.Text.Equals("") || mskCep.Text.Equals("     -") || cbbUf.Text.Equals(""))
            {
                MessageBox.Show(" Favor preencher os campos!!! ");
            }
            else 
            {
                MessageBox.Show("Cadastrado com sucesso!!!");
                limparCampos();
                desabilitarCampos();
            }
        }
    }
}
