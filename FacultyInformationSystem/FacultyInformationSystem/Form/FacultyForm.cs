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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }
        //private void AddF(Faculty item)
        //{
        //    ListViewItem lvi = new ListViewItem();
        //    lvi.Text = item.id + item.name;
        //    lvi.SubItems.Add(item.name);
        //    lvi.Tag = item;
        //    listView1.Items.Add(lvi);
        //}
        University u = new University();
        private void button1_Click(object sender, EventArgs e)
        {
            //List<Faculty> facList = new List<Faculty>()
            //        {
            //    new Faculty {id = textBox1.Text, name = textBox2.Text}
            //    };

            //for (int i = 0; i < facList.Count; i++)
            //{
            //    AddF(facList[i]);
            //}

            
            u.addFaculty(new Faculty(Convert.ToInt16(textBox1.Text), textBox2.Text));

            for (int i=0;i<u.faculties.Count;i++)
            {
                listBox1.Items.Add(u.faculties[i]);
            }
            Console.WriteLine(u.faculties[0]);

        }
    }
}
