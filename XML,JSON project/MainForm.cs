using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace XML_JSON_project
{
    public partial class MainForm : Form
    {
        XmlDocument xDoc = new XmlDocument();
        List<People> List = new List<People>();
        public string data_json = File.ReadAllText(@"./../../JSONData.json");
        public string process;
        public int num;
        public MainForm()
        {
            xDoc.Load(@"./../../XMLData.xml");
            string data_json = File.ReadAllText(@"./../../JSONData.json");
            InitializeComponent();
            GetXMLfile();
            LoadToDG(List);
            MainList.Hide();
        }

        private void GetXMLfile()
        {
            XmlElement root = xDoc.DocumentElement;
            ParseJudges(root);
            ParseDefendants(root);
            ParseVictims(root);
            ParseJudgesjson();
            ParseDefendantsjson();
            ParseVictimsjson();
        }
        private void ParseJudges(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "judges")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        People j = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    j.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    j.Age = int.Parse(child.FirstChild.InnerText);
                                    j.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    j.Status = child.InnerText;
                                    break;
                                case "place":
                                    j.Place = child.InnerText;
                                    break;
                                case "process":
                                    j.Process = int.Parse(child.InnerText);
                                    break;
                                case "experience":
                                    j.Experience = int.Parse(child.InnerText);
                                    break;
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
                        People d = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    d.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    d.Age = int.Parse(child.FirstChild.InnerText);
                                    d.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    d.Status = child.InnerText;
                                    break;
                                case "place":
                                    d.Place = child.InnerText;
                                    break;
                                case "process":
                                    d.Process = int.Parse(child.InnerText);
                                    break;
                                case "article":
                                    d.Article = int.Parse(child.InnerText);
                                    break;
                                case "lawyer":
                                    d.Lawyer = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
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
                        People v = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    v.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    v.Age = int.Parse(child.FirstChild.InnerText);
                                    v.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    v.Status = child.InnerText;
                                    break;
                                case "place":
                                    v.Place = child.InnerText;
                                    break;
                                case "process":
                                    v.Process = int.Parse(child.InnerText);
                                    break;
                                case "damage":
                                    v.Damage = child.InnerText;
                                    break;
                            }
                        }
                        List.Add(v);
                    }
                }
            }
        }
        private void ParseJudgesjson()
        {
            JsonNode data = JsonNode.Parse(data_json);
            for (int i = 0; i < 3; i++)
            {
                People j = new People();
                JsonNode jud = data["judges"][i];
                j.Name = $"{(string)jud["fio"]["surname"]} {(string)jud["fio"]["name"]} {(string)jud["fio"]["fathername"]}";
                j.Age = int.Parse((string)jud["age"]["age"]);
                j.Place = (string)jud["place"];
                j.Process = int.Parse((string)jud["process"]);
                j.Experience = int.Parse((string)jud["experience"]);
                j.Year = int.Parse((string)jud["age"]["year"]);
                j.Status = (string)jud["status"];
                List.Add(j);
            }
        }
        private void ParseDefendantsjson()
        {
            JsonNode data = JsonNode.Parse(data_json);
            for (int i = 0; i < 3; i++)
            {
                People d = new People();
                JsonNode def = data["defendants"][i];
                d.Name = $"{(string)def["fio"]["surname"]} {(string)def["fio"]["name"]} {(string)def["fio"]["fathername"]}";
                d.Age = int.Parse((string)def["age"]["age"]);
                d.Place = (string)def["place"];
                d.Process = int.Parse((string)def["process"]);
                d.Year = int.Parse((string)def["age"]["year"]);
                d.Status = (string)def["status"];
                d.Article = int.Parse((string)def["article"]);
                d.Lawyer = (string)def["lawyer"];
                List.Add(d);
            }
        }
        private void ParseVictimsjson()
        {
            JsonNode data = JsonNode.Parse(data_json);
            for (int i = 0; i < 3; i++)
            {
                People v = new People();
                JsonNode vic = data["victims"][i];
                v.Name = $"{(string)vic["fio"]["surname"]} {(string)vic["fio"]["name"]} {(string)vic["fio"]["fathername"]}";
                v.Age = int.Parse((string)vic["age"]["age"]);
                v.Place = (string)vic["place"];
                v.Process = int.Parse((string)vic["process"]);
                v.Year = int.Parse((string)vic["age"]["year"]);
                v.Status = (string)vic["status"];
                v.Damage = (string)vic["damage"];
                List.Add(v);
            }
        }
        private void LoadToDG(List<People> list)
        {
            foreach (People person in list)
            {
                MainList.Rows.Add(person.Name, person.Age, person.Status, person.Process);
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Process322xml.Checked || Process228xml.Checked || Process123xml.Checked || Process18223json.Checked || Process1234json.Checked || Process345json.Checked)
            {
                for (int i = 0; i < MainList.Rows.Count; i++)
                {
                    MainList.Rows[i].Visible = MainList[3, i].Value.ToString() == process;
                }
                MainList.Show();
                MessageBox.Show($"Данные по делу {process} успешно загружены", "Система", MessageBoxButtons.OK) ;
            }
            else
            {
                MainList.Show();
                MessageBox.Show("Данные по всем делам успешно загружены", "Система", MessageBoxButtons.OK);
            }
        }
        private void Process322xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "322";
        }
        private void Process228xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "228";
        }

        private void Process123xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "123";
        }
        private void Process18223json_CheckedChanged(object sender, EventArgs e)
        {
            process = "18223";
        }
        private void Process1234json_CheckedChanged(object sender, EventArgs e)
        {
            process = "1234";
        }
        private void Process345json_CheckedChanged(object sender, EventArgs e)
        {
            process = "345";
        }
        private void MainList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AboutPerson per = new AboutPerson();
            num = MainList.CurrentCell.RowIndex;
            per.name = $"Имя: {List[num].Name}.";
            per.place = $"Место проведения заседания: {List[num].Place}.";
            per.year = $"Год рождения: {List[num].Year}.";
            per.status = $"Статус: {List[num].Status}.";
            per.process = $"Дело №{List[num].Process}.";
            per.age = $"Возраст: {List[num].Age}.";
            per.temp = Tempr(List, num);
            if (List[num].Lawyer != null)
            {
                per.lawyer = $"Адвокат: {List[num].Lawyer}";
            }
            per.Show();
        }
        private string Tempr(List<People> List, int num)
        {
            string ans = null;
            if (List[num].Experience != 0)
            {
                ans = $"Опыт работы: {List[num].Experience} лет";
            }
            else if (List[num].Article != 0)
            {
                ans = $"Статья: {List[num].Article}";
            }
            else if (List[num].Damage != null)
            {
                ans = $"Ущерб: {List[num].Damage}";
            }
            return ans;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public int Experience { get; set; }
        public int Article { get; set; }
        public string Lawyer { get; set; }
        public string Damage { get; set; }
    }
}
