using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using FinanceControl.Domain.Entities;
using FinanceControl.Domain.Interfaces;
using FinanceControl.Infrastructure.Context;
using FinanceControl.Domain.Entities;
using FinanceControl.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly FinanceDbContext _context;

        public LancamentoRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lancamento>> GetAllWithUsuarioAsync()
        {
            return await _context.Lancamentos
                .Include(l => l.Usuario)
                .ToListAsync();
        }

        public async Task<Lancamento?> GetByIdWithUsuarioAsync(int id)
        {
            return await _context.Lancamentos
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(Lancamento lancamento)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == lancamento.UsuarioId);
            if (usuario == null)
                throw new Exception("Usuário informado não existe.");

            _context.Lancamentos.Add(lancamento);
            await _context.SaveChangesAsync();

        }


        public async Task UpdateAsync(Lancamento lancamento)
        {
            _context.Lancamentos.Update(lancamento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var lancamento = await GetByIdWithUsuarioAsync(id);
            if (lancamento != null)
            {
                _context.Lancamentos.Remove(lancamento);
                await _context.SaveChangesAsync();
            }
        }
    }
}
