using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Brian.Entities
{
    class Email
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public virtual Entidade Entidade { get; set; }
    }
}
