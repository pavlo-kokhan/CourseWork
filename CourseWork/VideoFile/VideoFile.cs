using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

using Enums;
using SecondaryClasses;

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

        public VideoFile(VideoFile Other)
        {
            this.Name = Other.Name;
            this.Location = Other.Location;
            this.Format = Other.Format;
            this.Duration = Other.Duration;
            this.ACodec = Other.ACodec;
            this.VCodec = Other.VCodec;
            this.SubtitlesAvaliability = Other.SubtitlesAvaliability;
            this.Size = Other.Size;
            this.Player = Other.Player;
        }

        public TimeSpan GetDuration()
        {
            return Duration;
        }

        // Пошук даних за розміщенням на диску
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, string targetLocation)
        {
            return objects.Where(file => file.Location == targetLocation).ToList();
        }

        // Пошук даних за форматом
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, VideoFormat targetVideoFormat)
        {
            return objects.Where(file => file.Format == targetVideoFormat).ToList();
        }

        // Пошук даних за тривалістю
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, TimeSpan targetDuration)
        {
            return objects.Where(file => file.Duration == targetDuration).ToList();
        }

        // Пошук даних за аудіокодеком 
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, AudioCodec targetAudioCodec)
        {
            return objects.Where(file => file.ACodec == targetAudioCodec).ToList();
        }

        // Пошук даних за відеокодеком 
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, VideoCodec targetVideoCodec)
        {
            return objects.Where(file => file.VCodec == targetVideoCodec).ToList();
        }

        // Пошук даних за субтитрами
        public static List<VideoFile> FindObjectsWithCorespondingProperties(List<VideoFile> objects, bool targetSubtitlesAvaliability)
        {
            return objects.Where(file => file.SubtitlesAvaliability == targetSubtitlesAvaliability).ToList();
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
        public string Name { get; set; }

        [XmlElement("Location")]
        public string Location { get; set; }
            
        [XmlIgnore] public VideoFormat Format { get; set; }

        [XmlIgnore] public TimeSpan Duration { get; set; }

        [XmlIgnore] public AudioCodec ACodec { get; set; }

        [XmlIgnore] public VideoCodec VCodec { get; set; }

        [XmlIgnore] public bool SubtitlesAvaliability { get; set; }

        [XmlIgnore] public FileSize Size { get; set; }

        [XmlIgnore] public VideoPlayer Player { get; set; }


        [XmlElement("Format")]
        public string FormatString
        {
            get { return Format.ToString(); }
            set { Format = (VideoFormat)Enum.Parse(typeof(VideoFormat), value); }
        }

        [XmlElement("Duration")]
        public string DurationString
        {
            get { return XmlConvert.ToString(Duration); }
            set { Duration = XmlConvert.ToTimeSpan(value); }
        }

        [XmlElement("ACodec")]
        public string ACodecString
        {
            get { return ACodec.ToString(); }
            set { ACodec = (AudioCodec)Enum.Parse(typeof(AudioCodec), value); }
        }

        [XmlElement("VCodec")]
        public string VCodecString
        {
            get { return VCodec.ToString(); }
            set { VCodec = (VideoCodec)Enum.Parse(typeof(VideoCodec), value); }
        }

        [XmlElement("SubtitlesAvaliability")]
        public string SubtitlesAvaliabilityString
        {
            get { return XmlConvert.ToString(SubtitlesAvaliability); }
            set { SubtitlesAvaliability = XmlConvert.ToBoolean(value); }
        }

        [XmlElement("Size")]
        public string SizeString
        {
            get { return Size.ToString(); }
            set { Size = FileSize.Parse(value); }
        }

        [XmlElement("Player")]
        public string PlayerString
        {
            get { return Player.ToString(); }
            set { Player = (VideoPlayer)Enum.Parse(typeof(VideoPlayer), value); }
        }
    }
}
