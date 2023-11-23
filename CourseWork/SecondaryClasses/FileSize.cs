using System;

namespace SecondaryClasses
{
    [Serializable]
    public class FileSize
    {
        // Символ розділювач
        private const char SEPARATOR = ' ';

        // Константа, яка використовується для конвертації у стрічку та зі стрічки в об'єкт
        public const uint BYTES_IN_KILOBYTE = 1024;

        // Конструктор за замовчуванням
        public FileSize()
        {
            Bytes = 0;
        }

        // Конструктор з параметром
        public FileSize(ulong bytes)
        {
            Bytes = bytes;
        }

        // Конструктор копіювання
        public FileSize(FileSize other)
        {
            Bytes = other.Bytes;
        }

        // Метод для конвертування у тип string
        public override string ToString()
        {
            // В залежності від того скільки байт,
            // повертаємо стрічкове значення в правильній розмірності
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

        // Метод для конвертування з типу string у тип VideoSize
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

            // В залежності від того, яка розмірність була вказана у стрічці, конвертуємо у байти
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

        // Додатковий метод, для конвертації
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
