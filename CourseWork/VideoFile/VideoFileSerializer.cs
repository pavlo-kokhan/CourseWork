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
        public static void SerializeJson(List<VideoFile> objects, string filename)
        {
            try
            {
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

        public static List<VideoFile> DeserializeJson(string filename)
        {
            try
            {
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
