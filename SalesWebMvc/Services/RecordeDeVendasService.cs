using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class RecordeDeVendasService
    {
        private readonly VendasWebMvcContext _context;

        public RecordeDeVendasService(VendasWebMvcContext context)
        {
            _context = context;
        }
        
        public async Task<List<RecordDeVenda>> BuscarPorDataAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RecordeDeVenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Departamento,RecordDeVenda>>> BuscarPorAgrupamentoDeDataAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RecordeDeVenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
