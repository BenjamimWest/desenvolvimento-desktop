using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    public class CriptografiaService
    {
        public string Criptografar(string senha)

        {
            var bytes = Encoding.UTF8.GetBytes(senha);
            var hash = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public bool CompararSenhas(string senha, string senhaCriptografada)
        {
            var senhaCriptografadaNova = Criptografar(senha);
            return senhaCriptografada == senhaCriptografadaNova;
        }
    }
}
