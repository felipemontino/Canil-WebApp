using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.WebAPI.Models;

namespace CharlieDog.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Compras")]
    public class ComprasController : Controller
    {
        private readonly ICompraAplicacao compraAplicacao;

        public ComprasController(ICompraAplicacao compraAplicacao)
        {
            this.compraAplicacao = compraAplicacao;
        }

        [HttpPost]
        public IActionResult Post(CompraModel model)
        {
            try
            {
                compraAplicacao.Efetuar(model.Nome, 
                                        model.CPF, 
                                        model.EnderecoEntrega, 
                                        model.IdsCachorros);

                return StatusCode(200);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}