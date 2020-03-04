using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Brian.Entities
{
    class Telefone
    {
        public int Id { get; set; }
        public string Ddd1 { get; set; }
        public string Numero1 { get; set; }
        public string Ddd2 { get; set; }
        public string Numero2 { get; set; }
        public string Cel { get; set; }
        public virtual Entidade Entidade { get; set; }
    }
}
