using CharlieDog.Data.Repositorio;
using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dados.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
    }
}
