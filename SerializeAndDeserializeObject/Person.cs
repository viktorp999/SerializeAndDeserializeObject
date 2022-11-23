using System;
using System.Xml.Serialization;

namespace SerializeAndDeserializeObject
{
    [Serializable]
    [XmlRoot("PersonInfo")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTeenager { get; set; }

        [XmlElement("Adress")]
        public Adress adress { get; set; }
    }
}
