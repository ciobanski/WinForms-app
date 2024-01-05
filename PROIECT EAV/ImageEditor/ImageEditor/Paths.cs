using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImageEditor
{
    [XmlRoot("Paths")]
    public class Paths
    {
        [XmlElement("Path")]
        public BindingList<string> PathList { get; set; }

        public Paths()
        {
            PathList = new BindingList<string>();
        }
    }
}