using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharlieDog.WebAPI.Models
{
    public class CompraModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string EnderecoEntrega { get; set; }
        public int[] IdsCachorros { get; set; }
    }
}
