using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaRepositorio _db;
        public EntradaController(IEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaEntrada")]
        public IActionResult listaEntradas()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Entrada")]
        public IActionResult listaCategorias(EntradaDTO entrada)
        {
            return Ok(_db.GetAll().Where(x=>x.IdEntrada==entrada.IdEntrada));
        }

        [HttpPost("/criarentrada")]
        public IActionResult criarEntrada(EntradaCadastroDTO entrada)
        {

            var novaentrada = new Entrada()
            {
                Observacao = entrada.Observacao,
                 IdFornecedor = entrada.IdFornecedor,
                  DataDeEntrada = entrada.DataDeEntrada
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaentrada);
            return Ok("Cadastro com Sucesso");
        }

        //[HttpDelete("/removercategoria")]
        //public IActionResult removerCategorias(CategoriaDTO categoria)
        //{
        //    var itemPesquisado = _categorias.FirstOrDefault(x => x.Codigo == categoria.Codigo);

        //    if (itemPesquisado != null)
        //    {
        //        _categorias.Remove(itemPesquisado);
        //        return Ok("Removido com sucesso");
        //    }
        //    else
        //    {
        //        return Ok("Produdo não localizado");
        //    }

            
        //}



    }
}
