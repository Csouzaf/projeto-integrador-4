using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;

namespace pi_4.Controllers;

[ApiController]
[Route("login")]
public class LoginController : Controller
{

  private readonly AppDbContext _appDbContext;

    public LoginController(AppDbContext appDbContext)
   {
      _appDbContext = appDbContext;
   } 

  [HttpPost]
  public ActionResult<bool> Login(LoginDTO loginDTO)
  {
    var usuario = _appDbContext.usuarioAdm.FirstOrDefault(u => u.email == loginDTO.Email && u.senha == loginDTO.Senha);

    if (usuario != null)
    {
      return Json(new {usuario});
    }
    else
    {
      return BadRequest("Email ou senha inválidos.");
    }
  }   
}

