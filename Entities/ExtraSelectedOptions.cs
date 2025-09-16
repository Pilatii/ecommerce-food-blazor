namespace Cardapio.Entities
{
    public class ExtraSelectedOptions
    {
        public Extra Extra { get; }
        public List<ExtrasOption> SelectedOptions { get; }

        public ExtraSelectedOptions(Extra extra)
        {
            Extra = extra;
            SelectedOptions = new List<ExtrasOption>();
        }

        public void AddOption(ExtrasOption option)
        {
            if (SelectedOptions.Count < Extra.Quantity)
                SelectedOptions.Add(option);
        }

        public void RemoveOption(ExtrasOption option)
        {
            SelectedOptions.Remove(option);
        }

        public decimal GetTotalPrice()
        {
            return SelectedOptions.Sum(o => o.Price);
        }

        public string GetSelectedOptionsDescription()
        {
            return string.Join(", ",
                SelectedOptions
                    .GroupBy(o => o.Name)
                    .Select(g => $"{g.Count()}x {g.Key}")
            );
        }
    }
}
