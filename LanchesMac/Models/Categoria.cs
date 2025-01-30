namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaName { get; set; }
        public string CategoriaDescricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
