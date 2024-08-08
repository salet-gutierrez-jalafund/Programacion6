using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;
using StrategyWithTemplateMethod.src.Entities.Enums;

namespace StrategyWithTemplateMethod.src.Entities;

public class Book
{
    public string Title { get; set; } = "";

    public string Author { get; set; } = "";

    public string Isbn { get; set; } = "";

    [JsonConverter(typeof(StringEnumConverter))]
    public Genre Genre { get; set; }

    public int PublicationYear { get; set; }

    public bool IsAvailable { get; set; } = true;

}