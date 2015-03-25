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
            try
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
            catch (Exception ex)
            {
            }
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            try
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
                person.Cell = cell.Text;
                person.State = state.Text;
                person.Gender = gender.Text;
                person.date_entered = DateTime.Now.ToString();
                person.AppendContent();
                Populate();
            }
            catch (Exception ex)
            {
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
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
                person.Cell = cell.Text;
                person.address = address.Text;
                person.phone = phone.Text;
                person.skills = skills.Text;
                person.notes = notes.Text;
                person.City = city.Text;
                person.Zip = zip.Text;
                person.State = state.Text;
                person.Gender = gender.Text;
                person.UpdateContent();
                Populate();
            }
            catch (Exception ex)
            {
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                name.Text = "";
                gender.Text = "";
                address.Text = "";
                phone.Text = "";
                skills.Text = "";
                notes.Text = "";
                city.Text = "";
                zip.Text = "";
                cell.Text = "";
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
            catch (Exception ex)
            {
            }
        }

        public int labelCount;
        public int currIndex;
        public float[] coordsX;
        public float[] coordsY;
        public float convert(float centi)
        {
            return (centi / 2.54f)*96f; //centimeters to pixels
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelCount = 0;
            labels = new List<Label>();
            currIndex = -1;            
            coordsX = new float[30];
            coordsY = new float[30];
            coordsX[0] = convert(.75f);
            coordsX[1] = convert(.75f);
            coordsX[2] = convert(.75f);
            coordsX[3] = convert(.75f);
            coordsX[4] = convert(.75f);
            coordsX[5] = convert(.75f);
            coordsX[6] = convert(.75f);
            coordsX[7] = convert(.75f);
            coordsX[8] = convert(.75f);
            coordsX[9] = convert(.75f);
            coordsX[10] = convert(8f);
            coordsX[11] = convert(8f);
            coordsX[12] = convert(8f);
            coordsX[13] = convert(8f);
            coordsX[14] = convert(8f);
            coordsX[15] = convert(8f);
            coordsX[16] = convert(8f);
            coordsX[17] = convert(8f);
            coordsX[18] = convert(8f);
            coordsX[19] = convert(8f);
            coordsX[20] = convert(15.35f);
            coordsX[21] = convert(15.35f);
            coordsX[22] = convert(15.35f);
            coordsX[23] = convert(15.35f);
            coordsX[24] = convert(15.35f);
            coordsX[25] = convert(15.35f);
            coordsX[26] = convert(15.35f);
            coordsX[27] = convert(15.35f);
            coordsX[28] = convert(15.35f);
            coordsX[29] = convert(15.35f);
            coordsY[0] = convert(1.5f);
            coordsY[1] = convert(4.2f);
            coordsY[2] = convert(6.7f);
            coordsY[3] = convert(9.3f);
            coordsY[4] = convert(12.105f);
            coordsY[5] = convert(14.55f);
            coordsY[6] = convert(17.1f);
            coordsY[7] = convert(20.105f);
            coordsY[8] = convert(22.42f);
            coordsY[9] = convert(25.25f);
            coordsY[10] = convert(1.5f);
            coordsY[11] = convert(4.2f);
            coordsY[12] = convert(6.7f);
            coordsY[13] = convert(9.3f);
            coordsY[14] = convert(12.105f);
            coordsY[15] = convert(14.55f);
            coordsY[16] = convert(17.1f);
            coordsY[17] = convert(20.105f);
            coordsY[18] = convert(22.42f);
            coordsY[19] = convert(25.25f);
            coordsY[20] = convert(1.5f);
            coordsY[21] = convert(4.2f);
            coordsY[22] = convert(6.7f);
            coordsY[23] = convert(9.3f);
            coordsY[24] = convert(12.105f);
            coordsY[25] = convert(14.55f);
            coordsY[26] = convert(17.1f);
            coordsY[27] = convert(20.105f);
            coordsY[28] = convert(22.42f);
            coordsY[29] = convert(25.25f);
            try
            {
                Populate();
            }
            catch (Exception ex)
            {
            }            
            XmlDocument doc = new XmlDocument();
            doc.Load("database.xml");            
            foreach (XmlNode person in doc.DocumentElement.SelectNodes("person"))
            {
                string message = "";
                DateTime dt;
                try
                {
                    dt = DateTime.Parse(person.ChildNodes.Item(20).InnerXml);
                }
                catch (Exception a)
                {
                    dt = DateTime.Now;
                    XmlElement elem22 = doc.CreateElement("Date_Entered");
                    elem22.InnerXml = dt.ToString();
                    person.AppendChild(elem22);
                    doc.Save("database.xml");
                }
                if (daysElapsed(dt) >= 30 && daysElapsed(dt) < 31)
                {
                    message = person.Attributes[0].Value + " needs to be updated!!! Its been 30 days since entered.\n";
                    if(person.ChildNodes.Item(14).InnerXml == "")
                        MessageBox.Show(message);
                }
                else if (daysElapsed(dt) >= 60 && daysElapsed(dt) < 61)
                {
                    message = person.Attributes[0].Value + " needs to be updated!!! Its been 60 days since entered.\n";
                    if (person.ChildNodes.Item(14).InnerXml == "")
                        MessageBox.Show(message);
                }
                else if (daysElapsed(dt) >= 90 && daysElapsed(dt) < 91)
                {
                    message = person.Attributes[0].Value + " needs to be updated!!! Its been 90 days since entered.\n";
                    if (person.ChildNodes.Item(14).InnerXml == "")
                        MessageBox.Show(message);
                }                
            }
        }
        double daysElapsed(DateTime dateEntered)
        {
            return DateTime.Now.Subtract(dateEntered).TotalDays;
        }
        bool stringtobool(string param)
        {
            try
            {
                if (param == "True")
                    return true;
                else if (param == "False")
                    return false;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("database.xml");
                XmlNode person = doc.DocumentElement.SelectSingleNode("/database/person[@name='" + listBox1.SelectedItem.ToString() + "']");
                name.Text = person.Attributes[0].Value;
                if (person.ChildNodes.Count == 19)
                {
                    cell.Text = person.ChildNodes.Item(18).InnerXml;
                }
                try
                {
                    gender.Text = person.ChildNodes.Item(19).InnerXml;
                }
                catch (Exception ex)
                {
                    gender.Text = "";
                }
                address.Text = person.ChildNodes.Item(11).InnerXml;
                city.Text = person.ChildNodes.Item(15).InnerXml;
                zip.Text = person.ChildNodes.Item(16).InnerXml;
                phone.Text = person.ChildNodes.Item(12).InnerXml;
                skills.Text = person.ChildNodes.Item(13).InnerXml;
                notes.Text = person.ChildNodes.Item(14).InnerXml;
                state.Text = person.ChildNodes.Item(17).InnerXml;
                enrollment.SetItemChecked(0, stringtobool(person.ChildNodes.Item(0).InnerXml));
                enrollment.SetItemChecked(1, stringtobool(person.ChildNodes.Item(1).InnerXml));
                enrollment.SetItemChecked(2, stringtobool(person.ChildNodes.Item(2).InnerXml));
                qualifications.SetItemChecked(0, stringtobool(person.ChildNodes.Item(6).InnerXml));
                qualifications.SetItemChecked(1, stringtobool(person.ChildNodes.Item(7).InnerXml));
                qualifications.SetItemChecked(2, stringtobool(person.ChildNodes.Item(8).InnerXml));
                qualifications.SetItemChecked(3, stringtobool(person.ChildNodes.Item(9).InnerXml));
                qualifications.SetItemChecked(4, stringtobool(person.ChildNodes.Item(10).InnerXml));
                if (person.ChildNodes.Item(3).InnerXml.Contains('1'))
                    levelged.SetItemChecked(0, true);
                else if (person.ChildNodes.Item(3).InnerXml.Contains('2'))
                    levelged.SetItemChecked(1, true);
                else if (person.ChildNodes.Item(3).InnerXml.Contains('3'))
                    levelged.SetItemChecked(2, true);
                else if (person.ChildNodes.Item(3).InnerXml.Contains('4'))
                    levelged.SetItemChecked(3, true);
                else if (person.ChildNodes.Item(3).InnerXml.Contains('5'))
                    levelged.SetItemChecked(4, true);
                if (person.ChildNodes.Item(4).InnerXml.Contains('1'))
                    levelesl.SetItemChecked(0, true);
                else if (person.ChildNodes.Item(4).InnerXml.Contains('2'))
                    levelesl.SetItemChecked(1, true);
                else if (person.ChildNodes.Item(4).InnerXml.Contains('3'))
                    levelesl.SetItemChecked(2, true);
                else if (person.ChildNodes.Item(4).InnerXml.Contains('4'))
                    levelesl.SetItemChecked(3, true);
                else if (person.ChildNodes.Item(4).InnerXml.Contains('5'))
                    levelesl.SetItemChecked(4, true);
                if (person.ChildNodes.Item(5).InnerXml.Contains('1'))
                    levelemp.SetItemChecked(0, true);
                else if (person.ChildNodes.Item(5).InnerXml.Contains('2'))
                    levelemp.SetItemChecked(1, true);
                else if (person.ChildNodes.Item(5).InnerXml.Contains('3'))
                    levelemp.SetItemChecked(2, true);
                else if (person.ChildNodes.Item(5).InnerXml.Contains('4'))
                    levelemp.SetItemChecked(3, true);
                else if (person.ChildNodes.Item(5).InnerXml.Contains('5'))
                    levelemp.SetItemChecked(4, true);
            }
            catch (Exception ex)
            {
            }
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

        //ACTAULLY for labelmaker.click
        private void print_Click(object sender, EventArgs e)
        {
            if (labelCount < 30)
            {
                StreamWriter sw = new StreamWriter("labels.txt", true);
                sw.WriteLine("               ");
                sw.WriteLine(name.Text);
                sw.WriteLine(address.Text);
                sw.WriteLine(city.Text + ", " + state.Text + " " + zip.Text);
                sw.Close();
                MessageBox.Show("Added to mailing list!");
                labelCount += 1;
                Label l = new Label(coordsX[currIndex+1], coordsY[currIndex+1], name.Text, address.Text, city.Text + ", " + state.Text + " " + zip.Text);
                labels.Add(l);
                currIndex += 1;
            }
            else
            {
                MessageBox.Show("You already have a full label sheet of 30 labels.");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            gender.Text = "";
            name.Text = "";
            address.Text = "";
            phone.Text = "";
            skills.Text = "";
            city.Text = "";
            state.Text = "";
            zip.Text = "";
            notes.Text = "";
            cell.Text = "";
            foreach (int i in qualifications.CheckedIndices)
            {
                qualifications.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in enrollment.CheckedIndices)
            {
                enrollment.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in levelged.CheckedIndices)
            {
                levelged.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in levelesl.CheckedIndices)
            {
                levelesl.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in levelemp.CheckedIndices)
            {
                levelemp.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void dellabel_Click(object sender, EventArgs e)
        {
            try
            {
                string ln1 = "";
                string ln2 = "";
                string ln3 = "";
                List<string> lns = new List<string>();
                if (File.Exists("labels.txt"))
                {
                    string[] lines = File.ReadAllLines("labels.txt");                   
                    lns.AddRange(lines);
                    int i = 0;
                    foreach (string str in lns)
                    {
                        if (str == name.Text)
                        {
                            if (i - 1 > 0)
                            {
                                lns.RemoveAt(i - 1);
                                ln1 = lns[i-1];
                                lns.RemoveAt(i - 1);
                                ln2 = lns[i-1];
                                lns.RemoveAt(i - 1);
                                ln3 = lns[i-1];
                                lns.RemoveAt(i - 1);
                            }
                            else
                            {
                                ln1 = lns[i-1];
                                lns.RemoveAt(i);
                                ln2 = lns[i-1];
                                lns.RemoveAt(i);
                                ln3 = lns[i-1];
                                lns.RemoveAt(i);
                            }
                            break;
                        }
                        i++;
                    }
                }
                File.WriteAllLines("labels.txt", lns.ToArray());
                MessageBox.Show("Removed from mailing list!");
                labelCount -= 1;
                Label l = new Label(coordsX[currIndex], coordsY[currIndex], ln1, ln2, ln3);
                labels.Remove(l);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
              
        private void printLabels_Click(object sender, EventArgs e)
        {                       
            PrintDialog pdi = new PrintDialog();
            pdi.Document = printDocument1;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                MessageBox.Show("Printing Job Sent to printer!");
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }           
        }
        List<Label> labels; 
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new System.Drawing.Font("Arial", 10); 
            float height = printFont.GetHeight(e.Graphics);
            if (File.Exists("labels.txt"))
            {
                foreach (Label l in labels)
                {                    
                    l.drawSelf(e, height);
                }                
            }
            else
            {
                MessageBox.Show("No Labels to Print!");
            }
        }

        private void delAll_Click(object sender, EventArgs e)
        {
            if (File.Exists("labels.txt"))
            {
                File.Delete("labels.txt");
            }
            MessageBox.Show("All mailing labels removed from list!");
            labelCount = 0;
            labels = new List<Label>();
        }

        private void viewLabels_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("labels.txt");
                StreamWriter sw = new StreamWriter("temp.txt", false);
                foreach (string str in lines)
                {
                    sw.WriteLine(str + "\n");
                }                
                sw.Close();
                Form form2 = new Form2();
                form2.ShowDialog();
            }
            catch (FileNotFoundException a)
            {
                StreamWriter sw = new StreamWriter("temp.txt", false);
                sw.WriteLine("No labels made!");
                sw.Close();
                Form form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("labels.txt"))
            {
                File.Delete("labels.txt");
                MessageBox.Show("Label List Cleared!!!");
            }
        }
    }
}