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
            if (chkAdulto.Checked && chkMasculino.Checked)
                #region Adulto Masculino

            var peso = double.Parse(textPeso.Text);
            var altura = double.Parse(textAltura.Text);
            var imc = peso / (altura * altura);
            var textoBase = $@"Meu IMC : {imc:N2} é";
           if(imc <= 18.5)
            {
                lblResultadoImc.Text = $@"{textoBase} é abaixo do normal";
            }
           else if (imc < 24.9)
            {
                lblResultadoImc.Text = $@"{textoBase} é normal";
            }
           else if (imc < 29.9)
            {
                lblResultadoImc.Text = $@"{textoBase} Está Sobrepeso";
            }
            else if (imc < 34.9)
            {
                lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau I";
            }
            else if (imc < 39.9)
            {
                lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau II";
            }
            else if (imc < 40.0)
            {
                lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau III";
            }
            #endregion
        }

        private string ManipuladorDeImagem(string grau)
        {
            switch (grau)
            {
                case "abaixo do normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_06.png.webp"
                 case "normal":
                    return ""


            }
        }
            
        
            
  
    }
}
