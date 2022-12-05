using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using TestTask2.Models;

namespace TestTask2
{
    public class Extentions
    {
        private static readonly String _filepath = "/Users/Habob/Projects/TestTask2/TestTask2/Config/Config.xml";
        public static Config GetConfig()
        {
                Config objectToDeserialize = new Config();
                XmlSerializer xmlserializer = new XmlSerializer(objectToDeserialize.GetType());
                        
                using (StreamReader streamReader = new StreamReader(_filepath))
                {
                    return (Config)xmlserializer.Deserialize(streamReader);
                }
        }   
    }
}
