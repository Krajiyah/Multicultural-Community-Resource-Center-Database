using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Printing;
using System.IO;
using System.Xml.XPath;

namespace Horran_Appartments_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void Populate()
        {
            int TotalGED = 0;
            int TotalESL = 0;
            int TotalEMP = 0;
            total_ged.Text = "Total GED: ";
            total_esl.Text = "Total ESL: ";
            total_emp.Text = "Total EMP: ";
            XmlDocument doc = new XmlDocument();
            doc.Load("database.xml");
            foreach (XmlNode person in doc.DocumentElement.SelectNodes("person"))
            {
                if (listBox1.Items.Contains(person.Attributes[0].Value) == false)
                    listBox1.Items.Add(person.Attributes[0].Value);
                if (person.ChildNodes.Item(0).InnerXml == "True")
                    TotalGED += 1;
                if (person.ChildNodes.Item(1).InnerXml == "True")
                    TotalESL += 1;
                if (person.ChildNodes.Item(2).InnerXml == "True")
                    TotalEMP += 1;
            }
            total_ged.Text += TotalGED.ToString();
            total_esl.Text += TotalESL.ToString();
            total_emp.Text += TotalEMP.ToString();
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            Horran person = new Horran();
            if (enrollment.GetItemChecked(0))            
                person.GED = true;            
            if (enrollment.GetItemChecked(1))            
                person.ESL = true;            
            if (enrollment.GetItemChecked(2))            
                person.EMP = true;
            if (levelged.GetItemChecked(0))
                person.LvGED = 1;
            else if (levelged.GetItemChecked(1))
                person.LvGED = 2;
            else if (levelged.GetItemChecked(2))
                person.LvGED = 3;
            else if (levelged.GetItemChecked(3))
                person.LvGED = 4;
            else if (levelged.GetItemChecked(4))
                person.LvGED = 5;
            if (levelesl.GetItemChecked(0))
                person.LvESL = 1;
            else if (levelesl.GetItemChecked(1))
                person.LvESL = 2;
            else if (levelesl.GetItemChecked(2))
                person.LvESL = 3;
            else if (levelesl.GetItemChecked(3))
                person.LvESL = 4;
            else if (levelesl.GetItemChecked(4))
                person.LvESL = 5;
            if (levelemp.GetItemChecked(0))
                person.LvEMP = 1;
            else if (levelemp.GetItemChecked(1))
                person.LvEMP = 2;
            else if (levelemp.GetItemChecked(2))
                person.LvEMP = 3;
            else if (levelemp.GetItemChecked(3))
                person.LvEMP = 4;
            else if (levelemp.GetItemChecked(4))
                person.LvEMP = 5;
            if (qualifications.GetItemChecked(0))
                person.license = true;
            if (qualifications.GetItemChecked(1))
                person.employed = true;
            if (qualifications.GetItemChecked(2))
                person.highschool = true;
            if (qualifications.GetItemChecked(3))
                person.somecollege = true;
            if (qualifications.GetItemChecked(4))
                person.college = true;
            person.name = name.Text;
            person.address = address.Text;
            person.phone = phone.Text;
            person.skills = skills.Text;
            person.notes = notes.Text;
            person.City = city.Text;
            person.Zip = zip.Text;
            person.State = state.Text;
            person.AppendContent();
            Populate();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Horran person = new Horran();
            if (enrollment.GetItemChecked(0))
                person.GED = true;
            if (enrollment.GetItemChecked(1))
                person.ESL = true;
            if (enrollment.GetItemChecked(2))
                person.EMP = true;
            if (levelged.GetItemChecked(0))
                person.LvGED = 1;
            else if (levelged.GetItemChecked(1))
                person.LvGED = 2;
            else if (levelged.GetItemChecked(2))
                person.LvGED = 3;
            else if (levelged.GetItemChecked(3))
                person.LvGED = 4;
            else if (levelged.GetItemChecked(4))
                person.LvGED = 5;
            if (levelesl.GetItemChecked(0))
                person.LvESL = 1;
            else if (levelesl.GetItemChecked(1))
                person.LvESL = 2;
            else if (levelesl.GetItemChecked(2))
                person.LvESL = 3;
            else if (levelesl.GetItemChecked(3))
                person.LvESL = 4;
            else if (levelesl.GetItemChecked(4))
                person.LvESL = 5;
            if (levelemp.GetItemChecked(0))
                person.LvEMP = 1;
            else if (levelemp.GetItemChecked(1))
                person.LvEMP = 2;
            else if (levelemp.GetItemChecked(2))
                person.LvEMP = 3;
            else if (levelemp.GetItemChecked(3))
                person.LvEMP = 4;
            else if (levelemp.GetItemChecked(4))
                person.LvEMP = 5;
            if (qualifications.GetItemChecked(0))
                person.license = true;
            if (qualifications.GetItemChecked(1))
                person.employed = true;
            if (qualifications.GetItemChecked(2))
                person.highschool = true;
            if (qualifications.GetItemChecked(3))
                person.somecollege = true;
            if (qualifications.GetItemChecked(4))
                person.college = true;
            person.name = name.Text;
            person.address = address.Text;
            person.phone = phone.Text;
            person.skills = skills.Text;
            person.notes = notes.Text;
            person.City = city.Text;
            person.Zip = zip.Text;
            person.State = state.Text;
            person.UpdateContent();
            Populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            name.Text = "";
            address.Text = "";
            phone.Text = "";
            skills.Text = "";
            notes.Text = "";
            city.Text = "";
            zip.Text = "";
            state.Text = "";
            for (int i = 0; i <= enrollment.Items.Count - 1; i++)
                enrollment.SetItemChecked(i, false);
            for (int i = 0; i <= qualifications.Items.Count - 1; i++)
                qualifications.SetItemChecked(i, false);
            for (int i = 0; i <= levelged.Items.Count - 1; i++)
                levelged.SetItemChecked(i, false);
            for (int i = 0; i <= levelesl.Items.Count - 1; i++)
                levelesl.SetItemChecked(i, false);
            for (int i = 0; i <= levelemp.Items.Count - 1; i++)
                levelemp.SetItemChecked(i, false);
            Horran person = new Horran();
            try
            {                
                person.name = listBox1.SelectedItem.ToString();
                person.Remove();
                listBox1.Items.Remove(person.name);               
            }
            catch (Exception a)
            {
               
            }
            Populate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
        }
        
        bool stringtobool(string param)
        {
            if (param == "True")
                return true;
            else if (param == "False")
                return false;
            else
                return false;
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("database.xml");
            XmlNode person = doc.DocumentElement.SelectSingleNode("/database/person[@name='"+listBox1.SelectedItem.ToString()+"']");
            name.Text = person.Attributes[0].Value;
            address.Text = person.ChildNodes.Item(11).InnerXml;
            city.Text = person.ChildNodes.Item(15).InnerXml;
            zip.Text = person.ChildNodes.Item(16).InnerXml;
            phone.Text = person.ChildNodes.Item(12).InnerXml;
            skills.Text = person.ChildNodes.Item(13).InnerXml;
            notes.Text = person.ChildNodes.Item(14).InnerXml;
            state.Text = person.ChildNodes.Item(17).InnerXml;
            enrollment.SetItemChecked(0,stringtobool(person.ChildNodes.Item(0).InnerXml));
            enrollment.SetItemChecked(1,stringtobool(person.ChildNodes.Item(1).InnerXml));
            enrollment.SetItemChecked(2,stringtobool(person.ChildNodes.Item(2).InnerXml));
            qualifications.SetItemChecked(0, stringtobool(person.ChildNodes.Item(6).InnerXml));
            qualifications.SetItemChecked(1, stringtobool(person.ChildNodes.Item(7).InnerXml));
            qualifications.SetItemChecked(2, stringtobool(person.ChildNodes.Item(8).InnerXml));
            qualifications.SetItemChecked(3, stringtobool(person.ChildNodes.Item(9).InnerXml));
            qualifications.SetItemChecked(4, stringtobool(person.ChildNodes.Item(10).InnerXml));
            if(person.ChildNodes.Item(3).InnerXml.Contains('1'))
                levelged.SetItemChecked(0, true);
            else if(person.ChildNodes.Item(3).InnerXml.Contains('2'))
                levelged.SetItemChecked(1, true);
            else if(person.ChildNodes.Item(3).InnerXml.Contains('3'))
                levelged.SetItemChecked(2, true);
            else if(person.ChildNodes.Item(3).InnerXml.Contains('4'))
                levelged.SetItemChecked(3, true);
            else if(person.ChildNodes.Item(3).InnerXml.Contains('5'))
                levelged.SetItemChecked(4, true);
            if(person.ChildNodes.Item(4).InnerXml.Contains('1'))
                levelesl.SetItemChecked(0, true);
            else if(person.ChildNodes.Item(4).InnerXml.Contains('2'))
                levelesl.SetItemChecked(1, true);
            else if(person.ChildNodes.Item(4).InnerXml.Contains('3'))
                levelesl.SetItemChecked(2, true);
            else if(person.ChildNodes.Item(4).InnerXml.Contains('4'))
                levelesl.SetItemChecked(3, true);
            else if(person.ChildNodes.Item(4).InnerXml.Contains('5'))
                levelesl.SetItemChecked(4, true);
            if(person.ChildNodes.Item(5).InnerXml.Contains('1'))
                levelemp.SetItemChecked(0, true);
            else if(person.ChildNodes.Item(5).InnerXml.Contains('2'))
                levelemp.SetItemChecked(1, true);
            else if(person.ChildNodes.Item(5).InnerXml.Contains('3'))
                levelemp.SetItemChecked(2, true);
            else if(person.ChildNodes.Item(5).InnerXml.Contains('4'))
                levelemp.SetItemChecked(3, true);
            else if(person.ChildNodes.Item(5).InnerXml.Contains('5'))
                levelemp.SetItemChecked(4, true);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temp.txt", false);
                sw.WriteLine(notes.Text);
                sw.Close();
                Form form2 = new Form2();
                form2.ShowDialog();
                StreamReader sr = new StreamReader("temp.txt");
                notes.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception s)
            {
                
            }
        }
        void Labels()
        {
            if (File.Exists("labels.txt"))
            {
                File.Delete("labels.txt");
            }
            StreamWriter sw = new StreamWriter("lables.txt", true);
            if (listBox1.Items.Count != 1)
            {
                for (int i = 0; i < listBox1.Items.Count - 1; i++)
                {
                    string name = listBox1.Items[i].ToString();
                    sw.WriteLine(name);
                    XmlDocument doc = new XmlDocument();
                    doc.Load("database.xml");
                    XmlNode person = doc.DocumentElement.SelectSingleNode("/database/person[@name='" + name + "']");
                    sw.WriteLine(person.ChildNodes.Item(11).InnerXml);
                    sw.WriteLine(person.ChildNodes.Item(15).InnerXml + "," + person.ChildNodes.Item(17).InnerXml + "  " + person.ChildNodes.Item(16).InnerXml); sw.WriteLine(); // state
                    sw.Close();
                }
            }
            else
            {
                string name = listBox1.Items[0].ToString();
                sw.WriteLine(name);
                XmlDocument doc = new XmlDocument();
                doc.Load("database.xml");
                XmlNode person = doc.DocumentElement.SelectSingleNode("/database/person[@name='" + name + "']");
                sw.WriteLine(person.ChildNodes.Item(11).InnerXml);
                sw.WriteLine(person.ChildNodes.Item(15).InnerXml + "," + person.ChildNodes.Item(17).InnerXml + "  " + person.ChildNodes.Item(16).InnerXml); sw.WriteLine(); // state
                sw.Close();
            }
        }        
    
        private void print_Click(object sender, EventArgs e)
        {
            Labels();
            new PrintingExample("lables.txt");
        }
    }
}