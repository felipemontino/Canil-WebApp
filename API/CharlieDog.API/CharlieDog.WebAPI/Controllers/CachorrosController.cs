using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Enums;

namespace CharlieDog.WebAPI.Controllers
{
    [Route("api/Cachorros")]
    public class CachorrosController : Controller
    {
        private readonly ICachorroAplicacao cachorroAplicacao;

        public CachorrosController(ICachorroAplicacao cachorroAplicacao)
        {
            this.cachorroAplicacao = cachorroAplicacao;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var cachorros = this.cachorroAplicacao.GetAll();

                return StatusCode(200, cachorros);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        public IActionResult GetPorNome(string nome)
        {
            try
            {
                var cachorros = this.cachorroAplicacao.BuscarPorNome(nome);

                return StatusCode(200, cachorros);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        public IActionResult GetPorId(int id)
        {
            try
            {
                var cachorro = this.cachorroAplicacao.GetById(id);

                return StatusCode(200, cachorro);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        public IActionResult GetPorPorte(Porte porte)
        {
            try
            {
                var cachorros = this.cachorroAplicacao.BuscarPorPorte(porte);

                return StatusCode(200, cachorros);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        public IActionResult GetPorPorte(decimal minValor, decimal maxValor)
        {
            try
            {
                var cachorros = this.cachorroAplicacao.BuscarPorPreco(minValor, maxValor);

                return StatusCode(200, cachorros);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}