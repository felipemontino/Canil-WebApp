using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Entidades
{
    public class Cachorro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string CaminhoArquivo { get; set; }

        public int Idade { get; set; }

        public virtual Raca Raca { get; set; }

        public virtual Compra Compra { get; set; }
    }
}
