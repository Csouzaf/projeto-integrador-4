using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;

namespace pi_4.Controllers;

public class LoginController : Controller
{
  //verificar no banco se o usuario existe a partir das informações de email e senha. 

  private readonly AppDbContext _appDbContext;

  public LoginController()
  {
    _appDbContext = new AppDbContext();
  } 

  [HttpPost]
  public ActionResult<bool> Login(LoginDTO loginDTO)
  {
    var usuario = _appDbContext.usuario.FirstOrDefault(u => u.email == loginDTO.Email && u.senha == loginDTO.Senha);

    if (usuario != null)
    {
      return Json(new { usuario.admOuUsuario });
    }
    else
    {
      ViewBag.Mensagem = "Email ou senha inválidas.";
      return View();
    }
  }   
}

