
using ecommerce_music_back.Repository;
using Microsoft.EntityFrameworkCore;
using pi_4.Models;

namespace ecommerce_music_back.Services
{
    public class UsuarioService : IUsuarioRepository
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Usuario>> buscarTodosAsync()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = _appDbContext)
                {
                    usuarios = await context.usuario.ToListAsync();

                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return usuarios;
        }

    }
}