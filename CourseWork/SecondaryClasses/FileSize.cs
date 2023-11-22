using System;

namespace SecondaryClasses
{
    [Serializable]
    public class FileSize
    {
        private const char SEPARATOR = '-';

        private const uint BYTES_IN_KILOBYTE = 1024;

        public FileSize()
        {
            Kilobytes = 0;
        }

        public FileSize(uint kilobytes)
        {
            Kilobytes = kilobytes;
        }

        public FileSize(uint kilobytes, uint megabytes, uint gigabytes)
        {
            Kilobytes = kilobytes + megabytes * BYTES_IN_KILOBYTE + gigabytes * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE;
        }

        public FileSize(FileSize other)
        {
            Kilobytes = other.Kilobytes;
        }

        public override string ToString()
        {
            uint gigabytesChunk, megabytesChunk, kilobytesChunk;

            kilobytesChunk = Kilobytes % BYTES_IN_KILOBYTE;
            megabytesChunk = Kilobytes / BYTES_IN_KILOBYTE;

            gigabytesChunk = megabytesChunk / BYTES_IN_KILOBYTE;
            megabytesChunk = megabytesChunk % BYTES_IN_KILOBYTE;

            return string.Join(SEPARATOR.ToString(), gigabytesChunk, megabytesChunk, kilobytesChunk);
        }

        public static FileSize Parse(string sizeString)
        {
            if (string.IsNullOrWhiteSpace(sizeString))
            {
                throw new ArgumentException("Size string is empty or null.");
            }

            string[] chunks = sizeString.Split(new[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

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

            string[] chunks = sizeString.Split(new[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

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
    }
}
