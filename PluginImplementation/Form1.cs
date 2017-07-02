using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PluginImplementation
{
    public partial class Form1 : Form
    {
        public XDocument data;

        public  Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            data = XDocument.Parse("<test>1</test>");
 
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("some message!");
            //test xml here 

        }
    }
}
