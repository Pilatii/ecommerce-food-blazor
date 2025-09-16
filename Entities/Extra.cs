namespace Cardapio.Entities
{
    public class Extra
    {
        public String? Name { get; set; }
        public int Quantity { get; set; }
        public Boolean Required { get; set; }
        public List<ExtrasOption>? Options { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Extra extras &&
                   Name == extras.Name &&
                   Quantity == extras.Quantity &&
                   Required == extras.Required;
                  
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Quantity, Required);
        }

        public String GetSubtext()
        {
            if (Required && Quantity == 1)
            {
                return $"Escolha 1 opção.";
            }
            else if (Required && Quantity > 1)
            {
                return $"Escolha {Quantity} opções.";
            }
            else
            {
                return $"Escolha até {Quantity} opções.";
            }
        }
    }
}
