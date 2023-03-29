using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_JSON_project
{
    public partial class AboutPerson : Form
    {
        public string name 
        {
            get { return fullName.Text; }
            set { fullName.Text = value; }
        }
        public string age 
        { 
            get { return Age.Text; }
            set { Age.Text = value; }
        }
        public string process {
            get { return Process.Text; }
            set { Process.Text = value; }
        }
        public string place {
            get { return Place.Text; }
            set { Place.Text = value; }
        }
        public string temp {
            get { return Temp.Text; }
            set { Temp.Text = value; }
        }
        public string year {
            get { return YearOfBirth.Text; }
            set { YearOfBirth.Text = value; }
        }
        public string status {
            get { return Status.Text; }
            set { Status.Text = value; }
        }
        public string lawyer
        {
            get { return Lawyer.Text; }
            set { Lawyer.Text = value; Lawyer.Visible = true; }
        }

        public AboutPerson()
        {
            InitializeComponent();
        }
    }
}
