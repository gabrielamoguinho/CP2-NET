using Swashbuckle.AspNetCore.Filters;
using FinanceControl.Domain.Entities;
using System;
using FinanceControl.API.Dtos;

public class LancamentoRequestExample : IExamplesProvider<LancamentoCreateDto>
{
    public LancamentoCreateDto GetExamples()
    {
        return new LancamentoCreateDto
        {
            Titulo = "Compra no supermercado",
            Valor = 150.75M,
            Data = DateTime.UtcNow,
            Tipo = "Despesa",
            UsuarioId = 2
        };
    }
}

