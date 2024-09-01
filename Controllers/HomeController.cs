using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.Controllers;

[ApiController]
[Route("home")]
public class HomeController : Controller
{
   
    private readonly AppDbContext _appDbContext;
    private readonly IUsuarioProdutoRepository _usuarioProdutoRepository;

    public HomeController(AppDbContext appDbContext, IUsuarioProdutoRepository usuarioProdutoRepository)
    {
      _appDbContext = appDbContext;
      _usuarioProdutoRepository = usuarioProdutoRepository;
    } 

    [HttpGet]
    public async Task<List<UsuarioProduto>> listaProdutos()
    {
        return await _usuarioProdutoRepository.buscarTodosAsync();
        
    }  

    [HttpPost]
    public async Task<UsuarioProduto> criarProdutoAsync(UsuarioProduto usuarioProduto)
    {
        return await _usuarioProdutoRepository.criarProdutoAsync(usuarioProduto);
    }
  
}
