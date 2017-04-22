using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using CharlieDog.Dominio.Enums;

namespace CharlieDog.Dominio.Interfaces.Servicos
{
    public interface ICachorroServico : IServicoBase<Cachorro>
    {
        IEnumerable<Cachorro> BuscarPorNome(string nome);
        IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor);
        IEnumerable<Cachorro> BuscarPorPorte(Porte porte);
    }
}
