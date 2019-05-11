using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        //private void AddD(Department item)
        //{
        //    ListViewItem lvi = new ListViewItem();
        //    lvi.Text = item.id + item.name;
        //    lvi.SubItems.Add(item.name);
        //    lvi.Tag = item;
        //    listView1.Items.Add(lvi);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Department> depList = new List<Department>()
            //        {
            //    new Department {id = textBox1.Text, name = textBox2.Text}
            //    };
            //Undergraduate ogrr = new Undergraduate()
            // {
            //     name = textBox1.Text,
            //     id = textBox2.Text
            // };
            //for (int i = 0; i < depList.Count; i++)
            //{
            //    AddD(depList[i]);
            //}
        }
    }
}
