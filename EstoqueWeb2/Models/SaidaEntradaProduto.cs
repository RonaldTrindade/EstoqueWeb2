namespace EstoqueWeb2.Models
{
    public class SaidaEntradaProduto
    {
        public int Id { get; set; } 
        public required string TipoOperacao { get; set; } 
        public int Quantidade { get; set; }
        public DateTime DataOperacao { get; set; } = DateTime.Now;

        // Chave estrangeira para Produto
        public int ProdutoId { get; set; }
        public required Produto Produto { get; set; }

        // Chave estrangeira para Estoque
        public int EstoqueId { get; set; }
        public required Estoque Estoque { get; set; }
    }
}
