using D3vzDbLibrary;
using System.Text.Json.Serialization;

namespace D3vz_API.JsonModels {
    public class JAula {
        [JsonPropertyName("id")] public long Id { get; set; } = 0;
        [JsonPropertyName("alunoid")] public long AlunoId { get; set; }
        [JsonPropertyName("profid")] public long ProfId { get; set; }
        [JsonPropertyName("datahora")] public DateTime DataHora { get; set; }
        [JsonPropertyName("url")] public string URL { get; set; } = "";
        [JsonPropertyName("tempo")] public int TempoMinutos { get; set; } = 60;
        [JsonPropertyName("aceito")] public bool Aceito { get; set; } = false;
    }
}