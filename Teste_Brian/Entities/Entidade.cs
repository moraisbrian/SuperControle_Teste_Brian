using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Brian.Entities
{
    class Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime DtNasc { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool PessoaFisica { get; set; }
        public Guid Identificador { get; set; }
        public virtual Email Email { get; set; }
        public virtual Telefone Telefone { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
