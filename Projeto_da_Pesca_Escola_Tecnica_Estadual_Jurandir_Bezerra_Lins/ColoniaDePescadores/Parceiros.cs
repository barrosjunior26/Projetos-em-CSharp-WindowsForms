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
    public partial class Parceiros : UserControl
    {
        public Parceiros()
        {
            InitializeComponent();
        }

        private void linkLabelChat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send/?phone=5581985999701&text=Ol%C3%A1%2C+estou+interessado+em+saber+mais+sobre+o+projeto+Spark%21&type=phone_number&app_absent=0");
        }

        private void linkLabelInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/spark_pesca/");
        }

        private void linkLabelWhatsApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send/?phone=5581985999701&text=Ol%C3%A1%2C+estou+interessado+em+saber+mais+sobre+o+projeto+Spark%21&type=phone_number&app_absent=0");
        }
    }
}
