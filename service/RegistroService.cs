using System;
using AutoMapper;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.service;

public class RegistroService : IRegistroRepository
{
  private readonly AppDbContext _appDbContext;
  private readonly IMapper _mapper;
   public RegistroService(AppDbContext appDbContext, IMapper mapper)
   {
     _appDbContext = appDbContext;
     _mapper = mapper;
   }

   public async Task<RegistroDTO> criarUsuarioAdm(UsuarioAdm registroUsuarioAdm, Usuario registroUsuario)
   {
    
    if (registroUsuarioAdm.cnpj != null && registroUsuario.cpf == "")
    {
      await _appDbContext.usuarioAdm.AddAsync(registroUsuarioAdm);
      await _appDbContext.SaveChangesAsync();
      var criarUsuario = _mapper.Map<RegistroDTO>(registroUsuarioAdm);
      return criarUsuario;
    }
    else
    {
      await _appDbContext.usuario.AddAsync(registroUsuario);
      await _appDbContext.SaveChangesAsync();
      var criarUsuario = _mapper.Map<RegistroDTO>(registroUsuario);
      return criarUsuario;
    }

   }

}
