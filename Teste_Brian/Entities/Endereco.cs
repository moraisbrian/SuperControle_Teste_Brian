using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Brian.Entities
{
    class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string TipoLogradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public virtual Entidade Entidade { get; set; }
    }
}
