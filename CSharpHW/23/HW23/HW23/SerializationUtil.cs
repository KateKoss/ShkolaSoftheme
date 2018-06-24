using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml.Linq;
using ProtoBuf;

namespace HW23
{
    class SerializationUtil
    {
        public static void SerializeToBinary(string fileName, List<MobileAccount> mobileAcconts)
        {
            var binFormater = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                binFormater.Serialize(fs, mobileAcconts);
            }
        }

        public static List<MobileAccount> DeserializeFromBinary(string fileName)
        {
            var binFormater = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<MobileAccount>)binFormater.Deserialize(fs);
            }
        }

        public static void SerializeToXML(string fileName, List<MobileAccount> mobileAcconts)
        {
            var xmlFormater = new DataContractSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlFormater.WriteObject(fs, mobileAcconts);
            }
        }

        public static List<MobileAccount> DeserializeFromXML(string fileName)
        {
            var xmlFormater = new DataContractSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<MobileAccount>)xmlFormater.ReadObject(fs);
            }
        }

        public static void SerializeToJSON(string fileName, List<MobileAccount> mobileAcconts)
        {
            var jsonFormater = new DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormater.WriteObject(fs, mobileAcconts);
            }
        }

        public static List<MobileAccount> DeserializeFromJSON(string fileName)
        {
            var jsonFormater = new DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<MobileAccount>)jsonFormater.ReadObject(fs);
            }
        }

        public static void FindAccountByNumber(string fileName, string number)
        {
            
            XDocument doc = XDocument.Load(fileName);
            Console.WriteLine(doc);
            XElement accs = doc.Element("ArrayOfMobileAccount").Element("Accounts"); // accs = NULL Why?
            if (accs != null)
            {
                foreach (XElement acc in accs.Elements("MobileAccount"))
                {
                    XElement dateElem = acc.Element("_x003C_Birthday_x003E_k__BackingField");
                    Console.WriteLine(dateElem);
                }
            }            
        }
    }
}
