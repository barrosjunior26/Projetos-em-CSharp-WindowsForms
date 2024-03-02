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
using WindowsFormsApp_CadastroCarros.Data;

namespace WindowsFormsApp_CadastroCarros
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Testando a conexão com o servidor do SQL Server...";
            Thread.Sleep(5000);
            statusStrip1.Refresh();
            toolStripStatusLabel1.Text = "Estabelecendo conexão com o servidor do SQL Server...";
            Thread.Sleep(5000);
            statusStrip1.Refresh();
            try
            {
                toolStripStatusLabel1.Text = "Só mais alguns instantes...";
                Thread.Sleep(5000);
                statusStrip1.Refresh();
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnection))
                {
                    conexao.Open();
                    toolStripStatusLabel1.Text = "Conexão bem sucedida.";
                    Thread.Sleep(5000);
                    statusStrip1.Refresh();
                    toolStripStatusLabel1.Text = "Conectado.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException erroConexao)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar se conectar com o banco de dados do Microsoft SQL Server.\nDetalhes do erro: {erroConexao}.");
                toolStripStatusLabel1.Text = "Não conectado.";
                statusStrip1.Refresh();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnection))
                {
                    conexao.Open();
                    var SalvarDados = "insert into Cadastro (Marca, Modelo, Cor, Potencia) values (@MARCA, @MODELO, @COR, @POTENCIA)";
                    using (SqlCommand cmd = new SqlCommand(SalvarDados, conexao))
                    {
                        toolStripStatusLabel1.Text = "Gravando os dados no servidor do Microsoft SQL Server...";
                        Thread.Sleep(6000);
                        statusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@MARCA", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@MODELO", txtModelo.Text);
                        cmd.Parameters.AddWithValue("@COR", txtCor.Text);
                        cmd.Parameters.AddWithValue("@POTENCIA", txtPotencia.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        toolStripStatusLabel1.Text = "Dados salvos com sucesso!";
                        Thread.Sleep(6000);
                        statusStrip1.Refresh();
                    }
                }

                txtCor.Text = string.Empty;
                txtMarca.Text = string.Empty;
                txtModelo.Text = string.Empty;
                txtPotencia.Text = string.Empty;
            }
            catch (SqlException erroSalvar)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar salvar os dandos no servidor do Microsoft SQL Server.\nDetalhes do erro: {erroSalvar}.");
            }
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ClassConnection.DefaultConnection))
                {
                    conexao.Open();
                    var carregaDados = "select * from Cadastro";
                    using (SqlDataAdapter da = new SqlDataAdapter(carregaDados, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridViewCarros.DataSource = dt;
                        }
                    }
                }
            }catch (SqlException erroCarregarDados)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar os dandos do servidor do Microsoft SQL Server no Data Grid View.\nDetalhes do erro: {erroCarregarDados}.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCor.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtPotencia.Text = string.Empty;
        }
    }
}
