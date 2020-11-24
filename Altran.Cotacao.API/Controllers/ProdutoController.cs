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
    public class ProdutoController : ControllerBase<Produto, ProdutoDTO>
    {
        private new readonly IProdutoApp _app;
        const decimal vlrIOF = 0.38m;
        const decimal vlrFator = 109;


        public ProdutoController(IProdutoApp app) : base(app)
        {
            _app = app;
        }

        [Route("GetCoberturaBasica")]
        [HttpPost]
        public IActionResult GetCoberturaBasica([FromBody] RequestDTO requestDTO)
        {
            try
            {

                var validBasic = TryValidateModel(requestDTO.BasicDTO);
                var validParameter = TryValidateModel(requestDTO.ParameterDTO);

                if (!validBasic)
                {
                    return new BadRequestObjectResult("Favor informar os dados básicos");
                }

                if (!validParameter)
                {
                    return new BadRequestObjectResult("Favor informar os parâmetros");
                }

                if (requestDTO.OptionalDTO.Count() > 0)
                {
                    foreach (var item in requestDTO.OptionalDTO)
                    {
                        if (item.Product == requestDTO.BasicDTO.Product)
                        {
                            return new BadRequestObjectResult("Não pode conter o mesmo produto para basico e opcionais");
                        }
                    }
                }

                var produtos = _app.SelecionarTodos(new Produto());

                var ResultBasico = produtos.Where(x => x.Product == requestDTO.BasicDTO.Product
                                && x.Age == requestDTO.ParameterDTO.Age
                                && x.Gender == requestDTO.ParameterDTO.Gender
                                && x.Class == requestDTO.ParameterDTO.Class).FirstOrDefault();

                List<ProdutoDTO> Optionals = new List<ProdutoDTO>();

                foreach (var item in requestDTO.OptionalDTO)
                {
                    Optionals.Add(produtos.Where(x => x.Product == item.Product).FirstOrDefault());
                }


                ResponseDTO responseDTO = new ResponseDTO();
                responseDTO.Code = requestDTO.Code;
                responseDTO.CustomerDTO = requestDTO.CustomerDTO;
                responseDTO.BasicDTO = requestDTO.BasicDTO;
                responseDTO.BasicDTO.PremiumDTO = CalcularPremio(ResultBasico, requestDTO.BasicDTO.Capital);
                responseDTO.OptionalsDTO = requestDTO.OptionalDTO;

                return new OkObjectResult(responseDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        private PremiumDTO CalcularPremio(ProdutoDTO resultBasico, decimal capital)
        {
            PremiumDTO premium = null;
            try
            {
                premium = new PremiumDTO();
                premium.AnnualNet = Math.Round((capital * resultBasico.Rate) / 1000, 2);
                premium.MonthlyNet = Math.Round((premium.AnnualNet * vlrFator) / 12, 2);
                premium.AnnualIof = Math.Round((premium.AnnualNet * vlrIOF), 2);
                premium.MonthlyIof = Math.Round((premium.MonthlyIof * vlrIOF), 2);
                premium.AnnualTotal = Math.Round(premium.AnnualNet + premium.AnnualIof, 2);
                premium.MonthlyIof = Math.Round(premium.MonthlyNet + premium.MonthlyIof, 2);

                return premium;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private PremiumDTO CalcularPremioMensal(List<ProdutoDTO> optionals, decimal vlrIOF, decimal vlrFator)
        {
            throw new NotImplementedException();
        }
    }
}
