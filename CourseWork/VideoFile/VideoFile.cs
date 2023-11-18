﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using Microsoft.SqlServer.Server;
using System.Xml.Serialization;
using System.Xml.Linq;

using Enums;
using SecondaryClasses;
using static System.Windows.Forms.DataFormats;
using System.Drawing;

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

        [XmlIgnore] private string Name { get; set; }

        [XmlIgnore] private string Location { get; set; }

        [XmlIgnore] private VideoFormat Format { get; set; }

        [XmlIgnore] private TimeSpan Duration { get; set; }

        [XmlIgnore] private AudioCodec ACodec { get; set; }

        [XmlIgnore] private VideoCodec VCodec { get; set; }

        [XmlIgnore] private bool SubtitlesAvaliability { get; set; }

        [XmlIgnore] private FileSize Size { get; set; }

        [XmlIgnore] private VideoPlayer Player { get; set; }

        [XmlElement("Name")]
        public string NameString
        {
            get { return Name; }
            set { Name = value; }
        }

        [XmlElement("Location")]
        public string LocationString
        {
            get { return Location; }
            set { Location = value; }
        }

        [XmlElement("Format")]
        public VideoFormat FormatString
        {
            get { return Format; }
            set { Format = value; }
        }

        [XmlElement("Duration")]
        public string DurationString
        {
            get { return XmlConvert.ToString(Duration); }
            set { Duration = XmlConvert.ToTimeSpan(value); }
        }

        [XmlElement("ACodec")]
        public AudioCodec ACodecString
        {
            get { return ACodec; }
            set { ACodec = value; }
        }

        [XmlElement("VCodec")]
        public VideoCodec VCodecString
        {
            get { return VCodec; }
            set { VCodec = value; }
        }

        [XmlElement("SubtitlesAvaliability")]
        public bool SubtitlesAvaliabilityString
        {
            get { return SubtitlesAvaliability; }
            set { SubtitlesAvaliability = value; }
        }

        [XmlElement("Size")]
        public FileSize SizeString
        {
            get { return Size; }
            set { Size = value; }
        }

        [XmlElement("Player")]
        public VideoPlayer PlayerString
        {
            get { return Player; }
            set { Player = value; }
        }
    }
}
