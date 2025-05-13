using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceControl.Domain.Entities;
using FinanceControl.Domain.Interfaces;

namespace FinanceControl.Application.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Usuario>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Usuario?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Usuario usuario) => _repository.AddAsync(usuario);
        public Task UpdateAsync(Usuario usuario) => _repository.UpdateAsync(usuario);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}
