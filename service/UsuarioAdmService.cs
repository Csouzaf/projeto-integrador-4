using System;
using Microsoft.EntityFrameworkCore;
using pi_4.Models;
using pi_4.Repository;

namespace pi_4.service;

public class UsuarioAdmService : IUsuarioAdmRepository
{
 private readonly AppDbContext _appDbContext;

 public UsuarioAdmService(AppDbContext appDbContext)
 {
   _appDbContext = appDbContext;
 }
 public async Task<List<UsuarioAdm>> buscarTodosAsync()
 {
   List<UsuarioAdm> usuarioAdms = new List<UsuarioAdm>();

   try
   {
    using(var context = _appDbContext)
    {
     usuarioAdms = await context.usuarioAdm.ToListAsync();
    }
   }
   catch (System.Exception)
   {
    
    throw;
   }
   return usuarioAdms;
 } 

}
