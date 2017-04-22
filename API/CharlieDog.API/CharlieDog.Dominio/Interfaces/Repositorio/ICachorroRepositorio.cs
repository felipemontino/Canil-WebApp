using System.Collections.Generic;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Enums;
using CharlieDog.Dominio.Interfaces.Repositories;

namespace CharlieDog.Dominio.Interfaces.Repositorio
{
    public interface ICachorroRepositorio : IRepositorioBase<Cachorro>
    {
        IEnumerable<Cachorro> BuscarPorNome(string nome);
        IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor);
        IEnumerable<Cachorro> BuscarPorPorte(Porte porte);
    }
}
