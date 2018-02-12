using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    class XmlServices
    {
        private string _dataFilePath;
        public XmlServices(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }


        public Salesperson ReadSalespersonFromDataFile()
        {
            Salesperson salesperson = new Salesperson();


            //Initialize a Filestream Object
            StreamReader sr = new StreamReader(_dataFilePath);


            //Initialize XML serilizer object
            XmlSerializer deserializer = new XmlSerializer(typeof(Salesperson));


            using (sr)
            {
                object xmlObj = deserializer.Deserialize(sr);


                Console.WriteLine(xmlObj);


                salesperson = (Salesperson)xmlObj;
            }


            return salesperson;
        }


        public void WriteSalespersonToDataFile(Salesperson salesperson)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Salesperson), new XmlRootAttribute("Salesperson"));

            StreamWriter sw = new StreamWriter(_dataFilePath);

            using (sw)
            {
                serializer.Serialize(sw, salesperson);
            }
        }
    }
}
