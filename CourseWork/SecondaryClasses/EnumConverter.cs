using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SecondaryClasses
{
    // Спеціальний клас для властивостей сереалізації/десереалізації
    // Використовується як властивості Converters для JsonSerializerOptions
    // Конвертує перелічувані типи для сереалізації/десереалізації у тип string
    public class EnumConverter<T> : JsonConverter<T> where T : Enum
    {

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return (T)Enum.ToObject(typeof(T), reader.GetInt32());
            }

            string enumString = reader.GetString();

            return (T)Enum.Parse(typeof(T), enumString);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
