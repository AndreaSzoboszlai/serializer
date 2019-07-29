using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serializer
{
    [Serializable]
    class Person : ISerializable, IDeserializationCallback
    {
        public String address { get; set; }
        public String phoneNumber { get; set; }
        public DateTime dataRecorded { get; set; }
        [NonSerialized]
        public int serialNum;

        public string name { get; set; }

        public Person(string name, string address, string phoneNumber, int serialNum)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dataRecorded = DateTime.Now;
            this.serialNum = serialNum;
        }

        public void Serialize()
        {
            //Person person = this;
            //File.Create(output);
            Stream stream = File.Open(@"C:\Users\szobo\Documents\PersonSerializer\person" + serialNum + ".dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", name);
            info.AddValue("address", address);
            info.AddValue("phoneNumber", phoneNumber);
            info.AddValue("dataRecorded", dataRecorded);
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            name = (string)info.GetValue("name", typeof(string));
            address = (string)info.GetValue("address", typeof(string));
            phoneNumber = (string)info.GetValue("phoneNumber", typeof(string));
            dataRecorded = (DateTime)info.GetValue("dataRecorded", typeof(DateTime));
        }



        public void OnDeserialization(object sender)
        {
            string[] directories = Directory.GetFiles(@"C:\Users\szobo\Documents\PersonSerializer");
            serialNum = directories.Length;
        }
    }
}
