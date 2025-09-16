namespace Cardapio.Entities
{
    public class CartItem
    {
        public Produto Product { get; set; } = new();
        public int Quantity { get; set; } = 1;
        public decimal Price { get; set; }
        public List<ExtraSelectedOptions> Extras = new();
        public MenuSection MenuSection { get; set; } = new();
        public event Action? EditItem;
        public string Comment { get; set; } = string.Empty;

        public string BuildExtrasDescription()
        {
            if (Extras == null || Extras.Count == 0)
                return string.Empty;

            return string.Join(", ",
                Extras
                    .Select(e => e.GetSelectedOptionsDescription())
                    .Where(desc => !string.IsNullOrWhiteSpace(desc))
            );
        }
    }
}
