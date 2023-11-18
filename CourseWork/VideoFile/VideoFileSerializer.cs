using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using VideoFileClass;

namespace SecondaryClasses
{
    public static class VideoFileSerializer
    {
        public static void SerializeXml(List<VideoFile> objects, string filename)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<VideoFile>));

                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, objects);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<VideoFile> DeserializeXml(string filename)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<VideoFile>));

                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    return (List<VideoFile>)xml.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
