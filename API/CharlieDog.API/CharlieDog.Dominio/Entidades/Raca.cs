using CharlieDog.Dominio.Enums;
using System;

namespace CharlieDog.Dominio.Entidades
{
    public class Raca
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Porte Porte { get; set; }
    }
}
