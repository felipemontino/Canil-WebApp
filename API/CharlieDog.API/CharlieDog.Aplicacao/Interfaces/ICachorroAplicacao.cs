using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Aplicacao.Interfaces
{
    public interface ICachorroAplicacao : IAplicacaoBase<Cachorro>
    {
        IEnumerable<Cachorro> BuscarPorNome(string nome);
        IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor);
        IEnumerable<Cachorro> BuscarPorPorte(Porte porte);
    }
}
