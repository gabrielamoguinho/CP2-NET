using Swashbuckle.AspNetCore.Filters;
using FinanceControl.Domain.Entities;

public class UsuarioRequestExample : IExamplesProvider<Usuario>
{
    public Usuario GetExamples()
    {
        return new Usuario
        {
            Nome = "Maria",
            Email = "maria@email.com",
            Senha = "123456",
           
        };
    }
}
