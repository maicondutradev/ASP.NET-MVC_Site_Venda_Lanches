using LanchesSaq.Models;

namespace LanchesSaq.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }

}
