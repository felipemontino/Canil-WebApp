using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Aplicacao
{
    public class CompraAplicacao : AplicacaoBase<Compra>, ICompraAplicacao
    {
        private readonly ICompraServico compraServico;

        public CompraAplicacao(ICompraServico compraServico)
            : base(compraServico)
        {
            this.compraServico = compraServico;
        }

        public void Efetuar(string nomeCliente, string cpf, string enderecoDeEntrega, int[] idsCachorros)
        {
            throw new NotImplementedException();
        }
    }
}
