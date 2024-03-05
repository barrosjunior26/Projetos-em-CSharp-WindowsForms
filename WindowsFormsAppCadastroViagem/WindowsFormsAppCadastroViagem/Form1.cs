using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCadastroViagem.Data;

namespace WindowsFormsAppCadastroViagem
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = string.Empty;
            Desabilitado();
            txbNomeAluno.Focus();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            ChecarConexao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnections))
                {
                    conexao.Open();
                    var SalvarDados = "insert into Alunos (Nome, CPF, RG, Ano, Curso, Cadastramento, Observacoes, Protocolo) values (@nome, @cpf, @rg, @ano, @curso, @cadastramento, @observacoes, @protocolo)";
                    using (SqlCommand cmd = new SqlCommand(SalvarDados, conexao))
                    {
                        var protocolo = Guid.NewGuid().ToString();

                        txbProtocolo.Text = protocolo;

                        cmd.Parameters.AddWithValue("@nome", txbNomeAluno.Text);
                        cmd.Parameters.AddWithValue("@cpf", txbCPF.Text); // Use txbCPF.Text
                        cmd.Parameters.AddWithValue("@rg", txbRG.Text); // Use txbRG.Text
                        cmd.Parameters.AddWithValue("@ano", int.Parse(txbAno.Text)); // Parse txbAno.Text to int
                        cmd.Parameters.AddWithValue("@curso", txbCurso.Text);
                        cmd.Parameters.AddWithValue("@cadastramento", DateTime.Now); // Use DateTime.Now
                        cmd.Parameters.AddWithValue("@observacoes", txbObservacoes.Text);
                        cmd.Parameters.AddWithValue("@protocolo", protocolo); // Use the generated protocol

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        toolStripStatusLabel1.Text = "Dados salvos com sucesso!";
                        Thread.Sleep(5000);
                        statusStripPrincipal.Refresh();
                    }
                }
            }
            catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Ocorreu um erro ao tentar salvar os dados!";
                Thread.Sleep(5000);
                statusStripPrincipal.Refresh();
                MessageBox.Show($"Detalhes do erro:\n{ex}");
            }
        }

        private void Desabilitado()
        {
            txbProtocolo.ReadOnly = true;
            txbDataMatricula.ReadOnly = true;
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnections))
                {
                    conexao.Open();
                    var SelecionaDados = "select * from Alunos";
                    using (SqlDataAdapter da = new SqlDataAdapter(SelecionaDados, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridViewDadosAlunos.DataSource = dt;
                        }
                    }
                }
            }catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Ocorreu um erro ao tentar carregar os dados contidos no banco de dados do SQL Server!";
                Thread.Sleep(5000);
                statusStripPrincipal.Refresh();
                MessageBox.Show($"Detalhes do erro:\n{ex}");
            }
        }

        private void ChecarConexao()
        {
            Cursor.Current = Cursors.WaitCursor;
            toolStripStatusLabel1.Text = "Checando a conexão com o servidor do SQL Server...";
            Thread.Sleep(6000);
            statusStripPrincipal.Refresh();
            toolStripStatusLabel1.Text = "Tentando estabelecer conexão com o servidor do SQL Server...";
            Thread.Sleep(6000);
            statusStripPrincipal.Refresh();
            toolStripStatusLabel1.Text = "Só mais alguns instantes...";
            Thread.Sleep(6000);
            statusStripPrincipal.Refresh();
            try
            {
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnections))
                {
                    conexao.Open();
                    Thread.Sleep(6000);
                    toolStripStatusLabel1.Text = "Conexão estabelecida com sucesso!";
                    statusStripPrincipal.Refresh();
                }
            }
            catch (SqlException erroConexao)
            {
                toolStripStatusLabel1.Text = "O correu um erro inesperado ao tentar se conectar com o servidor do SQL Server.";
                Thread.Sleep(2000);
                statusStripPrincipal.Refresh();
                MessageBox.Show($"Detalhes do erro de conexão: \n{erroConexao}");
            }
            finally
            {
                Cursor = Cursors.Default;
                Thread.Sleep(6000);
                toolStripStatusLabel1.Text = string.Empty;
                statusStripPrincipal.Refresh();

            }
        }
    }
}
