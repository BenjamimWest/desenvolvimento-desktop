using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;

namespace MultApps.Windows
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CarregarTodasCategorias(); 
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                var usuario = new Usuario();
            
            }
            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbFiltrar.SelectedIndex;
            
            var categoriaRepository = new CategoriaRepository();
            var resultado = categoriaRepository.CadastrarCategoria(categoria);
            if (resultado)
            {
                MessageBox.Show("Categoria cadastra com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar categoria");
            }
        }

        private void CarregarTodasCategorias()
        {
            var categoriaRepository = new CategoriaRepository();
            var ListaDeCategorias = categoriaRepository.listarTodasCategorias();
            dataGridView1.DataSource = ListaDeCategorias;
            

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200,
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da Categoria",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadrastro",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracaoo",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });

            dataGridView1.DataSource = ListaDeCategorias;
            
            
        }
    }
    private bool ValidadrSeCamposEstaoPreenchidos()
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text))
        {
            MessageBox.Show("Campo Nome é obrigatório");
            return false;
        }
        if (cmbFiltrar.SelectedIndex == -1)
        {
            MessageBox.Show("Campo Status é obrigatório");
            return false;
        }
        return true;
}

