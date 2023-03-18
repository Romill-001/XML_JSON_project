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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainList.Hide();
        }

        private void XMLfile_CheckedChanged(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ShowList()
        {
            if (XMLfile.Checked || JSONfile.Checked)
            {
                MainList.Show();
            }
        }
    }
}
