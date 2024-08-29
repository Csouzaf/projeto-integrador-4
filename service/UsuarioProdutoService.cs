using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.service;

public class UsuarioProdutoService : IUsuarioProdutoRepository
{
    //verificar se o usuario existe e se é adm
    //se sim o usuario cria o produto
    //Associar o UsuarioAdmId ao id do usario criado 

    private readonly IMapper _mapper;
    private readonly AppDbContext _appDbContext;

    public UsuarioProdutoService(IMapper mapper, AppDbContext appDbContext)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }

    public async Task<List<UsuarioProduto>> buscarTodosAsync()
    {
        List<UsuarioProduto> usuarioProdutos = new List<UsuarioProduto>();
        try
        {
          
            using (var context = _appDbContext)
            {
                usuarioProdutos = await context.usuarioProduto.ToListAsync();
            }
        }
        catch (Exception ex)
        {

            throw;
        }
        return usuarioProdutos;
    }

    public async Task<UsuarioProduto> criarProdutoAsync(UsuarioProduto usuarioProduto)
    {
        try
        {
          
            using (var context = _appDbContext)
            {
                await context.usuarioProduto.AddAsync(usuarioProduto);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {

            throw;
        }
        return usuarioProduto;
    }


}
