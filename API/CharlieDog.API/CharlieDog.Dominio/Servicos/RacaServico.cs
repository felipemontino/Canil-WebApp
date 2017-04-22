using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Repositorio;
using CharlieDog.Dominio.Interfaces.Servicos;
using CharlieDog.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Servicos
{
    public class RacaServico : ServicoBase<Raca>, IRacaServico
    {
        private readonly IRacaRepositorio racaRepositorio;

        public RacaServico(IRacaRepositorio racaRepositorio)
            : base(racaRepositorio)
        {
            this.racaRepositorio = racaRepositorio;
        }
    }
}
