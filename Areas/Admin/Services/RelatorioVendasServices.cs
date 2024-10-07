using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Areas.Admin.Services
{
    public class RelatorioVendasServices
    {
        private readonly AppDbContext _context;

        public RelatorioVendasServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? mimDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.Pedidos select obj;

            if (mimDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado >= mimDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado <= maxDate.Value);
            }

            return await resultado
                        .Include(l => l.PedidoItens)
                        .ThenInclude(l => l.Lanche)
                        .OrderByDescending(x => x.PedidoEnviado)
                        .ToListAsync();

        }
    }
}
