using LanchesSaq.Context;
using LanchesSaq.Models;
using LanchesSaq.Repositories.Interfaces;

namespace LanchesSaq.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
