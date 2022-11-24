using System.Text.Json.Serialization;

namespace D3vz_API.Controllers.DBAPI {
    public partial class UserController {
        public class JUser {
            [JsonPropertyName("id")] public long Id { get; set; }
            [JsonPropertyName("discriminacao")] public string Discriminacao { get; set; } = "";
            [JsonPropertyName("nome")] public string Nome { get; set; } = "";
            [JsonPropertyName("descricao")] public string Descricao { get; set; } = "";
            [JsonPropertyName("cpf")] public string Cpf { get; set; } = "";
            [JsonPropertyName("email")] public string Email { get; set; } = "";
            [JsonPropertyName("nascimento")] public DateTime Nascimento { get; set; }
            [JsonPropertyName("senha")] public string Senha { get; set; } = "";
            [JsonPropertyName("interquali")] public string[]? Interquali { get; set; }
            [JsonPropertyName("foto")] public string? Foto { get; set; }
            [JsonPropertyName("dias")] public string? Dias { get; set; }
            [JsonPropertyName("horarios")] public string? Horarios { get; set; }
            [JsonPropertyName("code")] public string? GoogleAuth { get; set; }
        }
    }
}