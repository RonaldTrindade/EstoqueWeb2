namespace EstoqueWeb2.Models
{
    public class Estoque
    {
        public int Id { get; set; } 
        public required string Nome { get; set; }
        public required string Localizacao { get; set; }
        public int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }

        public required ICollection<Produto> Produtos { get; set; }
    }
}
