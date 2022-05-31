using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace PVendas
{

    //Alunos Antonio Carlos Fernandes Gomes Filho e Elais Marques Rocha
    //RA dos Alunos: 0030482121008 e 0030482121049

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int N = 8; 
            int i,j;
            double[,] PVendas = new double[N, 4];
            string aux;
            double semanaVendas;
            double mesVendas = 0;
            double TotalmesVendas = 0;
            

            for(i=0;i<N;i++)
            {
                for(j=0;j<4;j++)
                {
                    aux = Interaction.InputBox("Digite o total da semana " + (j + 1) + " do mês " + (i + 1), "Entrada dos Valores");

                    if(!double.TryParse(aux, out PVendas[i,j]))
                    {
                        MessageBox.Show("Valor Invalido");

                        j--;
                    }
                    semanaVendas = PVendas[i, j];
                    lisbxrelatorio.Items.Add("Total do Mês " + (i + 1) + " Semana "+(j+1)+" : R$" + semanaVendas.ToString("N2"));

                    mesVendas += PVendas[i, j];

                }
                lisbxrelatorio.Items.Add(">>Total Mês R$" + mesVendas.ToString("N2"));
                mesVendas = 0;
                lisbxrelatorio.Items.Add("---------------------------------");
            }
            for(i=0;i<N;i++)
            {
                for(j=0;j<4;j++)
                {
                    TotalmesVendas += PVendas[i, j];
                }
            }
            lisbxrelatorio.Items.Add(">>Total Geral R$" + TotalmesVendas.ToString("N2"));
            
        }
    }
}
