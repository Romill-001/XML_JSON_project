﻿using System;
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
        public string process;
        public int num;
        public MainForm()
        {
            xDoc.Load(@"./../../XMLData.xml");
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
        private void LoadToDG(List<People> list)
        {
            foreach (People person in list)
            {
                MainList.Rows.Add(person.Name, person.Age, person.Status, person.Process);
            }
        }
        private void Process322xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "322";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Process322xml.Checked || Process228xml.Checked || Process123xml.Checked)
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

        private void Process228xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "228";
        }

        private void Process123xml_CheckedChanged(object sender, EventArgs e)
        {
            process = "123";
        }

        private void MainList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AboutPerson per = new AboutPerson();
            num = MainList.CurrentCell.RowIndex;
            per.name = $"Имя: {List[num].Name}.";
            per.place = $"Место проведения заседания: {List[num].Place}.";
            per.year = $"{List[num].Year} года рождения.";
            per.status = $"Статус: {List[num].Status}.";
            per.process = $"Дело №{List[num].Process}.";
            per.age = $"{List[num].Age} лет.";
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
