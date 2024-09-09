using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.Controllers;

[ApiController]
[Route("produtos")]
public class ProdutoAdmController : Controller
{
   
    private readonly AppDbContext _appDbContext;
    private readonly IUsuarioProdutoRepository _usuarioProdutoRepository;
    private readonly IUsuarioAdmRepository _usuarioAdmRepository;

    public ProdutoAdmController(AppDbContext appDbContext, IUsuarioProdutoRepository usuarioProdutoRepository, IUsuarioAdmRepository
      usuarioAdmRepository)
    {
      _appDbContext = appDbContext;
      _usuarioProdutoRepository = usuarioProdutoRepository;
      _usuarioAdmRepository = usuarioAdmRepository;
    } 

   
    [HttpPost]
    public async Task<UsuarioProduto> criarProdutoAsync(UsuarioProduto usuarioProduto)
    {
        return await _usuarioProdutoRepository.criarProdutoAsync(usuarioProduto);
    }

    [HttpGet("usuarios")]
    public async Task<List<UsuarioAdm>> usuariosAdm()
    {
      return await _usuarioAdmRepository.buscarTodosAsync();
    }

    [HttpGet]
    public async Task<List<UsuarioProduto>> buscarTodosAsync()
    {
      return await _usuarioProdutoRepository.buscarTodosAsync();
    }
  
}
