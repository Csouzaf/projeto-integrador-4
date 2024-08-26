using System;
using AutoMapper;

namespace pi_4.Models;

public class AutoMapperPerfil : Profile
{
 public AutoMapperPerfil()
 {
  CreateMap<Usuario, RegistroDTO>().ReverseMap();
  CreateMap<UsuarioAdm, RegistroDTO>().ReverseMap();
 }
}
