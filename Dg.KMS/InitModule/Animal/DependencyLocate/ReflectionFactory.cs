using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace Animal.DependencyLocate
{
    public class ReflectionFactory
    {
        private static String _windowType;
        private static String _buttonType;
        private static String _textBoxType;

        static ReflectionFactory()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.cnblogs.com/Config.xml");
            XmlNode xmlNode = xmlDoc.ChildNodes[1].ChildNodes[0];

            _windowType = xmlNode.ChildNodes[0].Value;
            _buttonType = xmlNode.ChildNodes[1].Value;
            _textBoxType = xmlNode.ChildNodes[2].Value;
        }

        public static IWindow MakeWindow()
        {
            return Assembly.Load("DependencyLocate").CreateInstance("DependencyLocate." + _windowType) as IWindow;
        }

        public static IButton MakeButton()
        {
            return Assembly.Load("DependencyLocate").CreateInstance("DependencyLocate." + _buttonType) as IButton;
        }

        public static ITextBox MakeTextBox()
        {
            return Assembly.Load("DependencyLocate").CreateInstance("DependencyLocate." + _textBoxType) as ITextBox;
        }
    }
}
