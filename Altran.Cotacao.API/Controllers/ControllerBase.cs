using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Aplicacao.Interfaces;
using Altran.Cotacao.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Altran.Cotacao.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller where Entidade : EntidadeBase where EntidadeDTO : BaseDTO
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> _app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app)
        {
            _app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var produtos = _app.SelecionarTodos();
                return new OkObjectResult(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var produto = _app.SelecionarPorId(id);
                return new OkObjectResult(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir([FromBody] EntidadeDTO entidadeDTO)
        {
            try
            {
                return new OkObjectResult(_app.Incluir(entidadeDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO entidadeDTO)
        {
            try
            {
                _app.Alterar(entidadeDTO);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
