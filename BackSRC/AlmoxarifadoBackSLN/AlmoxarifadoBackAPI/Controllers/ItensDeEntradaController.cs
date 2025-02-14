using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItensDeEntradaController : ControllerBase
    {
        private readonly IItensEntradaRepositorio _db;
        public ItensDeEntradaController(IItensEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaItensDeEntrada")]
        public IActionResult listaItensDeEntradas()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ItensDeEntrada")]
        public IActionResult listaItensEntrada(ItensDeEntradaDTO ItensDeEntrada)
        {
            return Ok(_db.GetAll().Where(x => x.IdItensDeEntrada == ItensDeEntrada.IdItensDeEntrada));
        }

        [HttpPost("/criarItensDeentrada")]
        public IActionResult criarItensDeEntrada(ItensDeEntradaCadastroDTO ItensDeEntrada)
        {

            var novaItensDeEntrada = new ItensDeEntrada()
            {
                IdProduto = ItensDeEntrada.IdProduto,
                IdFornecedor = ItensDeEntrada.IdFornecedor,
                IdItensDeEntrada = ItensDeEntrada.IdItensDeEntrada,
                DataDeEntrada = ItensDeEntrada.DataDeEntrada,
                QuantidadeEntrada = ItensDeEntrada.QuantidadeEntrada,
                Preco = ItensDeEntrada.Preco,
                Total = ItensDeEntrada.Total,
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaItensEntrada);
            return Ok("Cadastro com Sucesso");
        }
    }
}