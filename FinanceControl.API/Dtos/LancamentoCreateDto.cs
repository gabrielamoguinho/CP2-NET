namespace FinanceControl.API.Dtos
{
    public class LancamentoCreateDto
    {
        public string Titulo { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
    }
}
