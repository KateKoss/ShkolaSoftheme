using ProtoBuf;
using System;
using System.Runtime.Serialization;


namespace HW21
{
    [ProtoContract]
    [DataContract]
    [KnownTypeAttribute(typeof(string))]
    [Serializable]
    public class ContactInfo
    {
        [DataMember]
        [ProtoMember(1)]
        public string name { get; set; }

        public ContactInfo()
        {
            
        }

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
