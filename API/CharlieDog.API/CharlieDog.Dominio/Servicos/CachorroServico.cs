using System;
using System.Collections.Generic;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Enums;
using CharlieDog.Dominio.Interfaces.Repositorio;
using CharlieDog.Dominio.Interfaces.Servicos;
using CharlieDog.Dominio.Services;

namespace CharlieDog.Dominio.Servicos
{
    public class CachorroServico : ServicoBase<Cachorro>, ICachorroServico
    {
        private readonly ICachorroRepositorio cachorroRepositorio;

        public CachorroServico(ICachorroRepositorio cachorroRepositorio)
            : base(cachorroRepositorio)
        {
            this.cachorroRepositorio = cachorroRepositorio;
        }

        public IEnumerable<Cachorro> BuscarPorNome(string nome)
        {
            return this.cachorroRepositorio.BuscarPorNome(nome);
        }

        public IEnumerable<Cachorro> BuscarPorPorte(Porte porte)
        {
            return this.cachorroRepositorio.BuscarPorPorte(porte);
        }

        public IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor)
        {
            return this.cachorroRepositorio.BuscarPorPreco(minValor, maxValor);
        }
    }
}
