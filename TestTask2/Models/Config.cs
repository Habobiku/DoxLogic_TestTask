using System;
using System.Xml.Serialization;

namespace TestTask2.Models
{
    [Serializable]
    [XmlRoot("Configuration")]
    public class Config
    {
        [XmlElement("Host")]
      public string Host { get; set; }
       [XmlElement("User")]
        public string User { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
       [XmlElement("Port")]
        public string Port { get; set; }
        [XmlElement("Database")]
        public string Database { get; set; }
    }
}
