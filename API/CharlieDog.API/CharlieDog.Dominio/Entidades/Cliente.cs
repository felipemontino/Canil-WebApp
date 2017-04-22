using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
