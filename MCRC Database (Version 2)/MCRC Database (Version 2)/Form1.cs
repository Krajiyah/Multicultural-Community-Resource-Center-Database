using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Windows.Forms;

namespace MCRC_Database__Version_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //id numbers in database are false, do not use them in functions use element count systems instead.
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("database(2).xml");            
            foreach (XmlNode node1 in doc1.SelectNodes("/database/person"))
            {
                if (job.Items.Count == 0)
                {
                    job.Items.Add(node1.Attributes[4].Value);                   
                }
                else
                {
                    bool x = false;
                    for (int i = 0; i < job.Items.Count; i++)
                    {            
                        if(node1.Attributes[4].Value == job.Items[i].ToString())
                        {
                            x = true;
                            break;
                        }
                        else if (node1.Attributes[4].Value == "")
                        {
                            x = true;
                            break;
                        }
                    }
                    if(x == false)
                    {
                        job.Items.Add(node1.Attributes[4].Value);
                    }
                }
                if(country.Items.Count == 0) 
                {
                    country.Items.Add(node1.Attributes[5].Value);
                }
                else
                {
                    bool y = false;
                    for (int i = 0; i < country.Items.Count; i++)
                    {
                        if (node1.Attributes[5].Value == country.Items[i].ToString())
                        {
                            y = true;
                            break;
                        }
                        else if (node1.Attributes[5].Value == "")
                        {
                            y = true;
                            break;
                        }
                    }
                    if (y == false)
                    {
                        country.Items.Add(node1.Attributes[5].Value);
                    }
                }
            }            
        }

        private void search_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("database(2).xml");
            int total = 0;
            foreach (XmlNode person in xml.SelectNodes("/database/person"))
            {   
                int age_test = ((int)(int.Parse(person.Attributes[1].Value) / 10))*10;
                string ed_test = person.Attributes[2].Value;
                string year_test = person.Attributes[3].Value;
                string job_test = person.Attributes[4].Value;
                string country_test = person.Attributes[5].Value;
                bool match1 = false;   
                bool match2 = false;  
                bool match3 = false;  
                bool match4 = false;  
                bool match5 = false;                  
                if (age.Text != "" && int.Parse(age.Text) == age_test)
                    match1 = true;
                if(age.Text == "")
                    match1 = true;                                               
                if (ed.Text != "" && ed.Text == ed_test)
                    match2 = true;
                if(ed.Text == "")
                    match2 = true;                   
                if (year.Text != "" && year.Text == year_test)
                    match3 = true;
                if(year.Text == "")
                    match3 = true;
                if (job.Text != "" && job.Text == job_test)
                    match4 = true;
                if(job.Text == "")
                    match4 = true;
                if (country.Text != "" && country.Text == country_test)
                    match5 = true;
                if (country.Text == "")
                    match5 = true;
                if (match1 == true && match2 == true && match3 == true && match4 == true && match5 == true)
                {
                    total += 1;
                }
                result.Text = total.ToString();
            }
        }
    }
}
