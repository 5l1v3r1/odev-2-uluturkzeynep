using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FacultyInformationSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void AddS(Graduate item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.id+ item.name;
            lvi.SubItems.Add(item.name);
            lvi.Tag = item;
            listView1.Items.Add(lvi);
        }
        private void AddSi(Undergraduate item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.id + item.name;
            lvi.SubItems.Add(item.name);
            lvi.Tag = item;
            listView2.Items.Add(lvi);
        }
        private void AddSii(PhD item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.id + item.name;
            lvi.SubItems.Add(item.name);
            lvi.Tag = item;
            listView3.Items.Add(lvi);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                //Dictionary<int, Graduate> Grad = new Dictionary<int, Graduate>();
                //Grad.Add(Convert.ToInt32(textBox2.Text), new Graduate(textBox1.Text, textBox2.Text));

                //listBox1.Items.Add(Grad.Values);

                List<Graduate> graList = new List<Graduate>()
                    {
                new Graduate {id = textBox2.Text, name = textBox1.Text}
                };
               //Graduate gra = new Graduate()
               // {
               //     name = textBox1.Text,
               //     id = textBox2.Text
               // };
               for(int i = 0; i < graList.Count; i++)
                {
                    AddS(graList[i]);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                List<Undergraduate> undList = new List<Undergraduate>()
                    {
                new Undergraduate {id = textBox2.Text, name = textBox1.Text}
                };
               //Undergraduate ogrr = new Undergraduate()
               // {
               //     name = textBox1.Text,
               //     id = textBox2.Text
               // };
               for(int i = 0; i < undList.Count; i++)
                {
                    AddSi(undList[i]);
                }
               

            }
            if (comboBox1.SelectedIndex == 2)
            {

                List<PhD> phdList = new List<PhD>()
                    {
                new PhD {id = textBox2.Text, name = textBox1.Text}
                };
                
                //PhD phd = new PhD()
                //{
                //    name = textBox1.Text,
                //    id = textBox2.Text
                //};
                for(int i=0;i<phdList.Count;i++)
                AddSii(phdList[i]);
            }

        }

        private void AddStudent_Load(object sender, EventArgs e)
        { 
         
        }
    }
}
