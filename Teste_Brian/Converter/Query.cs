using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Teste_Brian.Context;
using Teste_Brian.Entities;

namespace Teste_Brian.Converter
{
    class Query
    {
        Conexao con = new Conexao();
        SystemContext context = new SystemContext();

        public void ConverterBanco()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"Select * From cadastro";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            var entidade = new List<Entidade>();
            foreach (DataRow row in dt.Rows)
            {
                entidade.Add(new Entidade
                {
                    Id = Convert.ToInt32(row["seq"]),
                    Nome = row["nomeCompleto"].ToString(),
                    Cpf = row["cpfCnpj"].ToString(),
                    DtNasc = Convert.ToDateTime(row["dtNasc"]),
                    DtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    PessoaFisica = true,
                    Identificador = Guid.NewGuid(),
                    Endereco = new Endereco
                    {
                        TipoLogradouro = row["tEndereco"].ToString(),
                        Logradouro = row["logradouro"].ToString(),
                        Numero = Convert.ToInt32(row["nro"]),
                        Bairro = row["bairro"].ToString(),
                        Municipio = row["cidade"].ToString(),
                        Uf = row["uf"].ToString(),
                        Cep = row["cep"].ToString(),
                    },
                    Telefone = new Telefone
                    {
                        Ddd1 = row["ddd1"].ToString(),
                        Numero1 = row["fone1"].ToString(),
                        Ddd2 = row["ddd2"].ToString(),
                        Numero2 = row["fone2"].ToString(),
                        Cel = row["cel"].ToString()
                    },
                    Email = new Email
                    {
                        Endereco = row["email"].ToString()
                    }
                });
            }

            foreach (var e in entidade)
            {
                e.Cpf = e.Cpf.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
                e.Endereco.Cep = e.Endereco.Cep.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
                e.Telefone.Numero1 = e.Telefone.Numero1.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
                e.Telefone.Numero2 = e.Telefone.Numero2.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
                e.Telefone.Cel = e.Telefone.Cel.Replace(".", "").Replace("-", "").Replace("/", "").Trim();

                if (e.Endereco.Bairro.Length > 15)
                    e.Endereco.Bairro = e.Endereco.Bairro.Substring(0, 15);

                if (e.Cpf.Length != 11 && e.Cpf.Length != 14)
                {
                    if (e.Cpf.Length > 14)
                        e.Cnpj = e.Cpf.Substring(0, 14);
                    else if (string.IsNullOrEmpty(e.Cpf))
                        e.Cpf = new string('0', 11);
                    else
                        e.Cpf = e.Cpf.Substring(0, 11);
                }
                else if (e.Cpf.Length == 14)
                {
                    e.Cnpj = e.Cpf;
                    e.Cpf = null;
                }

                if (e.Endereco.Cep.Length > 8)
                    e.Endereco.Cep = e.Endereco.Cep.Substring(0, 8);
                else if (e.Endereco.Cep.Length < 8)
                    e.Endereco.Cep = e.Endereco.Cep += new string('0', 8 - e.Endereco.Cep.Length);
            }
            context.Entidade.AddRange(entidade);
            context.SaveChanges();
            con.Desconectar();
        }
    }
}
