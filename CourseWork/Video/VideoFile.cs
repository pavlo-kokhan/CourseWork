

//Створити клас «VideoFile» для запису мультимедійної інформації про відео файл:
//1) Розміщення файлу на диску; 2) Формат файлу; 3) Тривалість; 4) Кодек відео; 5) Кодек аудіо;
//6) Наявність субтитрів; 7) Розмір відео; 8) Плеєр необхідний для відкриття даного файлу.
//Для класу створити: 1) Конструктор за замовчуванням; 2) Конструктор з параметрами; 3)
//конструктор копій; 4) конструктор переміщення; 5) перевизначити операції >>, << для
//зчитування та запису у файл. 

//Реалізувати:
//1) функції пошуку даних за «тривалістю» та за «розміщенням на диску».
//методи які повертають просто список об'єктів, в яких присутня передана властивість

//2) Згрупувати назви файлів, у яких однаковий кодек та відсортувати за тривалістю в кожній
//групі.
//в програмі зробити можливість фільтрування і сортування списку об'єктів.
//це забезпечить можливість знайти об'єкти в яких однаковий кодек і відсортувати цей список

//3) Знайти файли з найдовшою тривалістю та наявністю субтитрів одночасно (передбачити
//декілька однакових результатів).
//відфільтрувати за наявністю субтитрів і відсортувати за тривалістю

//4) Для файлів з однаковим форматом визначити найменший та найбільший розмір відео.
//відфільтрувати об'єкти за форматом, відсортувати за розміром, побачити відповідні об'єкти

//Реально з методів треба пошук за критерієм, сортування, серіалізація

//Для демонстрації роботи програми використати засоби візуального середовища
//програмування.
 

namespace CourseWork.Video
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;
    using global::Enums;
    using SecondaryClasses;

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
            SubtitlesAvailability = false;
            Size = new FileSize();
            Player = VideoPlayer.Undefined;
        }

        public VideoFile(
            string name, 
            string location, 
            VideoFormat format, 
            TimeSpan duration, 
            AudioCodec aCodec, 
            VideoCodec vCodec, 
            bool subtitlesAvailability, 
            FileSize size, 
            VideoPlayer player)
        {
            Name = name;
            Location = location;
            Format = format;
            Duration = duration;
            ACodec = aCodec;
            VCodec = vCodec;
            SubtitlesAvailability = subtitlesAvailability;
            Size = size;
            Player = player;
        }

        public TimeSpan GetDuration()
        {
            return Duration;
        }

        // Пошук даних за розміщенням на диску
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, string targetLocation)
        {
            return objects.Where(file => file.Location == targetLocation).ToList();
        }

        // Пошук даних за форматом
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, VideoFormat targetVideoFormat)
        {
            return objects.Where(file => file.Format == targetVideoFormat).ToList();
        }

        // Пошук даних за тривалістю
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, TimeSpan targetDuration)
        {
            return objects.Where(file => file.Duration == targetDuration).ToList();
        }

        // Пошук даних за аудіокодеком 
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, AudioCodec targetAudioCodec)
        {
            return objects.Where(file => file.ACodec == targetAudioCodec).ToList();
        }

        // Пошук даних за відеокодеком 
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, VideoCodec targetVideoCodec)
        {
            return objects.Where(file => file.VCodec == targetVideoCodec).ToList();
        }

        // Пошук даних за субтитрами
        public static List<VideoFile> FindObjectsWithCorrespondingProperties(List<VideoFile> objects, bool targetSubtitlesAvaliability)
        {
            return objects.Where(file => file.SubtitlesAvailability == targetSubtitlesAvaliability).ToList();
        }

        public static bool operator <(VideoFile left, VideoFile right)
        {
            return left.Duration < right.Duration;
        }
        public static bool operator >(VideoFile left, VideoFile right)
        {
            return left.Duration > right.Duration;
        }

        [XmlElement("Name")]
        public string Name { get; }

        [XmlElement("Location")]
        public string Location { get; }

        [XmlElement("Format")]
        public VideoFormat Format { get; }

        [XmlElement("Duration")]
        public TimeSpan Duration { get; }

        [XmlElement("ACodec")]
        public AudioCodec ACodec { get; }

        [XmlElement("VCodec")]
        public VideoCodec VCodec { get; }

        [XmlElement("SubtitlesAvaliability")]
        public bool SubtitlesAvailability { get; }

        [XmlElement("Size")]
        public FileSize Size { get; }

        [XmlElement("Player")]
        public VideoPlayer Player { get; }
    }
}
