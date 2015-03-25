using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.XPath;

namespace MCRC_Client_Database
{
    public partial class charted_data : Form
    {
        public charted_data()
        {
            InitializeComponent();
        }

        private void charted_data_Load(object sender, EventArgs e)
        {
            chart1.Dock = DockStyle.Fill;
            chart1.Series.Clear();
            XPathDocument doc = new XPathDocument("Database.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathExpression country;
            country = nav.Compile("/database/person/country");
            XPathNodeIterator countryval;
            countryval = nav.Select(country);
            string[] countries = new string[99];
            int index = 0;
            try
            {
                while (countryval.MoveNext())
                {
                    XPathNavigator nav2 = countryval.Current.Clone();
                    countries.SetValue(nav2.Value, index);                    
                    index++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! \n" + ex.Message);
            }            
            string[] newcountries = countries.Distinct().ToArray();
            for (int i = 0; i <= newcountries.Length - 1; i++)
            {
                if(newcountries[i] != null)
                    chart1.Series.Add(newcountries[i]);
            }
            /* TODO!          
            *add pointsXY
             *x-axis? (what years should be on there?)
             *y-axis? (what variable is being shown as haveing a trend?)
           */
        }
    }
}
