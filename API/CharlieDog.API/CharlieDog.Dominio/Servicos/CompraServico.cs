using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Repositorio;
using CharlieDog.Dominio.Interfaces.Servicos;
using CharlieDog.Dominio.Services;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Servicos
{
    public class CompraServico : ServicoBase<Compra>, ICompraServico
    {
        private readonly ICompraRepositorio compraRepositorio;

        public CompraServico(ICompraRepositorio compraRepositorio)
            : base(compraRepositorio)
        {
            this.compraRepositorio = compraRepositorio;
        }

        public void Efetuar(string nomeCliente, string cpf, string enderecoDeEntrega, int[] idsCachorros)
        {
            var compra = new Compra().Gerar(nomeCliente, cpf, enderecoDeEntrega, idsCachorros);

            this.compraRepositorio.Add(compra);
        }
    }
}
