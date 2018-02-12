using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Demo_TheTravelingSalesperson
{
    class DataSettings
    {
        public const string dataFilePathXml = "Data\\Data.xml";

        public void SeedDataFile()
        {
            XmlServices xmlService = new XmlServices(DataSettings.dataFilePathXml);

        }
    }
}
