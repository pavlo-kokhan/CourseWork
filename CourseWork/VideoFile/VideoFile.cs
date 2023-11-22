using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Enums;
using SecondaryClasses;

namespace VideoFileClass
{
    [Serializable]
    public class VideoFile
    {
        public VideoFile()
        {
            Name = "Undefined";
            Location = "Undefined";
            Format = VideoFormat.Undefined;
            Duration = TimeSpan.Zero;
            ACodec = AudioCodec.Undefined;
            VCodec = VideoCodec.Undefined;
            SubtitlesAvaliability = false;
            Size = new FileSize();
            Player = VideoPlayer.Undefined;
        }

        public VideoFile(
            string name, 
            string location, 
            VideoFormat format, 
            TimeSpan duraton, 
            AudioCodec aCodec, 
            VideoCodec vCodec, 
            bool subtitlesAvaliability, 
            FileSize size, 
            VideoPlayer player)
        {
            Name = name;
            Location = location;
            Format = format;
            Duration = duraton;
            ACodec = aCodec;
            VCodec = vCodec;
            SubtitlesAvaliability = subtitlesAvaliability;
            Size = size;
            Player = player;
        }

        public VideoFile(VideoFile other)
        {
            this.Name = other.Name;
            this.Location = other.Location;
            this.Format = other.Format;
            this.Duration = other.Duration;
            this.ACodec = other.ACodec;
            this.VCodec = other.VCodec;
            this.SubtitlesAvaliability = other.SubtitlesAvaliability;
            this.Size = other.Size;
            this.Player = other.Player;
        }

        public static List<VideoFile> FindObjectsWithCorespondingProperties(
            List<VideoFile> objects,
            Func<VideoFile, bool> predicate)
        {
            return objects.Where(predicate).ToList();
        }

        public static bool operator <(VideoFile left, VideoFile right)
        {
            return left.Duration < right.Duration;
        }
        public static bool operator >(VideoFile left, VideoFile right)
        {
            return left.Duration > right.Duration;
        }

        public string Name { get; set; }

        public string Location { get; set; }

        [JsonConverter(typeof(EnumConverter<VideoFormat>))]
        public VideoFormat Format { get; set; }

        public TimeSpan Duration { get; set; }

        [JsonConverter(typeof(EnumConverter<AudioCodec>))]
        public AudioCodec ACodec { get; set; }

        [JsonConverter(typeof(EnumConverter<VideoCodec>))]
        public VideoCodec VCodec { get; set; }

        public bool SubtitlesAvaliability { get; set; }

        public FileSize Size { get; set; }

        [JsonConverter(typeof(EnumConverter<VideoPlayer>))]
        public VideoPlayer Player { get; set; }
    }
}
