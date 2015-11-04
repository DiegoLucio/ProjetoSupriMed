using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class VendasDTO
    {
        public int VEN_ID { get; set; }
        public string CLI_CPF { get; set; }
        public int VEND_ID { get; set; }
        public int PROD_ID { get; set; }

        public virtual ClientesDTO CLIENTES { get; set; }
        public virtual ProdutosDTO PRODUTOS { get; set; }
        public virtual VendedoresDTO VENDEDORES { get; set; }
    }
}
