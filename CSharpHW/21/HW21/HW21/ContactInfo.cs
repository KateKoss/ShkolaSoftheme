using System;
using System.Runtime.Serialization;


namespace HW21
{
    [DataContract]
    [KnownTypeAttribute(typeof(string))]
    [Serializable]
    public class ContactInfo
    {
        [DataMember]
        public string name { get; set; }

        public ContactInfo(string name)
        {
            this.name = name;
        }

        override
        public string ToString()
        {
            return name;
        }
    }
}
