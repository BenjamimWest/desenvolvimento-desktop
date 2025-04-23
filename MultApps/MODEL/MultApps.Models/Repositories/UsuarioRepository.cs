using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    internal class UsuarioRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=SuperSenha@10";
        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status,)
                                   VALUES(@Nome, @Status, )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;

               
                {
                    var comandoSql = @"SELECT * FROM usuario";
                    var usuarios = db.Query<Usuario>("SELECT * FROM usuario").ToList();
                   var dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("Nome", typeof(string));
                    dataTable.Columns.Add("Email", typeof(string));
                    dataTable.Columns.Add("Senha", typeof(string));
                    dataTable.Columns.Add("Status", typeof(bool));

                    foreach (var usuario in usuarios)
                    {
                        var row = dataTable.NewRow();
                        row["Id"] = usuario.Id;
                        row["Nome"] = usuario.Nome;
                        row["Email"] = usuario.Email;
                        row["Senha"] = usuario.Senha;
                        row["Status"] = usuario.Status;
                        dataTable.Rows.Add(row);
                    }


                }
                DataTable.Rows.Add(Usuario.id,
                    Usuario.Nome,
                    Usuario.Cpf,
                    Usuario.Email,);






            }
        }
    }
}
