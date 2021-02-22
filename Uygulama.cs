using System;
using System.Windows.Forms;

namespace SharpEducator
{
    public partial class Uygulama : Form
    {
        public Uygulama()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            PLabel.Top = AnaSayfa.Top;
        }

        private void Bolumler_Click(object sender, EventArgs e)
        {
            PLabel.Top = Bolumler.Top;
        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            PLabel.Top = Ayarlar.Top;
        }

        private void Iletisim_Click(object sender, EventArgs e)
        {
            PLabel.Top = Iletisim.Top;
        }

        private void Hakkinda_Click(object sender, EventArgs e)
        {
            PLabel.Top = Hakkinda.Top;
        }
    }
}
