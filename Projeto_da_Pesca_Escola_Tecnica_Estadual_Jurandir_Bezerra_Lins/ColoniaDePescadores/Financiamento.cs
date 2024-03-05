using ColoniaDePescadores.Simulador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoniaDePescadores
{
    public partial class Financiamento : UserControl
    {
        public Financiamento()
        {
            InitializeComponent();
        }

        private void pictureBoxMotorHonda_Click(object sender, EventArgs e)
        {
            FormProduto1 formProduto1 = new FormProduto1();
            formProduto1.ShowDialog();
        }

        private void pictureBoxRabetaLongaTurboTornado_Click(object sender, EventArgs e)
        {
            FormProduto2 formProduto2 = new FormProduto2();
            formProduto2.ShowDialog();

        }

        private void pictureBoxMotorDeRabetaBristol_Click(object sender, EventArgs e)
        {
            FormProduto3 formProduto3 = new FormProduto3();
            formProduto3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormProduto4 formProduto4 = new FormProduto4();
            formProduto4.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormProduto5 formProduto5 = new FormProduto5();
            formProduto5.ShowDialog();
        }

        private void btnSimular1_Click(object sender, EventArgs e)
        {
            string produto = "Motor a Diesel Branco BD10.0H G2 - Partida Manual", valorFinanciado = lblValor1.Text, codigoProduto = "90311901", codigoFile = "2259";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular2_Click(object sender, EventArgs e)
        {
            string produto = "Motor a Diesel Branco 10HP BD 10.0 G2 H - Partida Eletica", valorFinanciado = lblValor2.Text, codigoProduto = "90311907", codigoFile = "1956";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular3_Click(object sender, EventArgs e)
        {
            string produto = "Motor a Diesel Branco BD7.0H G2 - Partida Eletrica", valorFinanciado = lblValor3.Text, codigoProduto = "90311805", codigoFile = "2343";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular4_Click(object sender, EventArgs e)
        {
            string produto = "Motor Diesel BD13.0H - Partida Eletrica", valorFinanciado = lblValor4.Text, codigoProduto = "90314193", codigoFile = "2429";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular5_Click(object sender, EventArgs e)
        {
            string produto = "Motor Disel BD7.0H G2 - Partida Manual", valorFinanciado = lblValor5.Text, codigoProduto = "90311805", codigoFile = "2258";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular6_Click(object sender, EventArgs e)
        {
            string produto = "", valorFinanciado = lblValor6.Text, codigoProduto = "", codigoFile = "";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular7_Click(object sender, EventArgs e)
        {
            string produto = "", valorFinanciado = lblValor7.Text, codigoProduto = "", codigoFile = "";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular8_Click(object sender, EventArgs e)
        {
            string produto = "", valorFinanciado = lblValor8.Text, codigoProduto = "", codigoFile = "";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular9_Click(object sender, EventArgs e)
        {
            string produto = "", valorFinanciado = lblValor9.Text, codigoProduto = "", codigoFile = "";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }

        private void btnSimular10_Click(object sender, EventArgs e)
        {
            string produto = "", valorFinanciado = lblValor10.Text, codigoProduto = "", codigoFile = "";
            using (FormFinanciamento formFinanciamento = new FormFinanciamento(produto, valorFinanciado, codigoProduto, codigoFile))
            {
                formFinanciamento.ShowDialog();
            }
        }
    }
}
