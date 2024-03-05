using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoniaDePescadores
{
    public partial class FrmMenu : Form
    {
        Thread t1;
        public FrmMenu()
        {
            InitializeComponent();
            ImagemInicial imagemInicial = new ImagemInicial();
            Area_do_Pescador(imagemInicial);
        }

        private void Area_do_Pescador(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelDePaginas.Controls.Clear();
            panelDePaginas.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CarregarImagemInicial()
        {
            ImagemInicial imagemInicial = new ImagemInicial();
            Area_do_Pescador(imagemInicial);
        }

        private void pictureBoxLogo_Click_1(object sender, EventArgs e)
        {
            CarregarImagemInicial();
        }

        private void btnAreaPescador_Click_1(object sender, EventArgs e)
        {
            AreaDoPescador paginaCadastro = new AreaDoPescador();
            Area_do_Pescador(paginaCadastro);
        }

        private void btnFinanciamento_Click(object sender, EventArgs e)
        {
            Financiamento financiamento = new Financiamento();
            Area_do_Pescador(financiamento);
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            Colaboradores colaboradores = new Colaboradores();
            Area_do_Pescador(colaboradores);
        }

        private void btnParceiros_Click(object sender, EventArgs e)
        {
            Parceiros parceiros = new Parceiros();
            Area_do_Pescador(parceiros);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new Login());
        }
    }
}
