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
            cmbIdade.Visible = true;
            lblIdade2.Visible = true;

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            lblIdade2.Visible = false;


        }
        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkMasculino.Checked = true;
            chkFeminino.Checked = false;
            
        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkFeminino.Checked = true;
            chkMasculino.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (chkAdulto.Checked && chkMasculino.Checked) ;
            {
                #region Adulto Masculino

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);
                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC : {imc:N2} é";
                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} é abaixo do normal";
                    pictureBox1.Load(ImcImagem.masculinoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} é normal";
                    pictureBox1.Load(ImcImagem.masculinoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Está Sobrepeso";
                    pictureBox1.Load(ImcImagem.masculinoSobrePeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau I";
                    pictureBox1.Load(ImcImagem.masculinoObsidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau II";
                    pictureBox1.Load(ImcImagem.masculinoObsidadeGrau2);
                }
                else if (imc < 40.0)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau III";
                    pictureBox1.Load(ImcImagem.masculinoObsidadeGrau3);
                }
                #endregion
            }
            if (chkAdulto.Checked && chkFeminino.Checked) ;
            {
                #region Adulto Femino
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);
                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC : {imc:N2} é";
                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} é abaixo do normal";
                    pictureBox1.Load(ImcImagem.femininoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} é normal";
                    pictureBox1.Load(ImcImagem.femininoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Está Sobrepeso";
                    pictureBox1.Load(ImcImagem.femininoSobrePeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau I";
                    pictureBox1.Load(ImcImagem.femininoObsidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau II";
                    pictureBox1.Load(ImcImagem.femininoObsidadeGrau2);
                }
                else if (imc < 40.0)
                {
                    lblResultadoImc.Text = $@"{textoBase} Nível Obesidade Grau III";
                    pictureBox1.Load(ImcImagem.femininoObsidadeGrau3);
                }
                #endregion
            }
            
        }

        
    }
}
