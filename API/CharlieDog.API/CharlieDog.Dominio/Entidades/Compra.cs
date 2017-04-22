using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CharlieDog.Dominio.Entidades
{
    public class Compra
    {
        public Compra()
        {
            this.Cachorros = new HashSet<Cachorro>();
        }

        public int Id { get; set; }

        public string EnderecoEntrega { get; set; }

        public DateTime Data { get; set; }

        public int Quantidade
        {
            get
            {
                return this.Cachorros.Count;
            }
        }

        public virtual Cliente Cliente {get; set;}

        public virtual ICollection<Cachorro> Cachorros { get; set; }

        public Compra Gerar(string nomeCliente, string cpf, string enderecoDeEntrega, int[] idsCachorros)
        {
            if(!idsCachorros.Any())
            {
                throw new ArgumentException("Selecione corretamente os cachorros que deseja comprar, por favor.");
            }

            if(string.IsNullOrWhiteSpace(nomeCliente) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(enderecoDeEntrega))
            {
                throw new ArgumentException("Informe corretamente seus dados de cliente, por favor.");
            }

            var cliente = new Cliente()
            {
                Nome = nomeCliente,
                CPF = cpf
            };

            var cachorros = idsCachorros.Select(i => new Cachorro()
            {
                Id = i
            }).ToList();

            var compra = new Compra()
            {
                EnderecoEntrega = enderecoDeEntrega,
                Cachorros = cachorros,
                Cliente = cliente
            };

            return compra;
        }
    }
}
