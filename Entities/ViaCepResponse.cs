using System.Text.Json.Serialization;

namespace Cardapio.Entities
{
    public class ViaCepResponse
    {
        [JsonPropertyName("logradouro")]
        public string Street { get; set; } = string.Empty;

        [JsonPropertyName("complemento")]
        public string AddressDetails { get; set; } = string.Empty;

        [JsonPropertyName("localidade")]
        public string City { get; set; } = string.Empty;

        [JsonPropertyName("bairro")]
        public string District { get; set; } = string.Empty;

        [JsonPropertyName("erro")]
        public string Error { get; set; } = string.Empty;

        [JsonIgnore]
        public bool HasError => Error.Equals("true", StringComparison.OrdinalIgnoreCase);
    }
}
