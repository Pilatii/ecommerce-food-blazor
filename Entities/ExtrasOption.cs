namespace Cardapio.Entities
{
    public class ExtrasOption
    {
        public String? Name { get; set; }
        public decimal Price { get; set; }
        public String? Description { get; set; }
        public String? Url { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ExtrasOption options &&
                   Name == options.Name &&
                   Price == options.Price &&
                   Description == options.Description &&
                   Url == options.Url;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Description, Url);
        }
    }
}
