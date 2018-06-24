using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator lifecellOperator = new MobileOperator("Lifecell");
            lifecellOperator.CreateAccounts();
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[1], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[3], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            lifecellOperator.users[2].SendSMS(lifecellOperator.users[5], "Hi! How are you?");
            lifecellOperator.users[2].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            Console.WriteLine(new string('-', 20));

            lifecellOperator.users[0].Call(lifecellOperator.users[2]);
            lifecellOperator.users[0].Call(lifecellOperator.users[4]);
            lifecellOperator.users[0].Call(lifecellOperator.users[4]);
            lifecellOperator.users[1].Call(lifecellOperator.users[4]);
            lifecellOperator.users[1].Call(lifecellOperator.users[5]);
            lifecellOperator.users[1].Call(lifecellOperator.users[1]);
            lifecellOperator.users[1].Call(lifecellOperator.users[3]);
                        
            lifecellOperator.StatisticByReceive();
            Console.WriteLine(new string('-', 20));
            lifecellOperator.StatisticByOutput();
            lifecellOperator.AddAccount("sd", "fds", "dsf", new DateTime(2040, 5, 6));
            Console.WriteLine("\nDeserializeFromBinary");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            SerializationUtil.SerializeToBinary("usersBin.dat", lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms", stopwatch.ElapsedMilliseconds);
            SerializationUtil.DeserializeFromBinary("usersBin.dat").ForEach(x =>
            {
                Console.WriteLine(x.FirstName);
            });

            Console.WriteLine("\nDeserializeFromXML");
            stopwatch.Restart();
            SerializationUtil.SerializeToXML("usersXml.xml", lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms", stopwatch.ElapsedMilliseconds);
            SerializationUtil.DeserializeFromXML("usersXml.xml").ForEach(x =>
            {
                Console.WriteLine(x.FirstName);
            });
            Console.WriteLine("\nDeserializeFromJSON");
            stopwatch.Restart();
            SerializationUtil.SerializeToJSON("usersJson.txt", lifecellOperator.GetUsers());
            stopwatch.Stop();
            Console.WriteLine("Serialized in {0} ms", stopwatch.ElapsedMilliseconds);
            SerializationUtil.DeserializeFromJSON("usersJson.txt").ForEach(x => 
            {
                Console.WriteLine(x.FirstName);
            });
            Console.ReadKey();
        }
    }
}
