using CharlieDog.Data.Repositorio;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CharlieDog.Dominio.Enums;

namespace CharlieDog.Dados.Repositorio
{
    public class CachorroRepositorio : RepositorioBase<Cachorro>, ICachorroRepositorio
    {
        public IEnumerable<Cachorro> BuscarPorNome(string nome)
        {
            return this.Db.Cachorros.Where(c => c.Nome.ToLower() == nome.ToLower());
        }

        public IEnumerable<Cachorro> BuscarPorPorte(Porte porte)
        {
            return this.Db.Cachorros.Where(c => c.Raca.Porte == porte);
        }

        public IEnumerable<Cachorro> BuscarPorPreco(decimal minValor, decimal maxValor)
        {
            if (minValor > maxValor)
            {
                return this.Db.Cachorros.Where(c => c.Preco > minValor);
            }
            else
            {
                return this.Db.Cachorros.Where(c => c.Preco > minValor && c.Preco < maxValor);
            }
        }
    }
}
