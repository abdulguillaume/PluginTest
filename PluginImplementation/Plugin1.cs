using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Plugin;
using System.Xml.Linq;

namespace PluginImplementation
{
    class Plugin1 : IPlugin
    {
        private string _name;

        public Plugin1(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }

        }


        public XDocument run(XDocument lkp)
        {
            XDocument _data = null;

            using (Form1 f = new Form1())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _data = f.data;
                }

            }

            return _data;
        }

        public XDocument run(XDocument lkp, XDocument data)
        {
            throw new NotImplementedException();
        }

        public PluginType Type
        {
            get { return PluginType.BOTH; }
        }
    }
}
