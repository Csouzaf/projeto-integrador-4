using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.Controllers;

[ApiController]
[Route("registro")]
public class RegistroController : Controller
{

   private readonly IRegistroRepository _registroRepository;

   public RegistroController(IRegistroRepository registroRepository)
   {
      _registroRepository = registroRepository;
   } 

   [HttpPost]
   public async Task<ActionResult<RegistroDTO>> criarUsuario([FromBody] UsuarioAdm usuarioAdm, [FromBody] Usuario usuario)
   {

      var criarUsuario = _registroRepository.criarUsuarioAdm(usuarioAdm, usuario);
      if (criarUsuario != null)
      {
       return Created("criado", criarUsuario);
      }
      else
      {
       return BadRequest("Erro");
      }

   }

}