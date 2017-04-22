using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using CharlieDog.Dominio.Enums;

namespace CharlieDog.Aplicacao
{
    public class CachorroAplicacao : AplicacaoBase<Cachorro>, ICachorroAplicacao
    {
        private readonly ICachorroServico cachorroServico;

        public CachorroAplicacao(ICachorroServico cachorroServico)
            : base(cachorroServico)
        {
            this.cachorroServico = cachorroServico;
        }

        public IEnumerable<Cachorro> BuscarPorNome(string nome)
        {
            return this.cachorroServico.BuscarPorNome(nome);
        }

        public IEnumerable<Cachorro> BuscarPorPorte(Porte porte)
        {
            return this.cachorroServico.BuscarPorPorte(porte);
        }

        public IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor)
        {
            return this.cachorroServico.BuscarPorPreco(minValor, maxValor);
        }
    }
}
