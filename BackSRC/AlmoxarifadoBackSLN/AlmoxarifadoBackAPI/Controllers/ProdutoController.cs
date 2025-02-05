using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepositorio _db;

        public ProdutoController(IProdutoRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaProdutos()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/produto")]
        public IActionResult listaProdutos(ProdutoDTO produto)
        {
            return Ok(_db.GetAll().Where(x => x.IdProduto == produto.IdProduto));
        }

        [HttpPost("/criarproduto")]
        public IActionResult criarProdutro(ProdutoCadastroDTO produto)
        {

            var novoProduto = new Produto()
            {
                Descricao = produto.Descricao
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novoProduto);
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
