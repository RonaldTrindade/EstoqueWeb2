namespace EstoqueWeb2.Models
{
    public class Produto
    {

        public int Id { get; set; }
        public required String Nome { get; set; }
        public String? Descricao { get; set; }
        public required int QuantidadeDisponivel { get; set; }

        public ICollection<SaidaEntradaProduto>? Movimentacoes { get; set; }

    }
}
