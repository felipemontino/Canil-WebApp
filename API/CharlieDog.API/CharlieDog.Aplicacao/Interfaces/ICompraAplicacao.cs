using CharlieDog.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlieDog.Aplicacao.Interfaces
{
    public interface ICompraAplicacao : IAplicacaoBase<Compra>
    {
        void Efetuar(string nomeCliente, string cpf, string enderecoDeEntrega, int[] idsCachorros);
    }
}
