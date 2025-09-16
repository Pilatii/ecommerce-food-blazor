namespace Cardapio.Entities
{
    public class MenuSection
    {
        public string SectionName { get; set; } = string.Empty;
        public List<Produto> Products { get; set; } = new();
    }
}
