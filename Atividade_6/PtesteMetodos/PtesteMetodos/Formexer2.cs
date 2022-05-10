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
    public partial class Formexer2 : Form
    {
        public Formexer2()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtBxPalavra1.Text, txtBxPalavra2.Text, true) == 0)
            {
                MessageBox.Show("Palavras Iguais!");
            }
            else
            {
                MessageBox.Show("Palavras Diferentes!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int meio = txtBxPalavra2.Text.Length / 2;

            txtBxPalavra2.Text = txtBxPalavra2.Text.Substring(0, meio) + 
                txtBxPalavra1.Text + txtBxPalavra2.Text.Substring(meio, txtBxPalavra2.Text.Length - meio);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int meio = txtBxPalavra1.Text.Length / 2;

            txtBxPalavra2.Text = txtBxPalavra1.Text.Insert(meio, "**"); 
        }
    }
}
