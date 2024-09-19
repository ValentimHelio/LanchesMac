using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        public readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                                .Where(l => l.IsLanchePreferido)
                                                                .Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == id);
        }
    }
}
