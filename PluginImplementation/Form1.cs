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
        private string msg;

        public XDocument data;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string _msg)
        {
            msg = _msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(msg);
            //test xml here 
            data = XDocument.Parse(string.Format("<modules><module ID='{0}'><HOHID>TEST001</HOHID><HHSkippedEating>1</HHSkippedEating><txtNbDays>2</NbDays><NbMeals>1</NbMeals><HHIncomeEarningActivity>1</HHIncomeEarningActivity><HHAccessCultivableLand>0</HHAccessCultivableLand><HHChildRecTreatmentMalnutrition>1</HHChildRecTreatmentMalnutrition></module><module ID='2'><HOHID>TEST002</HOHID></module></modules>", 1));
 
        }
    }
}
