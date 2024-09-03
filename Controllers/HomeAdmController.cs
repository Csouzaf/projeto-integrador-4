using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.Controllers;

[ApiController]
[Route("administrador")]
public class HomeAdmController : Controller
{
   
    private readonly AppDbContext _appDbContext;
    private readonly IUsuarioProdutoRepository _usuarioProdutoRepository;

    public HomeAdmController(AppDbContext appDbContext, IUsuarioProdutoRepository usuarioProdutoRepository)
    {
      _appDbContext = appDbContext;
      _usuarioProdutoRepository = usuarioProdutoRepository;
    } 

   
    [HttpPost]
    public async Task<UsuarioProduto> criarProdutoAsync(UsuarioProduto usuarioProduto)
    {
        return await _usuarioProdutoRepository.criarProdutoAsync(usuarioProduto);
    }
  
}
