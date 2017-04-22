using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Repositorio;
using CharlieDog.Dominio.Interfaces.Servicos;
using CharlieDog.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Servicos
{
    public class ClienteServico : ServicoBase<Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
            : base(clienteRepositorio)
        {
            this.clienteRepositorio = clienteRepositorio;
        }
    }
}
