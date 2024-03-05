using ColoniaDePescadores.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;
using System.Runtime.CompilerServices;

namespace ColoniaDePescadores
{
    public partial class AreaDoPescador : UserControl
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter(); //Classe (objeto) disponível para receber os dados de uma tabela após a execução de um Select
        DataTable dt = new DataTable(); //O objeto DataTable pode representar uma ou mais tabelas de dados, as quais permanecem alocadas em memória e pode ser manipulado através de métodos.
        public AreaDoPescador()
        {
            InitializeComponent();
            UF();
            MunicipiosSiglas();
            Municipios();
            StatusFinanciamento();
        }

        private void comboBoxUFRG_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Bandeiras();
        }

        private void StatusFinanciamento()
        {
            if (txbObservacoesFinanceiras.Text != "")
            {
                lblNegativado.Visible = true;
                lblLiberado.Visible = false;
            }
            else
            {
                lblLiberado.Visible = true;
                lblNegativado.Visible = false;
            }
        }

        private void comboBoxEndEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MunicipiosSiglas();
        }

        private void comboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Municipios();
            if (comboBoxMunicipio.Text == "Selecione")
            {
                pictureBoxMapas.Image = Resources.Mapa_Animado;
            }
            else
            {
                pictureBoxMapas.Image = Resources.Mapa_Pernambuco;
                
            }
        }

        private void Municipios()
        {
            string[] municipios = new string[]
            {
                "Abreu e Lima",
                "Afogados da Ingazeira",
                "Afrânio",
                "Agrestina",
                "Água Preta",
                "Águas Belas",
                "Alagoinha",
                "Aliança",
                "Altinho",
                "Amaraji",
                "Angelim",
                "Araçoiaba",
                "Araripina",
                "Arcoverde",
                "Barra de Guabiraba",
                "Barreiros",
                "Belém de Maria",
                "Belém do São Francisco",
                "Belo Jardim",
                "Betânia",
                "Bezerros",
                "Bodocó",
                "Bom Conselho",
                "Bom Jardim",
                "Bonito",
                "Brejão",
                "Brejinho",
                "Brejo da Madre de Deus",
                "Buenos Aires",
                "Buíque",
                "Cabo de Santo Agostinho",
                "Cabrobó",
                "Cachoeirinha",
                "Caetés",
                "Calçado",
                "Calumbi",
                "Camaragibe",
                "Camocim de São Félix",
                "Camutanga",
                "Canhotinho",
                "Capoeiras",
                "Carnaíba",
                "Carnaubeira da Penha",
                "Carpina",
                "Caruaru",
                "Casinhas",
                "Catende",
                "Cedro",
                "Chã de Alegria",
                "Chã Grande",
                "Condado",
                "Correntes",
                "Cortês",
                "Cumaru",
                "Cupira",
                "Custódia",
                "Dormentes",
                "Escada",
                "Exu",
                "Feira Nova",
                "Ferreiros",
                "Flores",
                "Floresta",
                "Frei Miguelinho",
                "Gameleira",
                "Garanhuns",
                "Glória do Goitá",
                "Goiana",
                "Granito",
                "Gravatá",
                "Iati",
                "Ibimirim",
                "Ibirajuba",
                "Igarassu",
                "Iguaraci",
                "Ilha de Itamaracá",
                "Inajá",
                "Ingazeira",
                "Ipojuca",
                "Ipubi",
                "Itacuruba",
                "Itaíba",
                "Itambé",
                "Itapetim",
                "Itapissuma",
                "Itaquitinga",
                "Jaboatão dos Guararapes",
                "Jaqueira",
                "Jataúba",
                "Jatobá",
                "João Alfredo",
                "Joaquim Nabuco",
                "Jucati",
                "Jupi",
                "Jurema",
                "Lagoa de Itaenga",
                "Lagoa do Carro",
                "Lagoa do Ouro",
                "Lagoa dos Gatos",
                "Lagoa Grande",
                "Lajedo",
                "Limoeiro",
                "Macaparana",
                "Machados",
                "Manari",
                "Maraial",
                "Mirandiba",
                "Moreilândia",
                "Moreno",
                "Nazaré da Mata",
                "Olinda",
                "Orobó",
                "Orocó",
                "Ouricuri",
                "Palmares",
                "Palmeirina",
                "Panelas",
                "Paranatama",
                "Parnamirim",
                "Passira",
                "Paudalho",
                "Paulista",
                "Pedra",
                "Pesqueira",
                "Petrolândia",
                "Petrolina",
                "Poção",
                "Pombos",
                "Primavera",
                "Quipapá",
                "Quixaba",
                "Recife",
                "Riacho das Almas",
                "Ribeirão",
                "Rio Formoso",
                "Sairé",
                "Salgadinho",
                "Salgueiro",
                "Saloá",
                "Sanharó",
                "Santa Cruz",
                "Santa Cruz da Baixa Verde",
                "Santa Cruz do Capibaribe",
                "Santa Filomena",
                "Santa Maria da Boa Vista",
                "Santa Maria do Cambucá",
                "Santa Terezinha",
                "São Benedito do Sul",
                "São Bento do Una",
                "São Caetano",
                "São João",
                "São Joaquim do Monte",
                "São José da Coroa Grande",
                "São José do Belmonte",
                "São José do Egito",
                "São Lourenço da Mata",
                "São Vicente Férrer",
                "Serra Talhada",
                "Serrita",
                "Sertânia",
                "Sirinhaém",
                "Solidão",
                "Surubim",
                "Tabira",
                "Tacaimbó",
                "Tacaratu",
                "Tamandaré",
                "Taquaritinga do Norte",
                "Terezinha",
                "Terra Nova",
                "Timbaúba",
                "Toritama",
                "Tracunhaém",
                "Trindade",
                "Triunfo",
                "Tupanatinga",
                "Tuparetama",
                "Venturosa",
                "Verdejante",
                "Vertente do Lério",
                "Vertentes",
                "Vicência",
                "Vitória de Santo Antão",
                "Xexéu",
            };
            comboBoxMunicipio.Items.AddRange(municipios);
        }

        public void UF()
        {
            string[] UF = new string[]
            {
                "Acre",
                "Alagoas",
                "Amapá",
                "Amazonas",
                "Bahia",
                "Ceará",
                "Espírito Santo",
                "Goiás",
                "Maranhão",
                "Mato Grosso",
                "Mato Grosso do Sul",
                "Minas Gerais",
                "Pará",
                "Paraíba",
                "Paraná",
                "Pernambuco",
                "Piauí",
                "Rio de Janeiro",
                "Rio Grande do Norte",
                "Rio Grande do Sul",
                "Rondônia",
                "Roraima",
                "Santa Catarina",
                "São Paulo",
                "Sergipe",
                "Tocantins",
            };

            comboBoxUFRG.Items.AddRange( UF );
            comboBoxEndEstados.Items.AddRange( UF );
        }

        public void Bandeiras()
        {
            switch (comboBoxUFRG.Text)
            {
                case "Acre":
                    pictureBoxBandeiras.Image = Resources.ACRE;
                    lblResultadoSigla.Text = "AC";
                    lblResultadoCAPITAL.Text = "Rio Branco";
                    lblRegiao.Text = "Norte";
                    break;
                case "Alagoas":
                    pictureBoxBandeiras.Image = Resources.ALAGOAS;
                    lblResultadoSigla.Text = "AL";
                    lblResultadoCAPITAL.Text = "Maceió";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Amapá":
                    pictureBoxBandeiras.Image = Resources.AMAPÁ;
                    lblResultadoSigla.Text = "AP";
                    lblResultadoCAPITAL.Text = "Macapá";
                    lblRegiao.Text = "Norte";
                    break;
                case "Amazonas":
                    pictureBoxBandeiras.Image = Resources.AMAZONAS;
                    lblResultadoSigla.Text = "AM";
                    lblResultadoCAPITAL.Text = "Manaus";
                    lblRegiao.Text = "Norte";
                    break;
                case "Bahia":
                    pictureBoxBandeiras.Image = Resources.BAHIA;
                    lblResultadoSigla.Text = "BA";
                    lblResultadoCAPITAL.Text = "Salvador";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Ceará":
                    pictureBoxBandeiras.Image = Resources.CEARÁ;
                    lblResultadoSigla.Text = "CE";
                    lblResultadoCAPITAL.Text = "Fortaleza";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Espírito Santo":
                    pictureBoxBandeiras.Image = Resources.ESPÍRITO_SANTO;
                    lblResultadoSigla.Text = "ES";
                    lblResultadoCAPITAL.Text = "Vitória";
                    lblRegiao.Text = "Sudeste";
                    break;
                case "Goiás":
                    pictureBoxBandeiras.Image = Resources.GOIÁS;
                    lblResultadoSigla.Text = "GO";
                    lblResultadoCAPITAL.Text = "Goiânia";
                    lblRegiao.Text = "Centro-Oeste";
                    break;
                case "Maranhão":
                    pictureBoxBandeiras.Image = Resources.MARANHÃO;
                    lblResultadoSigla.Text = "MA";
                    lblResultadoCAPITAL.Text = "São Luís";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Mato Grosso":
                    pictureBoxBandeiras.Image = Resources.MATO_GROSSO;
                    lblResultadoSigla.Text = "MT";
                    lblResultadoCAPITAL.Text = "Cuibá";
                    lblRegiao.Text = "Centro-Oeste";
                    break;
                case "Mato Grosso do Sul":
                    pictureBoxBandeiras.Image = Resources.MATO_GROSSO_DO_SUL;
                    lblResultadoSigla.Text = "MS";
                    lblResultadoCAPITAL.Text = "Campo Grande";
                    lblRegiao.Text = "Centro-Oeste";
                    break;
                case "Minas Gerais":
                    pictureBoxBandeiras.Image = Resources.MINAS_GERAIS;
                    lblResultadoSigla.Text = "MG";
                    lblResultadoCAPITAL.Text = "Belo Horizonte";
                    lblRegiao.Text = "Sudeste";
                    break;
                case "Pará":
                    pictureBoxBandeiras.Image = Resources.PARÁ;
                    lblResultadoSigla.Text = "PA";
                    lblResultadoCAPITAL.Text = "Belém";
                    lblRegiao.Text = "Norte";
                    break;
                case "Paraíba":
                    pictureBoxBandeiras.Image = Resources.PARAÍBA;
                    lblResultadoSigla.Text = "PB";
                    lblResultadoCAPITAL.Text = "João Pessoa";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Paraná":
                    pictureBoxBandeiras.Image = Resources.PARANÁ;
                    lblResultadoSigla.Text = "PR";
                    lblResultadoCAPITAL.Text = "Curitiba";
                    lblRegiao.Text = "Sul";
                    break;
                case "Pernambuco":
                    pictureBoxBandeiras.Image = Resources.PERNAMBUCO;
                    lblResultadoSigla.Text = "PE";
                    lblResultadoCAPITAL.Text = "Recife";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Piauí":
                    pictureBoxBandeiras.Image = Resources.PIAUÍ;
                    lblResultadoSigla.Text = "PI";
                    lblResultadoCAPITAL.Text = "Teresina";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Rio de Janeiro":
                    pictureBoxBandeiras.Image = Resources.JANEIRO;
                    lblResultadoSigla.Text = "RJ";
                    lblResultadoCAPITAL.Text = "Rio de Janeiro";
                    lblRegiao.Text = "Sudeste";
                    break;
                case "Rio Grande do Norte":
                    pictureBoxBandeiras.Image = Resources.RIO_GRANDE_DO_NORTE;
                    lblResultadoSigla.Text = "RN";
                    lblResultadoCAPITAL.Text = "Natal";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Rio Grande do Sul":
                    pictureBoxBandeiras.Image = Resources.RIO_GRANDE_DO_SUL;
                    lblResultadoSigla.Text = "RS";
                    lblResultadoCAPITAL.Text = "Porto Alegre";
                    lblRegiao.Text = "Sul";
                    break;
                case "Rondônia":
                    pictureBoxBandeiras.Image = Resources.RONDÔNIA;
                    lblResultadoSigla.Text = "RO";
                    lblResultadoCAPITAL.Text = "Porto Velho";
                    lblRegiao.Text = "Norte";
                    break;
                case "Roraima":
                    pictureBoxBandeiras.Image = Resources.RORAIMA;
                    lblResultadoSigla.Text = "RR";
                    lblResultadoCAPITAL.Text = "Boa Vista";
                    lblRegiao.Text = "Norte";
                    break;
                case "Santa Catarina":
                    pictureBoxBandeiras.Image = Resources.SANTA_CATARINA;
                    lblResultadoSigla.Text = "SC";
                    lblResultadoCAPITAL.Text = "Florianópolis";
                    lblRegiao.Text = "Sul";
                    break;
                case "São Paulo":
                    pictureBoxBandeiras.Image = Resources.SÃO_PAULO;
                    lblResultadoSigla.Text = "SP";
                    lblResultadoCAPITAL.Text = "São Paulo";
                    lblRegiao.Text = "Sudeste";
                    break;
                case "Sergipe":
                    pictureBoxBandeiras.Image = Resources.SERGIPE;
                    lblResultadoSigla.Text = "SE";
                    lblResultadoCAPITAL.Text = "Aracaju";
                    lblRegiao.Text = "Nordeste";
                    break;
                case "Tocantins":
                    pictureBoxBandeiras.Image = Resources.TOCANTINS;
                    lblResultadoSigla.Text = "TO";
                    lblResultadoCAPITAL.Text = "Palmas";
                    lblRegiao.Text = "Norte";
                    break;
            }
        }

        private void MunicipiosSiglas()
        {
            switch (comboBoxEndEstados.Text)
            {
                case "Acre":
                    lblEndUFSigla.Text = "AC";
                    break;
                case "Alagoas":
                    lblEndUFSigla.Text = "AL";
                    break;
                case "Amapá":
                    lblEndUFSigla.Text = "AP";
                    break;
                case "Amazonas":
                    lblEndUFSigla.Text = "AM";
                    break;
                case "Bahia":
                    lblEndUFSigla.Text = "BA";
                    break;
                case "Ceará":
                    lblEndUFSigla.Text = "CE";
                    break;
                case "Espírito Santo":
                    lblEndUFSigla.Text = "ES";
                    break;
                case "Goiás":
                    lblEndUFSigla.Text = "GO";
                    break;
                case "Maranhão":
                    lblEndUFSigla.Text = "MA";
                    break;
                case "Mato Grosso":
                    lblEndUFSigla.Text = "MT";
                    break;
                case "Mato Grosso do Sul":
                    lblEndUFSigla.Text = "MS";
                    break;
                case "Minas Gerais":
                    lblEndUFSigla.Text = "MG";
                    break;
                case "Pará":
                    lblEndUFSigla.Text = "PA";
                    break;
                case "Paraíba":
                    lblEndUFSigla.Text = "PB";
                    break;
                case "Paraná":
                    lblEndUFSigla.Text = "PR";
                    break;
                case "Pernambuco":
                    lblEndUFSigla.Text = "PE";
                    break;
                case "Piauí":
                    lblEndUFSigla.Text = "PI";
                    break;
                case "Rio de Janeiro":
                    lblEndUFSigla.Text = "RJ";
                    break;
                case "Rio Grande do Norte":
                    lblEndUFSigla.Text = "RN";
                    break;
                case "Rio Grande do Sul":
                    lblEndUFSigla.Text = "RS";
                    break;
                case "Rondônia":
                    lblEndUFSigla.Text = "RO";
                    break;
                case "Roraima":
                    lblEndUFSigla.Text = "RR";
                    break;
                case "Santa Catarina":
                    lblEndUFSigla.Text = "SC";
                    break;
                case "São Paulo":
                    lblEndUFSigla.Text = "SP";
                    break;
                case "Sergipe":
                    lblEndUFSigla.Text = "SE";
                    break;
                case "Tocantins":
                    lblEndUFSigla.Text = "TO";
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" || comboBoxUFRG.Text == "" || comboBoxNacionalidade.Text == "" || comboBoxSexo.Text == "" || comboBoxQtDependentes.Text == "" || txbLogradouro.Text == "" || txbNumero.Text == "" || txbBairro.Text == "" || comboBoxEndEstados.Text == "" || comboBoxMunicipio.Text == "" || comboBoxRendaPrincipal.Text == "" || txbMediaPorKGProduto.Text == "" || txbQtdPescadoMes.Text == "" || txbRendaBruta.Text == "" || txbRendaLiquida.Text == "")
            {
                MessageBox.Show("Os campos OBRIGATÓRIOS (*) não podem ficar em branco","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //Seção de variáveis
                string NOME = txbNome.Text, CPF = txbCPF.Text, NASCIMENTO = txbDataNascimento.Text, RG = txbRG.Text, EMISSAO_RG = txbDataEmissaoRG.Text, UF_RG = comboBoxUFRG.Text, NACIONALIDADE = comboBoxNacionalidade.Text, SEXO = comboBoxSexo.Text, CAPITAL = lblResultadoCAPITAL.Text, SIGLA = lblResultadoSigla.Text, REGIAO = lblRegiao.Text, DEPENDENTES = comboBoxQtDependentes.Text, LOGRADOURO = txbLogradouro.Text, NUMERO = txbNumero.Text, COMPLEMENTO = txbComplemento.Text, BAIRRO = txbBairro.Text, CEP = txbCep.Text, ESTADO = comboBoxEndEstados.Text, UF = lblEndUFSigla.Text, MUNICIPIO = comboBoxMunicipio.Text, TELEFONE = txbTelefone.Text, CELULAR = txbCelular.Text, FAX = txbFax.Text, EMAIL = txbEmail.Text, RENDA_PRINCIPAL = comboBoxRendaPrincipal.Text, OUTRAS_FONTES_RENDA = txbOutrasFontasDeRenda.Text, DESPESAS_DEPENDENTES = lblValorDespesaPorDependentes.Text, STATUS_FINANCIAMENTO = txbObservacoesFinanceiras.Text;
                decimal MEDIA_KG_PRODUTO = 0, RENDA_BRUTA = 0, RENDA_LIQUIDA = 0, VALOR_OUTRAS_RENDAS = 0;
                int MEDIA_QTDKG_PESCADO = 0, mediaQtdPescadoMes = Convert.ToInt32(txbQtdPescadoMes.Text);

                decimal mediaKgProduto = Convert.ToDecimal(txbMediaPorKGProduto.Text);
                decimal rendaBruta = Convert.ToDecimal(txbRendaBruta.Text);
                decimal rendaLiquida = Convert.ToDecimal(txbRendaLiquida.Text);
                decimal rendaExtra = Convert.ToDecimal(txbValorRendaExtra.Text);

                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var sqlQuery = "insert into Cadastro_de_clientes (NOME, CPF, NASCIMENTO, RG, EMISSAO_RG, UF_RG, NACIONALIDADE, SEXO, CAPITAL, SIGLA, REGIAO, DEPENDENTES, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CEP, ESTADO, UF, MUNICIPIO, TELEFONE,CELULAR, FAX, EMAIL,  RENDA_PRINCIPAL, MEDIA_KG_PRODUTO, MEDIA_QTDKG_PESCADO, RENDA_BRUTA, RENDA_LIQUIDA,OUTRAS_FONTES_RENDA, VALOR_OUTRAS_RENDAS, DESPESAS_DEPENDENTES, STATUS_FINANCIAMENTO) values (@NOME, @CPF, @NASCIMENTO, @RG, @EMISSAO_RG, @UF_RG, @NACIONALIDADE,@SEXO, @CAPITAL, @SIGLA, @REGIAO, @DEPENDENTES, @LOGRADOURO, @NUMERO, @COMPLEMENTO, @BAIRRO,@CEP, @ESTADO, @UF, @MUNICIPIO, @TELEFONE, @CELULAR, @FAX, @EMAIL,  @RENDA_PRINCIPAL, @MEDIA_KG_PRODUTO,@MEDIA_QTDKG_PESCADO, @RENDA_BRUTA, @RENDA_LIQUIDA, @OUTRAS_FONTES_RENDA, @VALOR_OUTRAS_RENDAS, @DESPESAS_DEPENDENTES, @STATUS_FINANCIAMENTO)";
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, conexao))
                        {
                            //Parâmetros
                            cmd.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = NOME;
                            cmd.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = CPF;
                            cmd.Parameters.Add("@NASCIMENTO", System.Data.SqlDbType.VarChar).Value = NASCIMENTO;
                            cmd.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = RG;
                            cmd.Parameters.Add("@EMISSAO_RG", System.Data.SqlDbType.VarChar).Value = EMISSAO_RG;
                            cmd.Parameters.Add("@UF_RG", System.Data.SqlDbType.VarChar).Value = UF_RG;
                            cmd.Parameters.Add("@NACIONALIDADE", System.Data.SqlDbType.VarChar).Value = NACIONALIDADE;
                            cmd.Parameters.Add("@SEXO", System.Data.SqlDbType.VarChar).Value = SEXO;
                            cmd.Parameters.Add("@CAPITAL", System.Data.SqlDbType.VarChar).Value = CAPITAL;
                            cmd.Parameters.Add("@SIGLA", System.Data.SqlDbType.Char).Value = SIGLA;
                            cmd.Parameters.Add("@REGIAO", System.Data.SqlDbType.VarChar).Value = REGIAO;
                            cmd.Parameters.Add("@DEPENDENTES", System.Data.SqlDbType.VarChar).Value = DEPENDENTES;
                            cmd.Parameters.Add("@LOGRADOURO", System.Data.SqlDbType.VarChar).Value = LOGRADOURO;
                            cmd.Parameters.Add("@NUMERO", System.Data.SqlDbType.VarChar).Value = NUMERO;
                            cmd.Parameters.Add("@COMPLEMENTO", System.Data.SqlDbType.VarChar).Value = COMPLEMENTO;
                            cmd.Parameters.Add("@BAIRRO", System.Data.SqlDbType.VarChar).Value = BAIRRO;
                            cmd.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = CEP;
                            cmd.Parameters.Add("@ESTADO", System.Data.SqlDbType.VarChar).Value = ESTADO;
                            cmd.Parameters.Add("@UF", System.Data.SqlDbType.Char).Value = UF;
                            cmd.Parameters.Add("@MUNICIPIO", System.Data.SqlDbType.VarChar).Value = MUNICIPIO;
                            cmd.Parameters.Add("@TELEFONE", System.Data.SqlDbType.VarChar).Value = TELEFONE;
                            cmd.Parameters.Add("@CELULAR", System.Data.SqlDbType.VarChar).Value = CELULAR;
                            cmd.Parameters.Add("@FAX", System.Data.SqlDbType.VarChar).Value = FAX;
                            cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = EMAIL;
                            cmd.Parameters.Add("@RENDA_PRINCIPAL", System.Data.SqlDbType.VarChar).Value = RENDA_PRINCIPAL;
                            cmd.Parameters.Add("@MEDIA_KG_PRODUTO", System.Data.SqlDbType.Decimal).Value = MEDIA_KG_PRODUTO;
                            cmd.Parameters.Add("@MEDIA_QTDKG_PESCADO", System.Data.SqlDbType.Int).Value = MEDIA_QTDKG_PESCADO;
                            cmd.Parameters.Add("@RENDA_BRUTA", System.Data.SqlDbType.Decimal).Value = RENDA_BRUTA;
                            cmd.Parameters.Add("@RENDA_LIQUIDA", System.Data.SqlDbType.Decimal).Value = RENDA_LIQUIDA;
                            cmd.Parameters.Add("@OUTRAS_FONTES_RENDA", System.Data.SqlDbType.VarChar).Value = OUTRAS_FONTES_RENDA;
                            cmd.Parameters.Add("@VALOR_OUTRAS_RENDAS", System.Data.SqlDbType.Decimal).Value = VALOR_OUTRAS_RENDAS;
                            cmd.Parameters.Add("@DESPESAS_DEPENDENTES", System.Data.SqlDbType.VarChar).Value = DESPESAS_DEPENDENTES;
                            cmd.Parameters.Add("@STATUS_FINANCIAMENTO", System.Data.SqlDbType.VarChar).Value = STATUS_FINANCIAMENTO;

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Cadastro realizado com sucesso!","Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }catch(SqlException errorConexao)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{errorConexao}","Spark informa",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualizarCadastro();
        }

        private void txbObservacoesFinanceiras_TextChanged(object sender, EventArgs e)
        {
            StatusFinanciamento();
        }

        private void dataGridViewClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarInforCliente();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarCampos();
            dataGridViewClientes.Visible = true;
        }

        private void CarregarCampos()
        {
            if (txbCPFPesquisa.Text.Length <= 13)
            {

                MessageBox.Show("Você deve inserir o CPF do cliente no campo de pesquisa para buscar as informações desejadas.", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var CarregarCamposClientes = "select * from Cadastro_de_clientes where CPF like '" + txbCPFPesquisa.Text + "'";

                        using (SqlDataAdapter da = new SqlDataAdapter(CarregarCamposClientes, conexao))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridViewClientes.DataSource = dt;
                            }
                        }
                    }
                }
                catch (SqlException erroConexao)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{erroConexao}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarInforCliente()
        {
            lblCodigoMatricula.Text = dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString();
            txbNome.Text = dataGridViewClientes.SelectedRows[0].Cells[1].Value.ToString();
            txbCPF.Text = dataGridViewClientes.SelectedRows[0].Cells[2].Value.ToString();
            txbDataNascimento.Text = dataGridViewClientes.SelectedRows[0].Cells[3].Value.ToString();
            txbRG.Text = dataGridViewClientes.SelectedRows[0].Cells[4].Value.ToString();
            txbDataEmissaoRG.Text = dataGridViewClientes.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxUFRG.Text = dataGridViewClientes.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxNacionalidade.Text = dataGridViewClientes.SelectedRows[0].Cells[7].Value.ToString();
            comboBoxSexo.Text = dataGridViewClientes.SelectedRows[0].Cells[8].Value.ToString();
            lblResultadoCAPITAL.Text = dataGridViewClientes.SelectedRows[0].Cells[9].Value.ToString();
            lblResultadoSigla.Text = dataGridViewClientes.SelectedRows[0].Cells[10].Value.ToString();
            lblRegiao.Text = dataGridViewClientes.SelectedRows[0].Cells[11].Value.ToString();
            comboBoxQtDependentes.Text = dataGridViewClientes.SelectedRows[0].Cells[12].Value.ToString();
            txbLogradouro.Text = dataGridViewClientes.SelectedRows[0].Cells[13].Value.ToString();
            txbNumero.Text = dataGridViewClientes.SelectedRows[0].Cells[14].Value.ToString();
            txbComplemento.Text = dataGridViewClientes.SelectedRows[0].Cells[15].Value.ToString();
            txbBairro.Text = dataGridViewClientes.SelectedRows[0].Cells[16].Value.ToString();
            txbCep.Text = dataGridViewClientes.SelectedRows[0].Cells[17].Value.ToString();
            comboBoxEndEstados.Text = dataGridViewClientes.SelectedRows[0].Cells[18].Value.ToString();
            lblEndUFSigla.Text = dataGridViewClientes.SelectedRows[0].Cells[19].Value.ToString();
            comboBoxMunicipio.Text = dataGridViewClientes.SelectedRows[0].Cells[20].Value.ToString();
            txbTelefone.Text = dataGridViewClientes.SelectedRows[0].Cells[21].Value.ToString();
            txbCelular.Text = dataGridViewClientes.SelectedRows[0].Cells[22].Value.ToString();
            txbFax.Text = dataGridViewClientes.SelectedRows[0].Cells[23].Value.ToString();
            txbEmail.Text = dataGridViewClientes.SelectedRows[0].Cells[24].Value.ToString();
            comboBoxRendaPrincipal.Text = dataGridViewClientes.SelectedRows[0].Cells[25].Value.ToString();
            txbMediaPorKGProduto.Text = dataGridViewClientes.SelectedRows[0].Cells[26].Value.ToString();
            txbQtdPescadoMes.Text = dataGridViewClientes.SelectedRows[0].Cells[27].Value.ToString();
            txbRendaBruta.Text = dataGridViewClientes.SelectedRows[0].Cells[28].Value.ToString();
            txbRendaLiquida.Text = dataGridViewClientes.SelectedRows[0].Cells[29].Value.ToString();
            txbOutrasFontasDeRenda.Text = dataGridViewClientes.SelectedRows[0].Cells[30].Value.ToString();
            txbValorRendaExtra.Text = dataGridViewClientes.SelectedRows[0].Cells[31].Value.ToString();
            lblValorDespesaPorDependentes.Text = dataGridViewClientes.SelectedRows[0].Cells[32].Value.ToString();
            txbObservacoesFinanceiras.Text = dataGridViewClientes.SelectedRows[0].Cells[33].Value.ToString();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            //lblCodigoMatricula.Text = "* * * * * *";
            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbDataNascimento.Enabled = true;
            txbRG.Enabled = true;
            txbDataEmissaoRG.Enabled = true;
            comboBoxUFRG.Enabled = true;
            comboBoxNacionalidade.Enabled = true;
            comboBoxSexo.Enabled = true;
            pictureBoxBandeiras.Visible = true;
            comboBoxQtDependentes.Enabled = true;
            txbLogradouro.Enabled = true;
            txbNumero.Enabled = true;
            txbComplemento.Enabled = true;
            txbBairro.Enabled = true;
            txbCep.Enabled = true;
            comboBoxEndEstados.Enabled = true;
            comboBoxMunicipio.Enabled = true;
            pictureBoxMapas.Visible = true;
            txbTelefone.Enabled = true;
            txbCelular.Enabled = true;
            txbFax.Enabled = true;
            txbEmail.Enabled = true;
            comboBoxRendaPrincipal.Enabled = true;
            txbMediaPorKGProduto.Enabled = true;
            txbQtdPescadoMes.Enabled = true;
            txbRendaBruta.Enabled = true;
            txbRendaLiquida.Enabled = true;
            txbOutrasFontasDeRenda.Enabled = true;
            txbValorRendaExtra.Enabled = true;
            txbObservacoesFinanceiras.Enabled = true;

        }

        private void AtualizarCadastro()
        {
            if (txbNome.Text == "" || comboBoxUFRG.Text == "" || comboBoxNacionalidade.Text == "" || comboBoxSexo.Text == "" || comboBoxQtDependentes.Text == "" || txbLogradouro.Text == "" || txbNumero.Text == "" || txbBairro.Text == "" || comboBoxEndEstados.Text == "" || comboBoxMunicipio.Text == "" || comboBoxRendaPrincipal.Text == "" || txbMediaPorKGProduto.Text == "" || txbQtdPescadoMes.Text == "" || txbRendaBruta.Text == "" || txbRendaLiquida.Text == "")
            {
                MessageBox.Show("Os campos OBRIGATÓRIOS (*) não podem ficar em branco", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Seção de variáveis
                string NOME = txbNome.Text, CPF = txbCPF.Text, NASCIMENTO = txbDataNascimento.Text, RG = txbRG.Text, EMISSAO_RG = txbDataEmissaoRG.Text, UF_RG = comboBoxUFRG.Text, NACIONALIDADE = comboBoxNacionalidade.Text, SEXO = comboBoxSexo.Text, CAPITAL = lblResultadoCAPITAL.Text, SIGLA = lblResultadoSigla.Text, REGIAO = lblRegiao.Text, DEPENDENTES = comboBoxQtDependentes.Text, LOGRADOURO = txbLogradouro.Text, NUMERO = txbNumero.Text, COMPLEMENTO = txbComplemento.Text, BAIRRO = txbBairro.Text, CEP = txbCep.Text, ESTADO = comboBoxEndEstados.Text, UF = lblEndUFSigla.Text, MUNICIPIO = comboBoxMunicipio.Text, TELEFONE = txbTelefone.Text, CELULAR = txbCelular.Text, FAX = txbFax.Text, EMAIL = txbEmail.Text, RENDA_PRINCIPAL = comboBoxRendaPrincipal.Text, OUTRAS_FONTES_RENDA = txbOutrasFontasDeRenda.Text, DESPESAS_DEPENDENTES = lblValorDespesaPorDependentes.Text, STATUS_FINANCIAMENTO = txbObservacoesFinanceiras.Text;
                decimal MEDIA_KG_PRODUTO = 0, RENDA_BRUTA = 0, RENDA_LIQUIDA = 0, VALOR_OUTRAS_RENDAS = 0;
                int MEDIA_QTDKG_PESCADO = 0, mediaQtdPescadoMes = Convert.ToInt32(txbQtdPescadoMes.Text), id = Convert.ToInt32(lblCodigoMatricula.Text);

                decimal mediaKgProduto = Convert.ToDecimal(txbMediaPorKGProduto.Text);
                decimal rendaBruta = Convert.ToDecimal(txbRendaBruta.Text);
                decimal rendaLiquida = Convert.ToDecimal(txbRendaLiquida.Text);
                decimal rendaExtra = Convert.ToDecimal(txbValorRendaExtra.Text);

                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                    {
                        conexao.Open();
                        var sqlQuery = "update Cadastro_de_clientes set NOME = @NOME, CPF= @CPF, NASCIMENTO= @NASCIMENTO, RG= @RG, EMISSAO_RG= @EMISSAO_RG, UF_RG= @UF_RG, NACIONALIDADE= @NACIONALIDADE, SEXO= @SEXO, CAPITAL= @CAPITAL, SIGLA= @SIGLA, REGIAO= @REGIAO, DEPENDENTES= @DEPENDENTES, LOGRADOURO= @LOGRADOURO, NUMERO= @NUMERO, COMPLEMENTO= @COMPLEMENTO, BAIRRO= @BAIRRO, CEP= @CEP, ESTADO= @ESTADO, UF= @UF, MUNICIPIO= @MUNICIPIO, TELEFONE= @TELEFONE,CELULAR= @CELULAR, FAX= @FAX, EMAIL= @EMAIL,  RENDA_PRINCIPAL= @RENDA_PRINCIPAL, MEDIA_KG_PRODUTO= @MEDIA_KG_PRODUTO, MEDIA_QTDKG_PESCADO= @MEDIA_QTDKG_PESCADO, RENDA_BRUTA= @RENDA_BRUTA, RENDA_LIQUIDA= @RENDA_LIQUIDA,OUTRAS_FONTES_RENDA= @OUTRAS_FONTES_RENDA, VALOR_OUTRAS_RENDAS= @VALOR_OUTRAS_RENDAS, DESPESAS_DEPENDENTES= @DESPESAS_DEPENDENTES, STATUS_FINANCIAMENTO= @STATUS_FINANCIAMENTO where CODIGO = @id";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, conexao))
                        {
                            //Parâmetros
                            cmd.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = NOME;
                            cmd.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = CPF;
                            cmd.Parameters.Add("@NASCIMENTO", System.Data.SqlDbType.VarChar).Value = NASCIMENTO;
                            cmd.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = RG;
                            cmd.Parameters.Add("@EMISSAO_RG", System.Data.SqlDbType.VarChar).Value = EMISSAO_RG;
                            cmd.Parameters.Add("@UF_RG", System.Data.SqlDbType.VarChar).Value = UF_RG;
                            cmd.Parameters.Add("@NACIONALIDADE", System.Data.SqlDbType.VarChar).Value = NACIONALIDADE;
                            cmd.Parameters.Add("@SEXO", System.Data.SqlDbType.VarChar).Value = SEXO;
                            cmd.Parameters.Add("@CAPITAL", System.Data.SqlDbType.VarChar).Value = CAPITAL;
                            cmd.Parameters.Add("@SIGLA", System.Data.SqlDbType.Char).Value = SIGLA;
                            cmd.Parameters.Add("@REGIAO", System.Data.SqlDbType.VarChar).Value = REGIAO;
                            cmd.Parameters.Add("@DEPENDENTES", System.Data.SqlDbType.VarChar).Value = DEPENDENTES;
                            cmd.Parameters.Add("@LOGRADOURO", System.Data.SqlDbType.VarChar).Value = LOGRADOURO;
                            cmd.Parameters.Add("@NUMERO", System.Data.SqlDbType.VarChar).Value = NUMERO;
                            cmd.Parameters.Add("@COMPLEMENTO", System.Data.SqlDbType.VarChar).Value = COMPLEMENTO;
                            cmd.Parameters.Add("@BAIRRO", System.Data.SqlDbType.VarChar).Value = BAIRRO;
                            cmd.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = CEP;
                            cmd.Parameters.Add("@ESTADO", System.Data.SqlDbType.VarChar).Value = ESTADO;
                            cmd.Parameters.Add("@UF", System.Data.SqlDbType.Char).Value = UF;
                            cmd.Parameters.Add("@MUNICIPIO", System.Data.SqlDbType.VarChar).Value = MUNICIPIO;
                            cmd.Parameters.Add("@TELEFONE", System.Data.SqlDbType.VarChar).Value = TELEFONE;
                            cmd.Parameters.Add("@CELULAR", System.Data.SqlDbType.VarChar).Value = CELULAR;
                            cmd.Parameters.Add("@FAX", System.Data.SqlDbType.VarChar).Value = FAX;
                            cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = EMAIL;
                            cmd.Parameters.Add("@RENDA_PRINCIPAL", System.Data.SqlDbType.VarChar).Value = RENDA_PRINCIPAL;
                            cmd.Parameters.Add("@MEDIA_KG_PRODUTO", System.Data.SqlDbType.Decimal).Value = MEDIA_KG_PRODUTO;
                            cmd.Parameters.Add("@MEDIA_QTDKG_PESCADO", System.Data.SqlDbType.Int).Value = MEDIA_QTDKG_PESCADO;
                            cmd.Parameters.Add("@RENDA_BRUTA", System.Data.SqlDbType.Decimal).Value = RENDA_BRUTA;
                            cmd.Parameters.Add("@RENDA_LIQUIDA", System.Data.SqlDbType.Decimal).Value = RENDA_LIQUIDA;
                            cmd.Parameters.Add("@OUTRAS_FONTES_RENDA", System.Data.SqlDbType.VarChar).Value = OUTRAS_FONTES_RENDA;
                            cmd.Parameters.Add("@VALOR_OUTRAS_RENDAS", System.Data.SqlDbType.Decimal).Value = VALOR_OUTRAS_RENDAS;
                            cmd.Parameters.Add("@DESPESAS_DEPENDENTES", System.Data.SqlDbType.VarChar).Value = DESPESAS_DEPENDENTES;
                            cmd.Parameters.Add("@STATUS_FINANCIAMENTO", System.Data.SqlDbType.VarChar).Value = STATUS_FINANCIAMENTO;
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Cadastro atualizado com sucesso!", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException errorConexao)
                {
                    MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{errorConexao}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DesabilitarBotoes()
        {
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void HabilitarBotoes()
        {
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void AreaDoPescador_Load(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            DesabilitarLimparCaixas();
        }

        private void DesabilitarLimparCaixas()
        {
            lblCodigoMatricula.Text = "* * * * * *";
            txbNome.Enabled = false;
            txbCPF.Enabled = false;
            txbDataNascimento.Enabled = false;
            txbRG.Enabled = false;
            txbDataEmissaoRG.Enabled = false;
            comboBoxUFRG.Enabled = false;
            comboBoxNacionalidade.Enabled = false;
            comboBoxSexo.Enabled = false;
            lblResultadoCAPITAL.Text = "* * * * * * * * * * * *";
            lblResultadoSigla.Text = "* * * * * *";
            pictureBoxBandeiras.Visible = false;
            lblRegiao.Text = "* * * * * * * * * * * *";
            comboBoxQtDependentes.Enabled = false;
            txbLogradouro.Enabled = false;
            txbNumero.Enabled = false;
            txbComplemento.Enabled = false;
            txbBairro.Enabled = false;
            txbCep.Enabled = false;
            comboBoxEndEstados.Enabled = false;
            comboBoxMunicipio.Enabled = false;
            lblEndUFSigla.Text = "* * * * * *";
            pictureBoxMapas.Visible = false;
            txbTelefone.Enabled = false;
            txbCelular.Enabled = false;
            txbFax.Enabled = false;
            txbEmail.Enabled = false;
            comboBoxRendaPrincipal.Enabled = false;
            txbMediaPorKGProduto.Enabled = false;
            txbQtdPescadoMes.Enabled = false;
            txbRendaBruta.Enabled = false;
            txbRendaLiquida.Enabled = false;
            txbOutrasFontasDeRenda.Enabled = false;
            txbValorRendaExtra.Enabled = false;
            lblValorDespesaPorDependentes.Text = "0,00";
            txbObservacoesFinanceiras.Enabled = false;
            //Limpar os textBoxs
            txbNome.Text = string.Empty;
            txbCPF.Text = string.Empty;
            txbDataNascimento.Text = string.Empty;
            txbRG.Text = string.Empty;
            txbDataEmissaoRG.Text = string.Empty;
            comboBoxUFRG.Text = string.Empty;
            comboBoxNacionalidade.Text = string.Empty;
            comboBoxSexo.Text = string.Empty;
            comboBoxQtDependentes.Text = string.Empty;
            txbLogradouro.Text = string.Empty;
            txbNumero.Text = string.Empty;
            txbComplemento.Text = string.Empty;
            txbBairro.Text = string.Empty;
            txbCep.Text = string.Empty;
            comboBoxEndEstados.Text = string.Empty;
            comboBoxMunicipio.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            txbCelular.Text = string.Empty;
            txbFax.Text = string.Empty;
            txbEmail.Text = string.Empty;
            comboBoxRendaPrincipal.Text = string.Empty;
            txbMediaPorKGProduto.Text = string.Empty;
            txbQtdPescadoMes.Text = string.Empty;
            txbRendaBruta.Text = string.Empty;
            txbRendaLiquida.Text = string.Empty;
            txbOutrasFontasDeRenda.Text = string.Empty;
            txbValorRendaExtra.Text = string.Empty;
            txbObservacoesFinanceiras.Text = string.Empty;
        }

        private void HabilitarLimparCaixas()
        {
            lblCodigoMatricula.Text = "* * * * * *";
            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbDataNascimento.Enabled = true;
            txbRG.Enabled = true;
            txbDataEmissaoRG.Enabled = true;
            comboBoxUFRG.Enabled = true;
            comboBoxNacionalidade.Enabled = true;
            comboBoxSexo.Enabled = true;
            lblResultadoCAPITAL.Text = "* * * * * * * * * * * *";
            lblResultadoSigla.Text = "* * * * * *";
            pictureBoxBandeiras.Visible = true;
            lblRegiao.Text = "* * * * * * * * * * * *";
            comboBoxQtDependentes.Enabled = true;
            txbLogradouro.Enabled = true;
            txbNumero.Enabled = true;
            txbComplemento.Enabled = true;
            txbBairro.Enabled = true;
            txbCep.Enabled = true;
            comboBoxEndEstados.Enabled = true;
            comboBoxMunicipio.Enabled = true;
            lblEndUFSigla.Text = "* * * * * *";
            pictureBoxMapas.Visible = true;
            txbTelefone.Enabled = true;
            txbCelular.Enabled = true;
            txbFax.Enabled = true;
            txbEmail.Enabled = true;
            comboBoxRendaPrincipal.Enabled = true;
            txbMediaPorKGProduto.Enabled = true;
            txbQtdPescadoMes.Enabled = true;
            txbRendaBruta.Enabled = true;
            txbRendaLiquida.Enabled = true;
            txbOutrasFontasDeRenda.Enabled = true;
            txbValorRendaExtra.Enabled = true;
            lblValorDespesaPorDependentes.Text = "0,00";
            txbObservacoesFinanceiras.Enabled = true;
            //Limpar os textBoxs
            txbNome.Text = string.Empty;
            txbCPF.Text = string.Empty;
            txbDataNascimento.Text = string.Empty;
            txbRG.Text = string.Empty;
            txbDataEmissaoRG.Text = string.Empty;
            comboBoxUFRG.Text = string.Empty;
            comboBoxNacionalidade.Text = string.Empty;
            comboBoxSexo.Text = string.Empty;
            comboBoxQtDependentes.Text = string.Empty;
            txbLogradouro.Text = string.Empty;
            txbNumero.Text = string.Empty;
            txbComplemento.Text = string.Empty;
            txbBairro.Text = string.Empty;
            txbCep.Text = string.Empty;
            comboBoxEndEstados.Text = string.Empty;
            comboBoxMunicipio.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            txbCelular.Text = string.Empty;
            txbFax.Text = string.Empty;
            txbEmail.Text = string.Empty;
            comboBoxRendaPrincipal.Text = string.Empty;
            txbMediaPorKGProduto.Text = string.Empty;
            txbQtdPescadoMes.Text = string.Empty;
            txbRendaBruta.Text = string.Empty;
            txbRendaLiquida.Text = string.Empty;
            txbOutrasFontasDeRenda.Text = string.Empty;
            txbValorRendaExtra.Text = string.Empty;
            txbObservacoesFinanceiras.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarLimparCaixas();
            btnNovo.Enabled = true;
            DesabilitarBotoes();
            dataGridViewClientes.Visible = false;
            txbCPFPesquisa.Text = string.Empty;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            HabilitarLimparCaixas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblCodigoMatricula.Text);

            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.Conectar))
                {
                    conexao.Open();
                    var sqlExcluir = "delete from Cadastro_de_clientes where CODIGO = @id";
                    using (SqlCommand cmd = new SqlCommand(sqlExcluir, conexao))
                    {
                        cmd.Parameters.Add("id",System.Data.SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        MessageBox.Show("Cadastro realizado com sucesso!", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DesabilitarLimparCaixas();
                        DesabilitarBotoes();
                        dataGridViewClientes.Visible = false;
                        txbCPFPesquisa.Text = string.Empty;
                        btnNovo.Enabled = true;
                    }
                }
            }catch(SqlException error)
            {
                MessageBox.Show($"Falha ao se conectar com o banco de dados.\nDetalhes do erro:\n{error}", "Spark informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
