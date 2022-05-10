using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtesteMetodos
{
    public partial class Formexer3 : Form
    {
        public Formexer3()
        {
            InitializeComponent();
        }

        private void btnRemOcor_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            txtboxPalavra1.Text = txtboxPalavra1.Text.ToUpper();
            txtboxPalavra2.Text = txtboxPalavra2.Text.ToUpper();

            posicao = txtboxPalavra2.Text.IndexOf(txtboxPalavra1.Text);

            while (posicao >= 0)
            {
                txtboxPalavra2.Text = txtboxPalavra2.Text.Substring(0, posicao) + txtboxPalavra2.Text.Substring(posicao + txtboxPalavra1.Text.Length,
                    txtboxPalavra2.Text.Length - posicao - txtboxPalavra1.Text.Length);
                posicao = txtboxPalavra2.Text.IndexOf(txtboxPalavra1.Text);
            }
        }

        private void btnRemOcorRe_Click(object sender, EventArgs e)
        {
            txtboxPalavra1.Text = txtboxPalavra1.Text.ToUpper();
            txtboxPalavra2.Text = txtboxPalavra2.Text.ToUpper();

            txtboxPalavra2.Text = txtboxPalavra2.Text.Replace(txtboxPalavra1.Text,"");
        }

        private void btnInvRever_Click(object sender, EventArgs e)
        {
            string auxiliar = txtboxPalavra1.Text;
            char[] arr = auxiliar.ToCharArray();
            Array.Reverse(arr);

            auxiliar = "";

            foreach (char cara in arr)
            {
                auxiliar = auxiliar + cara.ToString();
            }
            MessageBox.Show(auxiliar);
        }
    }
}
