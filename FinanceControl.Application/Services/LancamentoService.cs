
using FinanceControl.Domain.Entities;
using FinanceControl.Domain.Interfaces;

namespace FinanceControl.Application.Services
{
    public class LancamentoService
    {
        private readonly ILancamentoRepository _repository;

        public LancamentoService(ILancamentoRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Lancamento>> GetAllAsync()
            => _repository.GetAllWithUsuarioAsync();

        public Task<Lancamento?> GetByIdAsync(int id)
            => _repository.GetByIdWithUsuarioAsync(id);

        public Task AddAsync(Lancamento lancamento)
            => _repository.AddAsync(lancamento);

        public Task UpdateAsync(Lancamento lancamento)
            => _repository.UpdateAsync(lancamento);

        public Task DeleteAsync(int id)
            => _repository.DeleteAsync(id);
    }

}
