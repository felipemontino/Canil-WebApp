using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Servicos;
using System;

namespace CharlieDog.Aplicacao
{
    public class ClienteAplicacao : AplicacaoBase<Cliente>, IClienteAplicacao
    {
        private readonly IClienteServico clienteServico;

        public ClienteAplicacao(IClienteServico clienteServico)
            : base(clienteServico)
        {
            this.clienteServico = clienteServico;
        }
    }
}
