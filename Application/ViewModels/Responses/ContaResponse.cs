namespace Application.Responses
{
    public class ContaResponse
    {
        public int Id { get; set; }
        public string DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public string NomeConta { get; set; }
        public bool Paga { get; set; }
        public string CodigoBarras { get; set; }
    }
}
