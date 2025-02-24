namespace EstoqueWeb2.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required String Nome { get; set; }
        public required String  Email { get; set; }
        public required ICollection<Estoque> Estoques { get; set; }
    }
}
