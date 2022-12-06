using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova06122022.Models
{

    
        public class Fornecedor
        {
            [Key]
            public long FornecedorId { get; set; }

            public string Nome { get; set; }

            [EmailAddress(ErrorMessage = "E-mail Inválido")]
            public String Email { get; set; }

            public String Logradouro { get; set; }

            public string Numero { get; set; }

            public String Complemento { get; set; }

            public String Bairro { get; set; }

            public String Cidade { get; set; }

            public ICollection<Produto> Produto { set; get; }
        }    
}


