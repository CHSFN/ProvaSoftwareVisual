using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Utils;


namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/FolhaPagamento")]
    public class FolhaPagamentoController : ControllerBase
    {
        private static List<FolhaPagamento> FolhaPagamentos = new List<FolhaPagamento>();
        private readonly DataContext _context;
        public FolhaPagamentoController(DataContext context) => _context = context;

        // Get: /api/FolhaPagamento/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult  ListarFolhaPagamentos() => Ok(_context.FolhaPagamentos.ToList());

        //POST: /api/FolhaPagamento/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult  CadastrarFolhaPagamentos([FromBody]FolhaPagamento FolhaPagamento)
        {
            Calcs calcs = new Calcs();

            FolhaPagamento.SalarioBruto = calcs.CalcularSalarioBruto(FolhaPagamento.ValorHora, FolhaPagamento.QuantidadeHoras);
            FolhaPagamento.ImpostoRenda = calcs.CalcularImpostoRenda(FolhaPagamento.SalarioBruto);
            FolhaPagamento.ImpostoInss = calcs.CalcularInss(FolhaPagamento.SalarioBruto);
            FolhaPagamento.ImpostoFgts = calcs.CalcularFgts(FolhaPagamento.SalarioBruto);
            FolhaPagamento.SalarioLiquido = calcs.CalcularSalarioLiquido(FolhaPagamento.SalarioBruto,
                                                                        FolhaPagamento.ImpostoRenda,
                                                                        FolhaPagamento.ImpostoInss,
                                                                        FolhaPagamento.ImpostoFgts);


            _context.FolhaPagamentos.Add(FolhaPagamento);
            _context.SaveChanges();
            return Created("", FolhaPagamento);
        }

        // GET: /api/FolhaPagamento/buscar
        // [HttpGet]
        // [Route("buscar/{Mes}/{Ano}")]
        // public IActionResult  Buscar([FromRoute] int Mes, int Ano)
        // {
        //     FolhaPagamento FolhaPagamentoMes = _context.FolhaPagamentos.FirstOrDefault(f => f.Mes.Equals(Mes));
        //     FolhaPagamento FolhaPagamentoAno = _context.FolhaPagamentos.FirstOrDefault(f => f.Ano.Equals(Ano));

        //     if (FolhaPagamentoMes != null && FolhaPagamentoAno != null)
        //     {
        //         return Ok(FolhaPagamento);
        //     }
        //     return NotFound();
        // }

        //DELETE: /api/FolhaPagamento/Deletar
        [HttpDelete]
        [Route("deletar/{id}")]

        public IActionResult  Deletar([FromRoute] int id)
        {
            FolhaPagamento FolhaPagamento = _context.FolhaPagamentos.Find(id);
            if (FolhaPagamento != null)
            {
                _context.FolhaPagamentos.Remove(FolhaPagamento);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        // PATCH: /api/FolhaPagamento/editar



    }
}