using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova06122022.Models
{

    
        public class Produto
        {
            [Key]
            public long ProdutoId { get; set; }

            public String Nome { get; set; }

            public String Descricao { get; set; }

            public Fornecedor Fornecedor { get; set; }

            public int? FornecedorId { get; set; }

        }
    
}

