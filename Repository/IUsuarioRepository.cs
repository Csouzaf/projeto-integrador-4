
using pi_4.Models;

namespace ecommerce_music_back.Repository
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> buscarTodosAsync();
    }
}