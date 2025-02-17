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
    public class ItensDeSaidaController : ControllerBase
    {
        private readonly IItensDeSaidaRepositorio _db;
        public ItensDeSaidaController(IItensDeSaidaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaItensDeSaida")]
        public IActionResult listaItensDeSaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ItensDeSaida")]
        public IActionResult listaItensDeSaida(ItensDeSaidaDTO ItensDeSaida)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == categoria.Codigo));
        }

        [HttpPost("/criarItensDeSaida")]
        public IActionResult criarItensDeSaida(ItensDeSaidaCadastroDTO ItensDeSaida)
        {

            var novoItensDeSaida = new ItensDeSaida()
            {
                Descricao = categoria.Descricao
            };
            _db.Add(novoItensDeSaida);
            return Ok("Cadastro com Sucesso");
        }
