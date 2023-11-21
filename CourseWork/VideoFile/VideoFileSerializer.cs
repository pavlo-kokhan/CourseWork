using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
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
                string jsonString = File.ReadAllText(filename);

                var objects = JsonSerializer.Deserialize<List<VideoFile>>(jsonString);

                return objects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
