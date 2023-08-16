using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Aula04_AppBanco
{
    public partial class Form1 : Form
    {
        //Variáveis globais
        List<string> extratos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            double valor=double.Parse(txtValor.Text);
            double saldo = double.Parse(lblSaldo.Text.Replace("R$", ""));
            double soma;
            if(lblOperacao.Text == "SAQUE")
            {
                 
                 soma = saldo-valor;
                extratos.Add("Saque no valor de R$ " + valor);
            }
            else
            {
                 soma = valor + saldo;
                extratos.Add("Deposito no valor de R$ " + valor);
            }

            
            lblSaldo.Text = "R$" + soma;
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            //Tira a cor do botão depositar
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;

            //Pinta o botão sacar
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.RoyalBlue;
            lblOperacao.Text = "SAQUE";
            
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            //Pinta o botão depositar
            btnDepositar.BackColor = Color.LightBlue; 
            btnDepositar.ForeColor = Color.RoyalBlue;

            //Tira a cor do botão sacar
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            lblOperacao.Text = "DEPOSITAR";
            
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();
        }
    }
}
