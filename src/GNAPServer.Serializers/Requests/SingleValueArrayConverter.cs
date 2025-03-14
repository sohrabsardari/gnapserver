using Newtonsoft.Json;

namespace GNAPServer.Serializers.Requests;

public class SingleValueArrayConverter<T> : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.StartObject)
        {
            var instance = (T)serializer.Deserialize(reader, typeof(T))!;
            return new List<T>() { instance };
        }
        if (reader.TokenType == JsonToken.StartArray)
        {
            return serializer.Deserialize(reader, objectType);
        }

        throw new ArgumentOutOfRangeException();
    }

    public override bool CanConvert(Type objectType)
    {
        return true;
    }
}