using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XML_JSON_project
{
    public partial class MainForm : Form
    {
        XmlDocument xDoc = new XmlDocument();
        List<People> List = new List<People>();
        public MainForm()
        {
            xDoc.Load(@"./../../XMLData.xml");
            InitializeComponent();
            GetXMLfile();
            LoadToDG(List);
        }

        private void GetXMLfile()
        {
            XmlElement root = xDoc.DocumentElement;
            ParseJudges(root);
            ParseDefendants(root);
            ParseVictims(root);
        }
        private void ParseJudges(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "judges")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        Judges j = new Judges();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            if (child.Name == "fio")
                            {
                                j.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                            }
                            if (child.Name == "age")
                            {
                                j.Age = int.Parse(child.FirstChild.InnerText);
                            }
                            if (child.Name == "status")
                            {
                                j.Status = child.InnerText;
                            }
                            if (child.Name == "place")
                            {
                                j.Place = child.InnerText;
                            }
                            if (child.Name == "process")
                            {
                                j.Process = int.Parse(child.InnerText);
                            }
                            if (child.Name == "experience")
                            {
                                j.Experience = int.Parse(child.InnerText);
                            }
                        }
                        List.Add(j);
                    }
                }
            }
        }
        private void ParseDefendants(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "defendants")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        Defendants d = new Defendants();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            if (child.Name == "fio")
                            {
                                d.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                            }
                            if (child.Name == "age")
                            {
                                d.Age = int.Parse(child.FirstChild.InnerText);
                            }
                            if (child.Name == "status")
                            {
                                d.Status = child.InnerText;
                            }
                            if (child.Name == "place")
                            {
                                d.Place = child.InnerText;
                            }
                            if (child.Name == "process")
                            {
                                d.Process = int.Parse(child.InnerText);
                            }
                            if (child.Name == "article")
                            {
                                d.Article = int.Parse(child.InnerText);
                            }
                            if (child.Name == "lawyer")
                            {
                                d.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                            }
                        }
                        List.Add(d);
                    }
                }
            }
        }
        private void ParseVictims(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "victims")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        Victims v = new Victims();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            if (child.Name == "fio")
                            {
                                v.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                            }
                            if (child.Name == "age")
                            {
                                v.Age = int.Parse(child.FirstChild.InnerText);
                            }
                            if (child.Name == "status")
                            {
                                v.Status = child.InnerText;
                            }
                            if (child.Name == "place")
                            {
                                v.Place = child.InnerText;
                            }
                            if (child.Name == "process")
                            {
                                v.Process = int.Parse(child.InnerText);
                            }
                            if (child.Name == "damage")
                            {
                                v.Damage = child.InnerText;
                            }
                        }
                        List.Add(v);
                    }
                }
            }
        }
        private void LoadToDG(List<People> list)
        {
            foreach (People person in list)
            {
                MainList.Rows.Add(person.Name, person.Age, person.Status, person.Process);
            }
        }

        private void MainList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }

    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public int Process { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
    public class Judges : People
    {
        public int Experience { get; set; }
    }
    public class Defendants : People
    {
        public int Article { get; set; }
        public string Lawyer { get; set; }
    }
    public class Victims : People
    {
        public string Damage { get; set; }
    }
}
