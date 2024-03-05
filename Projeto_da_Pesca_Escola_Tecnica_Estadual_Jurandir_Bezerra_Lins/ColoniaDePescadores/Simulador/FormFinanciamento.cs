using ColoniaDePescadores.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Resources;
using System.Data.SqlClient;

namespace ColoniaDePescadores.Simulador
{
    public partial class FormFinanciamento : Form
    {
        double Capital = 0.0, Juros = 0.0, Montante = 0.0, TaxaDeJuros = 0.0;
        int Tempo = 0;
        public FormFinanciamento()
        {
            InitializeComponent();
        }

        public FormFinanciamento(string produto, string valorFinanciado, string codigoProduto, string codigoFile) : this()
        {
            txbLibertyValorSerFinanciado.Text = valorFinanciado;
            lblLibertyCodigoNumeroFile.Text = codigoFile;
            lblLibertyCodigoProd.Text = codigoProduto;
            txbLibertyNomeDoProduto.Text = produto;
        }

        private void FocarCPF()
        {
            txbLibertyCPF.Focus();
        }

        private void comboBoxLibertyInstFinanceira_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.seguro_de_cartao_Bradesco;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(2.71, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.Banco_do_Brasil;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(2.56, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.banco_do_nordeste;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(6.09, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.santander_logo;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(2.69, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.Banco_Votorantim;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(4.02, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.Caixa;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(2.82, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = Resources.Banco_Itau;
                pictureBoxLibertyLogoJuros.Image = Resources.interesse;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(3.42, 2)}");
                lblTaxaMes.Text = "% a.a";
            }
            else if (comboBoxLibertyInstFinanceira.Text == "Selecione")
            {
                pictureBoxLibertyLogoInstFinanceira.Image = null;
                pictureBoxLibertyLogoJuros.Image = null;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(0.00, 2)}");
                lblTaxaMes.Text = "* * * *";
            }
            else
            {
                pictureBoxLibertyLogoInstFinanceira.Image = null;
                pictureBoxLibertyLogoJuros.Image = null;
                lblLibertyJurosAoMes.Text = ($"{Math.Round(0.00, 2)}");
                lblTaxaMes.Text = "* * * *";
            }
        }

        private void LimparCamposLiberty()
        {
            txbLibertyCPF.Text = string.Empty;
            txbLibertyNomeCliente.Text = string.Empty;
            txbLibertyNomeDoProduto.Text = string.Empty;
            txbLibertyResumo.Text = string.Empty;
            txbLibertyValorSerFinanciado.Text = string.Empty;
            lblLibertyCodigoNumeroFile.Text = "* * * * * *";
            lblLibertyCodigoProd.Text = "* * * * * *";
            lblLibertyJurosAoMes.Text = "0,00";
            lblTaxaMes.Text = "* * * * *";
            lblLibertyValorTotalComJuros.Text = "0,00";
            lblLibertyValorTotalJuros.Text = "* * * * * *";
            pictureBoxLibertyLogoJuros.Visible = false;
            pictureBoxLibertyLogoInstFinanceira.Visible = false;
            comboBoxLibertyInstFinanceira.Text = string.Empty;
            comboBoxLibertyTotalDeParcelas.Text = string.Empty;
        }

        private void btnLibertySalvar_Click(object sender, EventArgs e)
        {
            if (txbLibertyNomeDoProduto.Text != "" && txbLibertyCPF.Text != "" && txbLibertyNomeCliente.Text != "" && comboBoxLibertyInstFinanceira.Text != "" && comboBoxLibertyTotalDeParcelas.Text != "" && txbLibertyValorSerFinanciado.Text != "" && txbLibertyResumo.Text != "")
            {
                string STATUS_FINANCIAMENTO = txbLibertyResumo.Text;
                int CODIGO = Convert.ToInt32(lblMatricula.Text);

                using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                {
                    conexao.Open();
                    try
                    {
                        var comandosSql = "update Cadastro_de_clientes set STATUS_FINANCIAMENTO = @STATUS_FINANCIAMENTO where CODIGO = @CODIGO";
                        using (SqlCommand cmd = new SqlCommand(comandosSql, conexao))
                        {
                            cmd.Parameters.Add("@STATUS_FINANCIAMENTO", System.Data.SqlDbType.VarChar).Value = STATUS_FINANCIAMENTO;
                            cmd.Parameters.Add("@CODIGO",System.Data.SqlDbType.Int).Value = CODIGO;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Aquisição de produto realizado com sucesso!","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            LimparCamposLiberty();
                        }
                    }
                    catch(SqlException erroConexao)
                    {
                        MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{erroConexao}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLibertyBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txbLibertyCPF.Text != "")
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                {
                    conexao.Open();
                    var SqlQuery = "select CODIGO, NOME from Cadastro_de_clientes where CPF like '"+txbLibertyCPF.Text+"' Order by CODIGO";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridViewClientes.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void CarregarCliente()
        {
            txbLibertyNomeCliente.Text = dataGridViewClientes.SelectedRows[0].Cells[1].Value.ToString();
            lblMatricula.Text = dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridViewClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarCliente();
        }

        private void btnLibertyLimparCPF_Click(object sender, EventArgs e)
        {
            txbLibertyCPF.Text = string.Empty;
            txbLibertyCPF.Focus();
        }

        private void btnLibertyCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLibertyCalcular_Click(object sender, EventArgs e)
        {
            if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {

                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / 12;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");

            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Banco Bradesco S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Banco Bradesco S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0271;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de paerparcelascelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Banco do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0256;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Banco do Nordeste do Brasil S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Banco do Nordeste do Brasil S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0609;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Banco Santander (Brasil) S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Banco Santander (Brasil) S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0269;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Banco Votorantim S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Banco Votorantim S.A.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.042;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Caixa Econômica Federal")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Caixa Econômica Federal.
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0282;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "12 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 12 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 12;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "24 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 24 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 24;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "36 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 36 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 36;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "48 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 48 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 48;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "60 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 60 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 60;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
            else if (comboBoxLibertyTotalDeParcelas.Text == "72 x" && comboBoxLibertyInstFinanceira.Text == "Itaú Unibanco Holding S.A.")
            {
                //Cálculo de juros simples com o valor do capital divido em 72 vezes - Itaú Unibanco Holding S.A..
                Capital = Convert.ToDouble(txbLibertyValorSerFinanciado.Text);
                TaxaDeJuros = 0.0342;
                Tempo = 72;
                Juros = Capital * TaxaDeJuros * Tempo;
                Montante = Capital + Juros;
                lblLibertyValorTotalJuros.Text = ($"R${Math.Round(Juros, 2)}");
                double parcelas = Montante / Tempo;
                lblLibertyValorTotalComJuros.Text = ($"R${Math.Round(Capital + Juros, 2)}");
                txbLibertyResumo.Text = ($"Produto: {txbLibertyNomeDoProduto.Text}\r\nCódigo do produto: {lblLibertyCodigoProd.Text}\r\nNome do cliente: {txbLibertyNomeCliente.Text}\r\nCPF: {txbLibertyCPF.Text}\r\nFinanceira responsável pelo financiamento: {comboBoxLibertyInstFinanceira.Text}\r\nValor do produto: R${txbLibertyValorSerFinanciado.Text}\r\nTaxa de juros do financiamento: {lblLibertyJurosAoMes.Text}% a.a\r\nValor das parcelas: R${Math.Round(parcelas, 2)}\r\nValor total a pagar com juros incluso: R${lblLibertyValorTotalComJuros.Text}\r\nQtdº de parcelas: {comboBoxLibertyTotalDeParcelas.Text}");
            }
        }
    }
}
