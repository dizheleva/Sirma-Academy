namespace ShapeAreaCalculator
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using ShapeAreaCalculator.Models;

    public class ShapeConverter : JsonConverter<Shape>
    {
        public override Shape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            JsonElement root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();

            return type switch
            {
                "Circle" => JsonSerializer.Deserialize<Circle>(root.GetRawText(), options),
                "Triangle" => JsonSerializer.Deserialize<Triangle>(root.GetRawText(), options),
                "Square" => JsonSerializer.Deserialize<Square>(root.GetRawText(), options),
                "Rectangle" => JsonSerializer.Deserialize<Rectangle>(root.GetRawText(), options),
                "Trapezoid" => JsonSerializer.Deserialize<Trapezoid>(root.GetRawText(), options),
                "RegularPolygon" => JsonSerializer.Deserialize<RegularPolygon>(root.GetRawText(), options),
                _ => throw new JsonException()
            };
        }

        public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
