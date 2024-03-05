using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColoniaDePescadores
{
    public partial class Colaboradores : UserControl
    {
        public Colaboradores()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Seção de variáveis
            string NOME = txbNome.Text, CPF = txbCPF.Text, DATA_NASCIMENTO = txbDataNascimento.Text, RG = txbRG.Text, NACIONALIDADE = comboBoxNacionalidade.Text, SEXO = comboBoxSexo.Text, LOGIN = txbLogin.Text, SENHA = txbSenha.Text;

            if (txbNome.Text != "" && txbCPF.Text != "" && txbDataNascimento.Text != "" && txbRG.Text != "" && comboBoxNacionalidade.Text != "" && comboBoxSexo.Text != "" && txbLogin.Text != "" && txbSenha.Text != "")
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var sqlCadastrarFun = "insert into Usuarios_login (NOME, CPF, DATA_DE_NASCIMENTO, RG, NACIONALIDADE, RESULTADOSEXO, LOGIN_Funcionario, SENHA_Funcionario) values (@NOME, @CPF, @DATA_NASCIMENTO, @RG, @NACIONALIDADE, @SEXO, @LOGIN, @SENHA)";
                        using (SqlCommand cmd = new SqlCommand(sqlCadastrarFun, conexao))
                        {
                            cmd.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = NOME;
                            cmd.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = CPF;
                            cmd.Parameters.Add("@DATA_NASCIMENTO", System.Data.SqlDbType.VarChar).Value = DATA_NASCIMENTO;
                            cmd.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = RG;
                            cmd.Parameters.Add("@NACIONALIDADE", System.Data.SqlDbType.VarChar).Value = NACIONALIDADE;
                            cmd.Parameters.Add("@SEXO", System.Data.SqlDbType.VarChar).Value = SEXO;
                            cmd.Parameters.Add("@LOGIN", System.Data.SqlDbType.VarChar).Value = LOGIN;
                            cmd.Parameters.Add("@SENHA", System.Data.SqlDbType.VarChar).Value = SENHA;

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Cadastro realizado com sucesso!","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            LimparCampos();
                            btnCancelar.Enabled = false;
                            btnSalvar.Enabled = false;
                            DesabilitaCampos();
                            btnNovo.Enabled = true;
                        }
                    }
                }catch (SqlException erro) 
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{erro}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos antes de salvar o formulário.","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DesabilitaCampos()
        {
            txbNome.Enabled = false;
            txbCPF.Enabled = false;
            txbDataNascimento.Enabled = false;
            txbRG.Enabled = false;
            comboBoxNacionalidade.Enabled = false;
            comboBoxSexo.Enabled = false;
            txbLogin.Enabled = false;
            txbSenha.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            radioButtonAtivo.Enabled = false;
            radioButtonInativo.Enabled = false;
            dataGridViewFuncionarios.Visible = false;
        }

        private void HabilitaCampos()
        {
            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbDataNascimento.Enabled = true;
            txbRG.Enabled = true;
            comboBoxNacionalidade.Enabled = true;
            comboBoxSexo.Enabled = true;
            txbLogin.Enabled = true;
            txbSenha.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            radioButtonAtivo.Enabled = true;
            radioButtonInativo.Enabled = true;
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbDataNascimento.Enabled = true;
            txbRG.Enabled = true;
            comboBoxNacionalidade.Enabled = true;
            comboBoxSexo.Enabled = true;
            txbLogin.Enabled = true;
            txbSenha.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            radioButtonAtivo.Enabled = true;
            radioButtonInativo.Enabled = true;
            btnNovo.Enabled = false;
            txbPesquisarFuncionario.Text = string.Empty;
        }

        private void LimparCampos()
        {
            txbNome.Text = string.Empty;
            txbCPF.Text = string.Empty;
            txbDataNascimento.Text = string.Empty;
            txbRG.Text = string.Empty;
            comboBoxNacionalidade.Text = string.Empty;
            comboBoxSexo.Text = string.Empty;
            txbLogin.Text = string.Empty;
            txbSenha.Text = string.Empty;
            radioButtonAtivo.Enabled = false;
            radioButtonInativo.Enabled = false;
            dataGridViewFuncionarios.Visible = false;
            lblCodMatricula.Text = "* * * * * *";
            txbPesquisarFuncionario.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
        }

        private void CarregarCampos()
        {
            if (txbPesquisarFuncionario.Text != "")
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        var carregarCampos = "select * from Usuarios_login where NOME like ('" + txbPesquisarFuncionario.Text + "%') Order By NOME";
                        using (SqlDataAdapter da = new SqlDataAdapter(carregarCampos, conexao))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridViewFuncionarios.DataSource = dt;
                            }
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{error}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você deve inserir o nome cliente no campo de pesquisa para buscar as informações desejadas.", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLibertyBuscarCliente_Click(object sender, EventArgs e)
        {
            CarregarCampos();
            dataGridViewFuncionarios.Visible = true;
        }

        private void dataGridViewFuncionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarDadosFunc();
            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbDataNascimento.Enabled = true;
            txbRG.Enabled = true;
            comboBoxNacionalidade.Enabled = true;
            comboBoxSexo.Enabled = true;
            txbLogin.Enabled = true;
            txbSenha.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            radioButtonAtivo.Enabled = true;
            radioButtonInativo.Enabled = true;
        }

        private void CarregarDadosFunc()
        {
            lblCodMatricula.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[0].Value.ToString();
            txbNome.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[1].Value.ToString();
            txbCPF.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[2].Value.ToString();
            txbDataNascimento.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[3].Value.ToString();
            txbRG.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxNacionalidade.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxSexo.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[6].Value.ToString();
            txbLogin.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[7].Value.ToString();
            txbSenha.Text = dataGridViewFuncionarios.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes();
        }

        private void AtualizarInformacoes()
        {
            string NOME = txbNome.Text, CPF = txbCPF.Text, DATA_NASCIMENTO = txbDataNascimento.Text, RG = txbRG.Text, NACIONALIDADE = comboBoxNacionalidade.Text, SEXO = comboBoxSexo.Text, LOGIN = txbLogin.Text, SENHA = txbSenha.Text;
            int id = Convert.ToInt32(lblCodMatricula.Text);

            if (txbNome.Text != "" && txbCPF.Text != "" && txbDataNascimento.Text != "" && txbRG.Text != "" && comboBoxNacionalidade.Text != "" && comboBoxSexo.Text != "" && txbLogin.Text != "" && txbSenha.Text != "")
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var sqlAtualizar = "update Usuarios_login set NOME = @NOME,CPF = @CPF, DATA_DE_NASCIMENTO = @DATA_NASCIMENTO, RG = @RG, NACIONALIDADE = @NACIONALIDADE, RESULTADOSEXO = @SEXO, LOGIN_Funcionario = @LOGIN, SENHA_Funcionario = @SENHA where id = @id";
                        using (SqlCommand cmd = new SqlCommand(sqlAtualizar, conexao))
                        {
                            cmd.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = NOME;
                            cmd.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = CPF;
                            cmd.Parameters.Add("@DATA_NASCIMENTO", System.Data.SqlDbType.VarChar).Value = DATA_NASCIMENTO;
                            cmd.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = RG;
                            cmd.Parameters.Add("@NACIONALIDADE", System.Data.SqlDbType.VarChar).Value = NACIONALIDADE;
                            cmd.Parameters.Add("@SEXO", System.Data.SqlDbType.VarChar).Value = SEXO;
                            cmd.Parameters.Add("@LOGIN", System.Data.SqlDbType.VarChar).Value = LOGIN;
                            cmd.Parameters.Add("@SENHA", System.Data.SqlDbType.VarChar).Value = SENHA;
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Cadastro atualizado com sucesso!", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{error}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Não foi possível atualizar!\nCertifique-se de que todos os campos estejam preenchidos corretamente.", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblCodMatricula.Text);
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                {
                    conexao.Open();

                    var sqlExluirDados = "delete from Usuarios_login where id = @id";
                    using (SqlCommand cmd = new SqlCommand(sqlExluirDados, conexao))
                    {
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro excluído com sucesso!", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFuncionarios.Visible = false;
                        txbPesquisarFuncionario.Text = string.Empty;
                        LimparCampos();
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
            }catch(SqlException error)
            {
                MessageBox.Show($"Não foi possível excluir o cadastro!\nHouve uma falha de conexão com o banco de dados, por favor, contate o suporte de Ti.\nDetalhes do erro: \n{error}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
