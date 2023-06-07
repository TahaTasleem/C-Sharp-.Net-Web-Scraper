using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k190206_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Category_Label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Category_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = Category_Combo.Text;
            DataSet ds = new DataSet();
            ds.ReadXml($"C:\\Users\\mtaha\\source\\repos\\k190206_Q2\\bin\\Debug\\{s}\\{s}.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string rootPath = ConfigurationManager.AppSettings["path"];
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            foreach (string dir in dirs)
            {
                Category_Combo.Items.Add(dir.Substring(dir.LastIndexOf("\\") + 1));
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            string s = Category_Combo.Text; 
            DataSet set2 = new DataSet();
            set2.ReadXml($"C:\\Users\\mtaha\\source\\repos\\k190206_Q2\\bin\\Debug\\{s}\\{s}.xml");
            dataGridView1.DataSource = set2.Tables[0];
        }
    }
}
