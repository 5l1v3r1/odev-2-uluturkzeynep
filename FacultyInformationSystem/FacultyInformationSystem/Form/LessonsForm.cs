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
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            InitializeComponent();
        }

        private void LessonsForm_Load(object sender, EventArgs e)
        {

        }
        private void AddLes(Lessons item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.id + item.name;
            lvi.SubItems.Add(item.name);
            lvi.Tag = item;
            listView1.Items.Add(lvi);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<Lessons> lesList = new List<Lessons>()
                    {
                new Lessons {id = textBox1.Text, name = textBox2.Text}
                };

            for (int i = 0; i < lesList.Count; i++)
            {
                AddLes(lesList[i]);
            }
        }
    }
}
