using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharlieDog.Dominio.Entidades;

namespace CharlieDog.Dominio.Tests
{
    [TestClass]
    public class CompraTest
    {
        [TestMethod]
        public void CompraGeradaComSucesso()
        {
            var nome = "Jo�o";
            var cpf = "123456789-10";
            var enderecoEntrega = "Rua Abcd, 1234";
            var cachorrosEscolhidos = new int[] { 1, 2 };

            var compra = new Compra();

            compra = compra.Gerar(nome, cpf, enderecoEntrega, cachorrosEscolhidos);

            Assert.AreEqual(compra.EnderecoEntrega, enderecoEntrega, "Endere�os diferentes.");
            Assert.AreEqual(compra.Cliente.Nome, nome, "Nomes diferentes");
            Assert.AreEqual(compra.Cachorros.Count, cachorrosEscolhidos.Length, "N�meros de cachorros escolhidos � diferente");
        }

        [TestMethod]
        public void CompraGeradaComErroPorFaltaDeCliente()
        {
            var cachorrosEscolhidos = new int[] { 1, 2 };

            var compra = new Compra();         

            Assert.ThrowsException<ArgumentException>( () => {
                compra.Gerar(string.Empty, string.Empty, string.Empty, cachorrosEscolhidos);
            });
        }

        [TestMethod]
        public void CompraGeradaComErroPorFaltaDeCachorrosSelecionados()
        {
            var nome = "Jo�o";
            var cpf = "123456789-10";
            var enderecoEntrega = "Rua Abcd, 1234";

            var compra = new Compra();

            Assert.ThrowsException<ArgumentException>(() => {
                  compra.Gerar(nome, cpf, enderecoEntrega, new int[0]);
            });
        }
    }
}
