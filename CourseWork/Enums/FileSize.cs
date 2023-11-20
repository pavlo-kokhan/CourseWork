using System;
using System.Xml.Serialization;

namespace SecondaryClasses
{
    [Serializable]
    public class FileSize
    {
        public FileSize()
        {
            KB = 0;
            MB = 0;
            GB = 0;
        }

        public FileSize(uint KB, uint MB, uint GB)
        {
            this.KB = 0;
            this.MB = 0;
            this.GB = 0;

            if (KB <= 1023) { this.KB = KB; }
            else
            {
                this.MB = KB / 1024;
                this.KB = KB % 1024;
            }

            if (MB <= 1023) { this.MB += MB; }
            else
            {
                this.GB = MB / 1024;
                this.MB += MB % 1024;
            }

            this.GB += GB;
        }

        public FileSize(FileSize Other)
        {
            KB = Other.KB;
            MB = Other.MB;
            GB = Other.GB;
        }

        public uint GetAllInKB()
        {
            return (1024 * 1024 * GB) + (1024 * MB) + KB;
        }

        public double GetAllInMB()
        {
            return Convert.ToDouble(GetAllInKB()) / 1024.0;
        }

        public double GetAllInGB()
        {
            return GetAllInMB() / 1024;
        }

        public override string ToString()
        {
            return Convert.ToString(GB) + "-" + Convert.ToString(MB) + "-" + Convert.ToString(KB);
        }

        public static FileSize Parse(string sizeString)
        {
            if (string.IsNullOrWhiteSpace(sizeString))
            {
                throw new ArgumentException("Size string is empty or null.");
            }

            string[] parts = sizeString.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                throw new FormatException("Invalid size string format.");
            }

            if (!uint.TryParse(parts[0], out uint gb) ||
                !uint.TryParse(parts[1], out uint mb) ||
                !uint.TryParse(parts[2], out uint kb))
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

            string[] parts = sizeString.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                return false;
            }

            if (!uint.TryParse(parts[0], out uint gb) ||
                !uint.TryParse(parts[1], out uint mb) ||
                !uint.TryParse(parts[2], out uint kb))
            {
                return false;
            }

            fileSize = new FileSize(kb, mb, gb);
            return true;
        }

        [XmlIgnore] private uint KB { get; set; }

        [XmlIgnore] private uint MB { get; set; }

        [XmlIgnore] private uint GB { get; set; }

        [XmlElement("KB")]
        public string KBString
        {
            get { return KB.ToString(); }
            set { KB = uint.Parse(value); }
        }

        [XmlElement("MB")]
        public string MBString
        {
            get { return MB.ToString(); }
            set { MB = uint.Parse(value); }
        }

        [XmlElement("GB")]
        public string GBString
        {
            get { return GB.ToString(); }
            set { GB = uint.Parse(value); }
        }
    }
}
