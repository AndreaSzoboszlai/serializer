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
    class Serializer
    {
        public Person DeSerialize(int serialNum)
        {
            Stream stream = new FileStream(@"C:\Users\szobo\Documents\PersonSerializer\person" + serialNum + ".dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Person newPerson = (Person)formatter.Deserialize(stream);
            return newPerson;
            //Console.WriteLine(newPerson.name);
            //Console.ReadKey();
        }

        public Person DeSerialize()
        {
            string[] directories = Directory.GetFiles(@"C:\Users\szobo\Documents\PersonSerializer");
            int serialNum = directories.Length;
            Console.WriteLine(serialNum);
            Stream stream = new FileStream(@"C:\Users\szobo\Documents\PersonSerializer\person" + serialNum + ".dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Person newPerson = (Person)formatter.Deserialize(stream);
            return newPerson;
            //Console.WriteLine(newPerson.name);
            //Console.ReadKey();
        }
    }
}
