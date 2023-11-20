using System;
using System.Xml.Serialization;

namespace SecondaryClasses
{
    [Serializable]
    public class FileSize
    {
        public FileSize()
        {
            Kilobytes = 0;
        }

        public FileSize(uint kilobytes)
        {
            Kilobytes = kilobytes;
        }

        public FileSize(uint kilobytes, uint megabytes)
        {
            Kilobytes = kilobytes + megabytes * 1024;
        }

        public FileSize(uint kilobytes, uint megabytes, uint gigabytes)
        {
            Kilobytes = kilobytes + megabytes * 1024 + gigabytes * 1024 * 1024;
        }

        public FileSize(FileSize other)
        {
            Kilobytes = other.Kilobytes;
        }

        public override string ToString()
        {
            uint gigabytesChunk, megabytesChunk, kilobytesChunk;

            kilobytesChunk = Kilobytes % 1024;
            megabytesChunk = Kilobytes / 1024;

            gigabytesChunk = megabytesChunk / 1024;
            megabytesChunk = megabytesChunk % 1024;

            return string.Join("-", gigabytesChunk, megabytesChunk, kilobytesChunk);
        }

        public static FileSize Parse(string sizeString)
        {
            if (string.IsNullOrWhiteSpace(sizeString))
            {
                throw new ArgumentException("Size string is empty or null.");
            }

            string[] chunks = sizeString.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (chunks.Length != 3)
            {
                throw new FormatException("Invalid size string format.");
            }

            if (!uint.TryParse(chunks[0], out uint gb) ||
                !uint.TryParse(chunks[1], out uint mb) ||
                !uint.TryParse(chunks[2], out uint kb))
            {
                throw new FormatException("Invalid size values.");
            }

            return new FileSize(kb, mb, gb);
        }

        public static bool TryParse(string sizeString, out FileSize fileSize)
        {
            fileSize = null;

            if (string.IsNullOrWhiteSpace(sizeString))
            {
                return false;
            }

            string[] chunks = sizeString.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (chunks.Length != 3)
            {
                return false;
            }

            if (!uint.TryParse(chunks[0], out uint gb) ||
                !uint.TryParse(chunks[1], out uint mb) ||
                !uint.TryParse(chunks[2], out uint kb))
            {
                return false;
            }

            fileSize = new FileSize(kb, mb, gb);

            return true;
        }

        public uint Kilobytes { get; set; }

        [XmlElement("Kilobytes")]
        public string KilobytesString
        {
            get { return Kilobytes.ToString(); }
            set { Kilobytes = uint.Parse(value); }
        }
    }
}
