using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace Horran_Appartments_Database
{
    class Horran
    {
        public string Cell = "";
        public string date_entered = "";
        public string Gender = "";
        public string address = "";
        public string City = "";
        public string Zip = "";
        public string State = "";
        public string name = "";
        public string phone = "";
        public string skills = "";
        public string notes = "";
        public bool GED = false;
        public bool ESL = false;
        public bool EMP = false;
        public int LvGED = 0;
        public int LvESL = 0;
        public int LvEMP = 0;
        public bool license = false;
        public bool employed = false;
        public bool highschool = false;
        public bool somecollege = false;
        public bool college = false;
        public void AppendContent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("database.xml");
            XmlElement elem = doc.CreateElement("person");
            XmlAttribute text = doc.CreateAttribute("name");
            text.Value = name;
            elem.SetAttributeNode(text);
            elem.InnerXml = " ";
            doc.DocumentElement.AppendChild(elem);
            XmlElement elem2 = doc.CreateElement("GED");
            elem2.InnerXml = GED.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem2);
            XmlElement elem3 = doc.CreateElement("ESL");
            elem3.InnerXml = ESL.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem3);
            XmlElement elem4 = doc.CreateElement("EMP");
            elem4.InnerXml = EMP.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem4);
            XmlElement elem5 = doc.CreateElement("LvGED");
            elem5.InnerXml = LvGED.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem5);
            XmlElement elem6 = doc.CreateElement("LvESL");
            elem6.InnerXml = LvESL.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem6);
            XmlElement elem7 = doc.CreateElement("LvEMP");
            elem7.InnerXml = LvEMP.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem7);
            XmlElement elem8 = doc.CreateElement("license");
            elem8.InnerXml = license.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem8);
            XmlElement elem9 = doc.CreateElement("employed");
            elem9.InnerXml = employed.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem9);
            XmlElement elem10 = doc.CreateElement("highschool");
            elem10.InnerXml = highschool.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem10);
            XmlElement elem11 = doc.CreateElement("somecollege");
            elem11.InnerXml = somecollege.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem11);
            XmlElement elem12 = doc.CreateElement("college");
            elem12.InnerXml = college.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem12);
            XmlElement elem13 = doc.CreateElement("address");
            elem13.InnerXml = address.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem13);
            XmlElement elem14 = doc.CreateElement("phone");
            elem14.InnerXml = phone.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem14);
            XmlElement elem15 = doc.CreateElement("skills");
            elem15.InnerXml = skills.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem15);
            XmlElement elem16 = doc.CreateElement("notes");
            elem16.InnerXml = notes.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem16);
            XmlElement elem17 = doc.CreateElement("City");
            elem17.InnerXml = City.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem17);
            XmlElement elem18 = doc.CreateElement("Zip");
            elem18.InnerXml = Zip.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem18);
            XmlElement elem19 = doc.CreateElement("State");
            elem19.InnerXml = State.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem19);
            XmlElement elem20 = doc.CreateElement("Cell");
            elem20.InnerXml = Cell.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem20);
            XmlElement elem21 = doc.CreateElement("Gender");
            elem21.InnerXml = Gender.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem21);
            XmlElement elem22 = doc.CreateElement("Date_Entered");
            elem22.InnerXml = date_entered.ToString();
            doc.DocumentElement.LastChild.AppendChild(elem22);
            doc.Save("database.xml");
        }
        public void UpdateContent()
        {
            Remove();
            AppendContent();
        }
        public void Remove()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("database.xml");
            XmlNode person = doc.SelectSingleNode("/database/person[@name='" + name + "']");
            person.RemoveAll();
            doc.DocumentElement.RemoveChild(person);
            doc.Save("database.xml");
        }
    }
}