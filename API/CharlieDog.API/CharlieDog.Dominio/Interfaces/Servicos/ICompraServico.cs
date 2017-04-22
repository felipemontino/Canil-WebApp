using CharlieDog.Dominio.Entidades;
using CharlieDog.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Dominio.Interfaces.Servicos
{
    public interface ICompraServico : IServicoBase<Compra>
    {
        void Efetuar(string nomeCliente, string cpf, string enderecoDeEntrega, int[] idsCachorros);
    }
}
