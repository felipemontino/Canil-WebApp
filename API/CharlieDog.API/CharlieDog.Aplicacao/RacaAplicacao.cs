using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Aplicacao
{
    public class RacaAplicacao : AplicacaoBase<Raca>, IRacaAplicacao
    {
        private readonly IRacaServico racaServico;

        public RacaAplicacao(IRacaServico racaServico)
            : base(racaServico)
        {
            this.racaServico = racaServico;
        }
    }
}
