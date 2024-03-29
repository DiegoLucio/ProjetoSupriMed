﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class VisitasDTO
    {
        public int VIS_ID { get; set; }
        public int VEND_ID { get; set; }
        public System.DateTime VIS_DATA { get; set; }
        public byte[] VIS_HORA { get; set; }
        public string VIS_DESCRICAO { get; set; }

        public virtual VendedoresDTO VENDEDORES { get; set; }
    }
}
