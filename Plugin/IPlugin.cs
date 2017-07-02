using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Plugin
{
    public interface IPlugin
    {
        XDocument run(XDocument lkp);

        XDocument run(XDocument lkp, XDocument data);

        string Name { get;}

        PluginType Type { get;}
    }

    public enum PluginType { 
        HOH, IND, BOTH
    }
}
