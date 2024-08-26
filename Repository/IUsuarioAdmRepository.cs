using System;
using pi_4.Models;

namespace pi_4.Repository;

public interface IUsuarioAdmRepository 
{
  Task<List<UsuarioAdm>> buscarTodosAsync();
}
