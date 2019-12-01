using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Animal.DependencyLocate
{
    public class FactoryContainer
    {
        public static IFactory factory { get; private set; }

        public  FactoryContainer()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.cnblogs.com/Config.xml");
            XmlNode xmlNode = xmlDoc.ChildNodes[1].ChildNodes[0].ChildNodes[0];

            if ("Windows" == xmlNode.Value)
            {
                factory = new WindowsFactory();
            }
            else if ("Mac" == xmlNode.Value)
            {
                factory = new MacFactory();
            }
            else
            {
                throw new Exception("Factory Init Error");
            }
        }
    }
}
