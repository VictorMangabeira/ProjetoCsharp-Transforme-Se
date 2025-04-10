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
using System.ServiceModel.Channels;

namespace LojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
            
        }
        public void desabilitarCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //execuntando o métado limpar campos
            limparCampos();
        }

        //habilitar campos

        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }
        public void limparCampos()
        {
            //criando o método limpar campos
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;

            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;


        }
        public void limparCampos_Pesquisar()
        {
            //criando o método limpar campos pesquisar
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;


        }

        //criando o métado para pesquisar por codigo 

        public void pesquisarPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Add(DR.GetString(0));


            Conexao.fecharConexao();

        }

        public void pesquiserPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where nome like '%"+descricao+"%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            

            while (DR.Read())
            {
                ltbPesquisar.Items.Add((DR.GetString(0)));
            }

            

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                //mensagem se não estiver prenchido
                MessageBox.Show(" Favor preencher o campo!!! ");
                txtDescricao.Focus();
            }
            else
            {
                // ltbPesquisar.Items.Clear();
                //ltbPesquisar.Items.Add(txtDescricao.Text);
                //limparCampos_Pesquisar();

                if (rdbCodigo.Checked)
                {
                    // ltbPesquisar.Items.Clear();
                    pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                    //limparCampos_Pesquisar();
                }
                if (rdbNome.Checked)
                {
                    pesquiserPorNome(txtDescricao.Text);
                }
            }
               
            
            
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisar.SelectedItem.ToString();
            frmFuncionarios abrir = new frmFuncionarios(descricao);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();
        }
    }
}
