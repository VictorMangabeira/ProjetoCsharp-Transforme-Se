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
//importando a bliblioteca do banco de dados
using MySql.Data.MySqlClient;
using MosaicoSolutions.ViaCep;


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
            //executando desabilitar os campos
            desabilitarCampos();
        }

        public frmFuncionarios(string descricao)
        {
            InitializeComponent();
            //executando desabilitar os campos
            desabilitarCampos();
            txtNome.Text = descricao;
            habilitarCampos_Pesquisar();
            pesquisarPorNome(txtNome.Text);
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
            txtBairro.Enabled = false;
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
            txtBairro.Enabled = true;
            cbbUf.Enabled = true;
            txtComplemento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtNome.Focus();


        }

        //Habilitar  os campos apos pesquisa
        public void habilitarCampos_Pesquisar()
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
            txtBairro.Enabled = true;
            cbbUf.Enabled = true;
            txtComplemento.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
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
            txtBairro.Clear();
            cbbUf.Text = "";
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

        //pesquisar por nome
        public void pesquisarPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCpf.Text = DR.GetString(3);
            dtpDataNacimento.Value = DR.GetDateTime(4);
            mskCelular.Text = DR.GetString(5);
            string sexo = DR.GetString(6);
            if (sexo == "F")
            {
                rdbFeminino.Checked = true;
            }
            if (sexo == "M")
            {
                rdbMasculino.Checked = true;
            }
            if (sexo == "N")
            {
                rdbNaoDesejoInforma.Checked = true;
            }

            txtLougradouro.Text = DR.GetString(7);
            mskCep.Text = DR.GetString(8);
            txtNumero.Text = DR.GetString(9);
            txtComplemento.Text = DR.GetString(10);
            txtBairro.Text = DR.GetString(11);
            txtCidade.Text = DR.GetString(12);
            cbbUf.Text = DR.GetString(13);

            Conexao.fecharConexao();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //checagem se os campos estão prenchidos
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || txtLougradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtComplemento.Text.Equals("") || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") || mskCep.Text.Equals("     -") || cbbUf.Text.Equals(""))
            {
                //mensagem se não estiver prenchido
                MessageBox.Show(" Favor preencher os campos!!! ");
            }
            else
            {
                if (cadastrarFuncionario() == 1)
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
        }

        public int cadastrarFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome, email, cpf, dataNasc, telcel, sexo, logradouro, cep, numero, complemento, bairro, cidade, uf) values(@nome, @email, @cpf, @dataNasc, @telcel, @sexo, @logradouro, @cep, @numero, @complemento, @bairro, @cidade, @uf)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCpf.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dtpDataNacimento.Value;
            comm.Parameters.Add("@telcel", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rdbNaoDesejoInforma.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }
            comm.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLougradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUf.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        public void buscaCEP(string cep)
        {
            var viaCepService = ViaCepService.Default();
            try
            {
                var endereco = viaCepService.ObterEndereco(mskCep.Text);

                txtLougradouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                cbbUf.Text = endereco.UF;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir o  CEP válido");
                mskCep.Clear();
                mskCep.Focus();

            }
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCep.Text);
                txtNumero.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //checagem se os campos estão prenchidos
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || txtLougradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtComplemento.Text.Equals("") || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") || mskCep.Text.Equals("     -") || cbbUf.Text.Equals(""))
            {
                //mensagem se não estiver prenchido
                MessageBox.Show(" Favor preencher os campos!!! ");
            }
            else
            {
                if (alterarFuncionarios(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show(" Alterado com sucesso!!! ");
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Alterar!!!");
                }

            }
        }

        //alterando registros

        public int alterarFuncionarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome = @nome, email = @email, cpf = @cpf, dataNasc = @dataNasc, telcel = @telcel, sexo = @sexo, logradouro = @logradouro, cep = @cep, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf where codFunc = codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCpf.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dtpDataNacimento.Value;
            comm.Parameters.Add("@telcel", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rdbNaoDesejoInforma.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }
            comm.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLougradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUf.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();


            Conexao.fecharConexao();

            return resp;
        }

        //excluir registros dos funcionarios

        public int excluirFuncionarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));
                limparCampos();
            }
            else
            {

            }
        }
    }
}
