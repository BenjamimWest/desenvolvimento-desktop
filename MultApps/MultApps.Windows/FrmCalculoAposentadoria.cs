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
    public partial class FrmCalculoAposentadoria : Form
    {
        public FrmCalculoAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = Convert.ToDateTime(lblNascimento.Text);
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;
            string sexo = cmbSexo.SelectedItem?.ToString();
            int anosContribuicao = int.Parse(txtAnoscontribucão.Text);

            bool podeAposentar = (sexo == "Masculino" && idade >= 65 && anosContribuicao >= 20) ||
                        (sexo == "Feminino" && idade >= 62 && anosContribuicao >= 15);
            lblResultado.Text = podeAposentar ? "Você pode se aposentar! 🎉" : "Ainda não está na hora! ⏳";
            lblResultado.ForeColor = podeAposentar ? Color.Green : Color.Red;

        }


    }
}
