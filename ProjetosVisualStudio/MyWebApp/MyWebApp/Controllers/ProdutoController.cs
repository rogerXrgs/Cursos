using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;
using System;

namespace MyWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.ListarProdutos());
            }
            catch(Exception ex)
            {
                return BadRequest("Erro:" + ex.Message);
            }
        }
    }
}
