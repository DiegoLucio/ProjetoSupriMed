﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class ProdutosDTO
    {
        public ProdutosDTO()
        {
            this.VENDAS = new HashSet<VendasDTO>();
        }

        public int PROD_ID { get; set; }
        public int PEC_ID { get; set; }
        public string PROD_DESCRICAO { get; set; }
        public double PROD_PRECOCUSTO { get; set; }
        public double PROD_PRECOVENDA { get; set; }
        public string PROD_ESTOQUE { get; set; }

        public virtual PecasDTO PEÇAS { get; set; }

        public virtual ICollection<VendasDTO> VENDAS { get; set; }
    }
}
