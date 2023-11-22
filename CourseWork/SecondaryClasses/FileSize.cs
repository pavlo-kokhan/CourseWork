using System;

namespace SecondaryClasses
{
    [Serializable]
    public class FileSize
    {
        private const char SEPARATOR = ' ';

        public const uint BYTES_IN_KILOBYTE = 1024;

        public FileSize()
        {
            Bytes = 0;
        }

        public FileSize(ulong bytes)
        {
            Bytes = bytes;
        }

        public FileSize(FileSize other)
        {
            Bytes = other.Bytes;
        }

        public override string ToString()
        {
            // we have less than 1024               bytes: result will be a string in bytes:     n B
            // we have more than 1024               bytes: result will be a string in kilobytes: n KB
            // we have more than 1024 * 1024        bytes: result will be a string in megabytes: n MB
            // we have more than 1024 * 1024 * 1024 bytes: result will be a string in gigabytes: n GB

            if (Bytes < BYTES_IN_KILOBYTE)
            {
                return $"{Bytes} B";
            }
            else if (Bytes < BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE)
            {
                return $"{Bytes / BYTES_IN_KILOBYTE} KB";
            }
            else if (Bytes < BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE)
            {
                return $"{Bytes / (BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE)} MB";
            }
            else
            {
                return $"{Bytes / (BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE)} GB";
            }
        }

        public static FileSize Parse(string sizeString)
        {
            string[] parts = sizeString.Split(SEPARATOR);

            if (parts.Length != 2)
            {
                throw new FormatException("Invalid format for FileSize string.");
            }

            if (!ulong.TryParse(parts[0], out ulong value))
            {
                throw new FormatException("Invalid numeric value in FileSize string.");
            }

            string unit = parts[1].ToLower();

            switch (unit)
            {
                case "b":
                    return new FileSize(value);
                case "kb":
                    return new FileSize(value * BYTES_IN_KILOBYTE);
                case "mb":
                    return new FileSize(value * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE);
                case "gb":
                    return new FileSize(value * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE * BYTES_IN_KILOBYTE);
                default:
                    throw new FormatException("Invalid unit in FileSize string.");
            }
        }

        public static bool TryParse(string sizeString, out FileSize fileSize)
        {
            fileSize = null;

            try
            {
                fileSize = Parse(sizeString);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public ulong Bytes { get; set; }
    }
}
