using System;
using pi_4.Models;

namespace pi_4.Repository;

public interface IRegistroRepository
{
 Task<RegistroDTO> criarUsuario(Usuario registroUsuario);

 Task<RegistroDTO> criarUsuarioAdm(UsuarioAdm registroUsuarioAdm);
}
