using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Windows.Forms;

namespace MCRC_Client_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }   
        string[] country_test;
        string[] job_test;
        string fileName = "Database.xml";       
        string GetText(string n, string element)
        {
            string ElementText = "";
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();
            string xpath = @"//database/person[@title='" + n + "']/" + element;
            XPathExpression y = nav.Compile(xpath);
            XPathNodeIterator i;
            i = nav.Select(y);
            try
            {
                while (i.MoveNext())
                {
                    XPathNavigator nav2 = i.Current.Clone();
                    ElementText = nav2.Value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! \n" + ex.Message);
            } 
        
            return ElementText;
        }
        

        private void Add_Click(object sender, EventArgs e)
        {
            string i = id.Text;            
            bool fail = false;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(fileName);
            foreach (XmlNode node in doc1.SelectNodes("/database/person/id"))
            {
                if (node.InnerXml == i)
                {
                    MessageBox.Show("Can't add person (ID=" + i + ") because he/she was already entered!");
                    fail = true;
                    break;
                }
            }            
            if (fail == false)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                XmlElement elem = doc.CreateElement("person");
                doc.DocumentElement.AppendChild(elem);
                XmlElement Id = doc.CreateElement("id");
                Id.InnerXml = id.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(Id);
                XmlElement age = doc.CreateElement("age");
                age.InnerXml = Age.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(age);
                XmlElement country = doc.CreateElement("country");
                country.InnerXml = Country.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(country);
                XmlElement dt = doc.CreateElement("dt");
                dt.InnerXml = Dt.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(dt);
                XmlElement ed = doc.CreateElement("ed");
                ed.InnerXml = Ed.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(ed);
                XmlElement job = doc.CreateElement("job");
                job.InnerXml = Occupation.Text.Trim();
                doc.DocumentElement.LastChild.AppendChild(job);
                doc.Save(fileName);
                System.Media.SystemSounds.Exclamation.Play();                
            }
            id.Text = "";
            Age.Text = "";
            Occupation.Text = "";
            Country.Text = "";
            Dt.Text = "";
            Ed.Text = "";
        }

        string GetTotalPeople()
        {
            int total = 0;                  
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression exp;
            exp = nav.Compile("/database/person/id");
            XPathNodeIterator it;
            it = nav.Select(exp);
            try
            {
                while (it.MoveNext())
                {
                    XPathNavigator nav2 = it.Current.Clone();
                    if (int.Parse(nav2.Value) > total)
                    {
                        total = int.Parse(nav2.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! \n" + ex.Message);
            }
            return total.ToString();            
        }

        int index = 0;
        private void Ct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Total.Text = "";
                if (Ct1.SelectedIndex == 0)
                {
                    index = 0;
                    Ct2.Items.Clear();
                    Ct2.Items.Add("20");
                    Ct2.Items.Add("30");
                    Ct2.Items.Add("40");
                    Ct2.Items.Add("50");
                    Ct2.Items.Add("60");
                    Ct2.Items.Add("70");
                }
                else if (Ct1.SelectedIndex == 1)
                {
                    index = 1;
                    Ct2.Items.Clear();
                    try
                    {
                        for (int i = 0; i <= country_test.Length - 1; i++)
                        {
                            if (country_test[i] != "null")
                                Ct2.Items.Add(country_test[i]);
                        }
                    }
                    catch (Exception a)
                    {
                        
                    }
                }
                else if (Ct1.SelectedIndex == 2)
                {
                    index = 2;
                    Ct2.Items.Clear();
                    Ct2.Items.Add("0-12");
                    Ct2.Items.Add("College");
                    Ct2.Items.Add("Associates");
                    Ct2.Items.Add("Bachelors");
                    Ct2.Items.Add("Masters");
                    Ct2.Items.Add("PhD");
                }
                else if (Ct1.SelectedIndex == 3)
                {
                    index = 3;
                    Ct2.Items.Clear();
                    try
                    {
                        for (int i = 0; i <= job_test.Length - 1; i++)
                        {
                            Ct2.Items.Add(job_test[i]);
                        }
                    }
                    catch (Exception a)
                    {
                        
                    }
                }
                else if (Ct1.SelectedIndex == 4)
                {
                    index = 4;
                    Ct2.Items.Clear();
                    Total.Text = GetTotalPeople();
                }
            }
            catch (Exception a)
            {
            }
        }
        string GetTotal(string i, string i2)
        {
            int total = 0;
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();
            
                XPathExpression exp;
                exp = nav.Compile("/database/person/"+i);
                XPathNodeIterator it;
                it = nav.Select(exp);            
                try
                {
                    while (it.MoveNext())
                    {
                        XPathNavigator nav2 = it.Current.Clone();
                        if (nav2.Name == "ed" && nav2.Value == i2)
                        {
                            total++;
                        }
                        else if ((nav2.Name == "ed" && nav2.Value != i2 && int.Parse(nav2.Value) >= 0 && int.Parse(nav2.Value) <= 12) ||
                            (nav2.Name == "ed" && nav2.Value != i2 && (nav2.Value.Contains("high school") || nav2.Value.Contains("High School"))))
                        {
                            total++;
                        }
                        else if (nav2.Name == "age" && nav2.Value == i2)
                        {
                            total++;
                        }
                        else if (nav2.Name == "age" && nav2.Value != i2 && int.Parse(nav2.Value) > int.Parse(i2) && int.Parse(nav2.Value) < (int.Parse(i2) + 10))
                        {
                            total++;
                        }
                        else if (nav2.Name == "country" && nav2.Value == i2)
                        {
                            total++;
                        }
                        else if (nav2.Name == "job" && nav2.Value == i2)
                        {
                            total++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! \n" + ex.Message);
                }          
            return total.ToString();
        }
        
        private void Ct2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index == 0)
            {
                Total.Text = GetTotal("age", Ct2.SelectedItem.ToString());
            }
            else if (index == 2)
            {
                Total.Text = GetTotal("ed", Ct2.SelectedItem.ToString());
            }
            else if (index == 1)
            {
                Total.Text = GetTotal("country", Ct2.SelectedItem.ToString());
            }
            else if (index == 3)
            {
                Total.Text = GetTotal("job", Ct2.SelectedItem.ToString());
            }
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(fileName);
            int count = int.Parse(GetTotalPeople());
            country_test = new string[count+100];
            int y = 0; 
            foreach (XmlNode node1 in doc1.SelectNodes("/database/person/country"))
            {
                try
                {
                    country_test[y] = node1.InnerXml.Trim();
                    y++;
                }
                catch (Exception ecx)
                {
                    MessageBox.Show(y.ToString());
                    break;
                }
            }
            XmlDocument doc2 = new XmlDocument();
            doc2.Load(fileName);
            job_test = new string[int.Parse(GetTotalPeople())+100];
            int j = 0;
            foreach (XmlNode node2 in doc2.SelectNodes("/database/person/job"))
            {
                job_test[j] = node2.InnerXml.Trim();
                j++;
            }
            country_test = country_test.Distinct().ToArray();
            job_test = job_test.Distinct().ToArray();
            try
            {
                for (int i = 0; i <= country_test.Length - 1; i++)
                {
                    if (country_test[i] != null && country_test[i] != "null")
                        countryfilter.Items.Add(country_test[i]);
                }
                for (int i = 0; i <= job_test.Length - 1; i++)
                {
                    if (job_test[i] != null && job_test[i] != "null")
                        occupationfilter.Items.Add(job_test[i]);
                }
            }
            catch (Exception a)
            {
                
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int totals = 0;
            string ageword = "";
            string yearword = "";
            if (agefilter.SelectedIndex == 0)
            {
                ageword = "";
                //ages 0-9 will have search term as null
            }
            else if (agefilter.SelectedIndex == 1)
            {
                ageword = "10";
            }
            else if (agefilter.SelectedIndex == 2)
            {
                ageword = "20";
            }
            else if (agefilter.SelectedIndex == 3)
            {
                ageword = "30";
            }
            else if (agefilter.SelectedIndex == 4)
            {
                ageword = "40";
            }
            else if (agefilter.SelectedIndex == 5)
            {
                ageword = "50";
            }
            else if (agefilter.SelectedIndex == 6)
            {
                ageword = "60";
            }
            else if (agefilter.SelectedIndex == 7)
            {
                ageword = "70";
            }
            else if (agefilter.SelectedIndex == 8)
            {
                ageword = "80";
            }
            string jobword = occupationfilter.SelectedItem.ToString();
            string edword = educationfilter.Text;
            string countryword = countryfilter.SelectedItem.ToString();
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();
            XPathExpression expage;
            expage = nav.Compile("/database/person/age");
            XPathNodeIterator itage;
            itage = nav.Select(expage);

            XPathExpression expcountry;
            expcountry = nav.Compile("/database/person/country");
            XPathNodeIterator itcountry;
            itcountry = nav.Select(expcountry);

            XPathExpression exped;
            exped = nav.Compile("/database/person/ed");
            XPathNodeIterator ited;
            ited = nav.Select(exped);

            XPathExpression expjob;
            expjob = nav.Compile("/database/person/job");
            XPathNodeIterator itjob;
            itjob = nav.Select(expjob);

            XPathExpression expyear;
            expyear = nav.Compile("/database/person/year");
            XPathNodeIterator ityear;
            ityear = nav.Select(expyear);
            try
            {
                while (ityear.MoveNext() && itage.MoveNext() && itcountry.MoveNext() && ited.MoveNext() && itjob.MoveNext())
                {
                    XPathNavigator searcherage = itage.Current.Clone();
                    XPathNavigator searchercountry = itcountry.Current.Clone();
                    XPathNavigator searchered = ited.Current.Clone();
                    XPathNavigator searcherjob = itjob.Current.Clone();
                    XPathNavigator searcheryear = ityear.Current.Clone();
                    string agetest = searcherage.Value;
                    string countrytest = searchercountry.Value;
                    string edtest = searchered.Value;
                    string jobtest = searcherjob.Value;
                    string yeartest = searcheryear.Value;
                    /*MessageBox.Show("agetest: " + agetest + " ageword: " + ageword + "\n" +
                                    "countrytest: " + countrytest + " countryword: " + countryword + "\n" +
                                    "edtest: " + edtest + " edword: " + edword + "\n" +
                                    "jobtest: " + jobtest + " jobword: " + jobword + "\n");*/
                    if (countryword == countrytest && edword == edtest && jobword == jobtest && int.Parse(ageword) <= int.Parse(agetest) && int.Parse(agetest) <= (int.Parse(ageword) + 9))
                    {
                        totals += 1;
                    }
                }
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            textBox1.Text = totals.ToString();
        }                 
    }
}
