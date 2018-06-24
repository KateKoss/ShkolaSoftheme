using System;
using System.Diagnostics;
using System.IO;

namespace HW21
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator lifecellOperator = new MobileOperator("Lifecell");
            lifecellOperator.CreateAccounts();
            string binaryFile = "usersBin.dat";
            string xmlFile = "usersXml.xml";
            string jsonFile = "usersJson.txt";
            string protoBufFile = "usersProtoBuf.bin";

            Console.WriteLine("\n-------------Serialized to Binary-------------");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            SerializationUtil.SerializeToBinary(binaryFile, lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms, file size {1}", stopwatch.ElapsedMilliseconds, new FileInfo(binaryFile).Length);
            Console.WriteLine("Deserialized From Binary");
            SerializationUtil.DeserializeFromBinary(binaryFile).ForEach(x =>
            {
                Console.WriteLine(x.FirstName);
            });

            Console.WriteLine("\n-------------Serialize to XML-------------");
            stopwatch.Restart();
            SerializationUtil.SerializeToXML(xmlFile, lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms, file size {1}", stopwatch.ElapsedMilliseconds, new FileInfo(xmlFile).Length);
            Console.WriteLine("Deserialized From XML");
            SerializationUtil.DeserializeFromXML(xmlFile).ForEach(x =>
            {
                Console.WriteLine(x.FirstName);
            });

            Console.WriteLine("\n-------------Serialize to JSON-------------");
            stopwatch.Restart();
            SerializationUtil.SerializeToJSON(jsonFile, lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms, file size {1}", stopwatch.ElapsedMilliseconds, new FileInfo(jsonFile).Length);
            Console.WriteLine("Deserialized From JSON");
            SerializationUtil.DeserializeFromJSON(jsonFile).ForEach(x => 
            {
                Console.WriteLine(x.FirstName);
            });

            Console.WriteLine("\n-------------Serialize to ProtoBuf-------------");
            stopwatch.Restart();
            SerializationUtil.SerializeToProtoBuf(protoBufFile, lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms, file size {1}", stopwatch.ElapsedMilliseconds, new FileInfo(protoBufFile).Length);
            Console.WriteLine("Deserialized From ProtoBuf");
            SerializationUtil.DeserializeFromProtoBuf(protoBufFile).ForEach(x =>
            {
                Console.WriteLine(x.FirstName);
            });
            Console.ReadKey();
        }
    }
}
