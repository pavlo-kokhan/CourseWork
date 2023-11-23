using Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using VideoFileClass;

namespace SecondaryClasses
{
    public static class VideoFileSerializer
    {
        // Метод для сереалізації списку об'єктів VideoFile у файл .json
        public static void SerializeJson(List<VideoFile> objects, string filename)
        {
            try
            {
                // Додаткові властивості для більш читабельного запису
                var options = new JsonSerializerOptions();

                options.WriteIndented = true;
                options.Converters.Add(new EnumConverter<VideoFormat>());
                options.Converters.Add(new EnumConverter<AudioCodec>());
                options.Converters.Add(new EnumConverter<VideoCodec>());
                options.Converters.Add(new EnumConverter<VideoPlayer>());

                string jsonString = JsonSerializer.Serialize(objects, options);

                File.WriteAllText(filename, jsonString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Метод для десерелізації списку об'єктів VideoFile
        public static List<VideoFile> DeserializeJson(string filename)
        {
            try
            {
                // Такі ж властивості для десереалізації
                var options = new JsonSerializerOptions();

                options.Converters.Add(new EnumConverter<VideoFormat>());
                options.Converters.Add(new EnumConverter<AudioCodec>());
                options.Converters.Add(new EnumConverter<VideoCodec>());
                options.Converters.Add(new EnumConverter<VideoPlayer>());

                string jsonString = File.ReadAllText(filename);

                var objects = JsonSerializer.Deserialize<List<VideoFile>>(jsonString, options);

                return objects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
