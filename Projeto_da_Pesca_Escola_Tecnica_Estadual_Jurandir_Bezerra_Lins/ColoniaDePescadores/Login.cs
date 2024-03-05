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
using System.Threading;

namespace ColoniaDePescadores
{
    public partial class Login : Form
    {
        Conexao conn = new Conexao();
        SqlDataReader reader;
        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBoxFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txbSenha.UseSystemPasswordChar = false;
        }

        private void btnVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txbSenha.UseSystemPasswordChar = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando-se ao banco de dados do Microsoft SQL SERVER, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                {
                    conexao.Open();
                    toolStripStatusLabel1.Text = "Conectado!";
                    statusStrip1.Refresh();
                }
            }catch(SqlException error)
            {
                toolStripStatusLabel1.Text = "Erro ao se conectar com o banco de dados do Microsoft SQL SERVER!";
                statusStrip1.Refresh();
                MessageBox.Show($"Falha ao conectar-se com o banco de dados do Microsoft SQL SERVER!\nDetalhes do erro: \n{error}","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            txbUsuario.Focus();
        }

        private void BntEntrar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text.Length <= 0 || txbSenha.Text.Length <= 0)
            {

                MessageBox.Show("É necessário informar seu login e senha para ter acesso ao sistema", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var sqlUserPassWord = "select * from Usuarios_login where LOGIN_Funcionario = ('" + txbUsuario.Text + "') and SENHA_Funcionario = ('" + txbSenha.Text + "')";
                        using (SqlCommand cmd = new SqlCommand(sqlUserPassWord, conexao))
                        {
                            reader = cmd.ExecuteReader();
                        }

                        if (reader.HasRows)
                        {
                            this.Close();
                            t1 = new Thread(AbrirJanela);
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start();
                        }
                        else
                        {
                            MessageBox.Show("Login o senha estão incorretos.\nCaso estejam corretos e mesmo assim você não consiga logar, por favor, contate o administrador do sistema.", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{error}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new FrmMenu());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbUsuario.Text = string.Empty;
            txbSenha.Text = string.Empty;
            txbUsuario.Focus();
        }
    }
}
