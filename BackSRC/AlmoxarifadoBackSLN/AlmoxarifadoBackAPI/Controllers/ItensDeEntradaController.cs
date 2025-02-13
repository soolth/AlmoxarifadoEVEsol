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
        private readonly IEntradaRepositorio _db;
        public ItensDeEntradaController(IEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaItensDeEntrada")]
        public IActionResult listaItensDeEntradas()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ItensDeEntrada")]
        public IActionResult listaCategorias(ItensDeEntradaDTO ItensDeentrada)
        {
            return Ok(_db.GetAll().Where(x => x.IdItensDeEntrada == ItensDeentrada.IdItensDeEntrada));
        }

        [HttpPost("/criarItensDeentrada")]
        public IActionResult criarItensDeEntrada(ItensDeEntradaCadastroDTO ItensDeentrada)
        {

            var novaItensDeentrada = new ItensDeEntrada()
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
            _db.Add(novaentrada);
            return Ok("Cadastro com Sucesso");
        }