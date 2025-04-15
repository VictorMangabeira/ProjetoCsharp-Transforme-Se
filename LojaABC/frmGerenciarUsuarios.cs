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
using MySql.Data.MySqlClient;

namespace LojaABC
{
    public partial class frmGerenciarUsuarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public int codFunc = 0;

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
            codFunc = buscarCodigoFuncionarios();
        }

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        //Limpando os campos
        public void limparCampos()
        {

            txtUsuario.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();

            txtCodigo.Focus();

        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }


        //Habilitar  os campos
        public void habilitarCampor()
        {

            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtCodigo.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampor();
        }

        public int cadastrarUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome,senha,codFunc)valeus(@nome,@senha,@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarString, 30).Value = txtUsuario.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarString, 12).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        public int buscarCodigoFuncionarios()
        {
            int codFunc = 0;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbFuncionarios.Items.Add(DR.GetString(1));
                codFunc = DR.GetInt32(0);
            }


            Conexao.fecharConexao();
            return codFunc;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals("") || txtRepetirSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor prencher os campos!!");
            }


            if (cadastrarUsuario(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show(" Cadastrado com sucesso!!! ");
                limparCampos();
                desabilitarCampos();
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!!!");
            }


        }

        private void cbbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            pesquisaUsuarioFuncionario(codFunc);
        }

        public void pesquisaUsuarioFuncionario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.codUsu, usu.nome, usu.senha from tbUsuarios as usu inner join tbFuncionarios as func on usu.codFunc = func.codFunc where func.codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;
            comm.Connection = Conexao.obterConexao();
            
            
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);

            Conexao.fecharConexao();

        }
    }
}
