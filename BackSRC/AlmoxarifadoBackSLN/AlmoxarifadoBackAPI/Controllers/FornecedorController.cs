using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FonecedorController : ControllerBase
    {
        private IFornecedorRepositorio _db;

        public FonecedorController(IFornecedorRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaFornecedor")]
        public IActionResult listaFornecedor()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Fornecedor")]
        public IActionResult listaFornecedor(FornecedorDTO fornecedor)
        {
            return Ok(_db.GetAll().Where(x => x.CodigoF == fornecedor.CodigoF));
        }

        [HttpPost("/criarFornecedor")]
        public IActionResult criarFornecedor(FornecedorCadastroDTO fornecedor)
        {

            var novoFornecedor = new Fornecedor() { 
                NomeFornecedor = fornecedor.NomeFornecedor,
                EnderecoFornecedor =fornecedor.EnderecoFornecedor,
                CNPJ = fornecedor.CNPJ,
                Telefone = fornecedor.Telefone,
                EstadoSigla = fornecedor.EstadoSigla,
                Cidade = fornecedor.Cidade,
                Bairro = fornecedor.Bairro
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novoFornecedor);
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
