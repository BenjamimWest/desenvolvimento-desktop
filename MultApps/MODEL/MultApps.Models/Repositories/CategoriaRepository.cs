using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;

namespace MultApps.Models.Repositories
{
    public class CategoriaRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=SuperSenha@10";


        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status)
                                   VALUES(@Nome, @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
                
            }
        }

        public List<Categoria> listarTodas(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT*FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;

            }
            
    }
}
