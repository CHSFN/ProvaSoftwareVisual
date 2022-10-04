using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;


namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/Funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private static List<Funcionario> Funcionarios = new List<Funcionario>();
        private readonly DataContext _context;
        public FuncionarioController(DataContext context) => _context = context;

        // Get: /api/Funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult  ListarFuncionarios() => Ok(_context.Funcionarios.ToList());

        //POST: /api/Funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult  CadastrarFuncionarios([FromBody]Funcionario Funcionario)
        {
        //    if (_context.Funcionarios.FirstOrDefault(f => f.Cpf.Equals(Funcionario.Cpf)) == null)
        //    {
            _context.Funcionarios.Add(Funcionario);
            _context.SaveChanges();
            return Created("", Funcionario);
        //    }
        //    return Conflict();
        }

        //GET: /api/Funcionario/buscar
        [HttpGet]
        [Route("buscar/{Cpf}")]
        public IActionResult  Buscar([FromRoute] string Cpf)
        {
            Funcionario Funcionario = _context.Funcionarios.FirstOrDefault(f => f.Cpf.Equals(Cpf));
            // if (Funcionario == null)
            // {
            //     return NotFound();
            // }
            // return Ok(Funcionario);
            return Funcionario != null ? Ok(Funcionario) : NotFound();
        }

        //DELETE: /api/Funcionario/Deletar
        [HttpDelete]
        [Route("deletar/{id}")]

        public IActionResult  Deletar([FromRoute] int id)
        {
            Funcionario Funcionario = _context.Funcionarios.Find(id);
            if (Funcionario != null)
            {
                _context.Funcionarios.Remove(Funcionario);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        // PATCH: /api/Funcionario/editar
        [HttpPatch]
        [Route("editar")]
        public IActionResult  Editar([FromBody] Funcionario Funcionario)
        {
            try
            {
                _context.Funcionarios.Update(Funcionario);
                _context.SaveChanges();
                return Ok(Funcionario);
            }
            catch
            {
                return NotFound();
            }
        }


    }
}