using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            ;

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var peso = double.Parse(textPeso.Text);
            var altura = double.Parse(textAltura.Text);
            var imc = peso / (altura * altura);
           if(imc <= 18.5)
            {
                lblResultadoImc.Text = $@"Meu IMC : {imc:N2} é abaixo do normal";
            }
           else if (imc < 24.9)
            {
                lblResultadoImc.Text = $@"Meu IMC : {imc:N2} é normal";
            }
           else if (imc < 29.9)
            {
                lblResultadoImc.Text = $@"Meu IMC : {imc:N2} Está Sobrepeso";
            }
            else if (imc < 34.9)
            {
                lblResultadoImc.Text = $@"Meu IMC : {imc:N2} Nível Obesidade Grau I";
            }
            else if (imc < 39.9)
            {
                lblResultadoImc.Text = $@"Meu IMC : {:N2} Nível Obesidade Grau II";
            }
            else if (imc < 40.0)
            {
                lblResultadoImc.Text = $@"Meu IMC : {imc:N2} Nível Obesidade Grau III";
            }
        }
    }
}
