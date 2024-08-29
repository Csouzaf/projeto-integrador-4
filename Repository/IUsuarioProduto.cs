using System;
using pi_4.Models;

namespace pi_4.Repository;

public interface IUsuarioProdutoRepository
{
    Task<List<UsuarioProduto>> buscarTodosAsync();

    Task<UsuarioProduto> criarProdutoAsync(UsuarioProduto usuarioProduto);
}
