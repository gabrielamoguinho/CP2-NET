
using FinanceControl.Domain.Entities;

namespace FinanceControl.Domain.Interfaces
{
    public interface ILancamentoRepository
    {
        Task<IEnumerable<Lancamento>> GetAllWithUsuarioAsync();
        Task<Lancamento?> GetByIdWithUsuarioAsync(int id);
        Task AddAsync(Lancamento lancamento);
        Task UpdateAsync(Lancamento lancamento);
        Task DeleteAsync(int id);
    }

}

