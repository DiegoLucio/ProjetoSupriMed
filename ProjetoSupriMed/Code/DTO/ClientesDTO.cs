using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class ClientesDTO
    {
        public ClientesDTO()
        {
            this.VENDAS = new HashSet<VendasDTO>();
        }

        public string CLI_CPF { get; set; }
        public string CLI_PRIMNOME { get; set; }
        public string CLI_ULTNOME { get; set; }
        public System.DateTime CLI_DATANASC { get; set; }
        public string CLI_EMAIL { get; set; }
        public string CLI_ENDERECO { get; set; }
        public string CLI_BAIRRO { get; set; }
        public string CLI_CIDADE { get; set; }
        public string CLI_ESTADO { get; set; }
        public decimal CLI_TELEFONE { get; set; }

        public virtual ICollection<VendasDTO> VENDAS { get; set; }
    }
}
