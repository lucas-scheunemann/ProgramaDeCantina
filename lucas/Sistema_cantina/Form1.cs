using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_cantina
{
	public partial class Form1 : Form
	{

		string[] produtos = new string[6];
		string[] codigo = new string[6];
		double[] valor = new double[6];
		double soma;
		
			


		public Form1()
		{
			InitializeComponent();
			codigo[1] = "001";
			codigo[2] = "002";
			codigo[3] = "003";
			codigo[4] = "004";
			codigo[5] = "005";
			produtos[1] = "Pastel";
			produtos[2] = "Coxinha";
			produtos[3] = "Hot_Dog";
			produtos[4] = "Chocolate";
			produtos[5] = "Suco";
			valor[1] = 6.00;
			valor[2] = 5.00;
			valor[3] = 12.00;
			valor[4] = 3.50;
			valor[5] = 8.00;
		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
		{
			if (txtCodigo.Text.Length == 3)
			/*inicia com uma condição, se o usuário digitar um código com 5
			caracteres (length),
			esse código é adicionado ao listBox.
			A propriedade length retorna a quantidade de caracteres.*/
			{
				int indice = 0;
				for (int prod = 1; prod < codigo.Length; prod++)
				/*Faça enquanto o prod for menor ou igual a qtde de itens do array
				*/
				{
					if (txtCodigo.Text == codigo[prod])
					{
						indice = prod;
					}
				}
				if (indice == 0)
				{
					MessageBox.Show("Produto não encontrado");
				}
				else
				{
					lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice]
					+ "-- R$ " + valor[indice]);
					/* Conteúdo adicionado no ListBox, concatena (+) as
					informaçôes (código/nome/valor)*/
					soma = soma + valor[indice];
					lblTotal.Text = ("Valor Total R$ " + soma);
					txtCodigo.Text = "";
					txtCodigo.Focus();
					/*localização da imagem que deve ser colocada em uma pasta em
					c: em uma pasta imagens
					o textbox será limpo e o Focus posiciona o cursor
					para o TextBox para uma nova digitação*/
				}
			}
		}
	}
}
