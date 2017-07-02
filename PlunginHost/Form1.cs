using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Plugin;
using System.Reflection;
using System.Xml.Linq;


namespace PlunginHost
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                Assembly a = Assembly.LoadFrom(op.FileName);

                Type t = a.GetType("PluginImplementation.Form1");

                IPlugin p = Activator.CreateInstance(t) as IPlugin;

                XDocument dummydata = XDocument.Parse(string.Format("<module ID='1'></module>"));
            
                XDocument dummyresult = p.run(dummydata);  

                donothing();
            }
        }

        private void donothing()
        {
            return;
        }
    }
}
