using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _07.XmlFromTextFile
{
    class XmlFromTextFile
    {
        static void Main(string[] args)
        {
            XElement person = new XElement("person");
            using (StreamReader reader = new StreamReader("..\\..\\person.txt"))
            {
                var personData = reader.ReadToEnd();
                var separatedPersonData = personData.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var name = new XElement("name");
                name.Value = separatedPersonData[0];
                person.Add(name);

                var address = new XElement("address");
                address.Value = separatedPersonData[1];
                person.Add(address);

                var phone = new XElement("phone");
                phone.Value = separatedPersonData[2];
                person.Add(phone);
            }

            person.Save("..\\..\\person.xml");
        }
    }
}
