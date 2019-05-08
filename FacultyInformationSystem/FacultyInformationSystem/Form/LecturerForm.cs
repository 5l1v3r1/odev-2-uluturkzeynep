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
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }
        private void AddL(Lecturer item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.id + item.name;
            lvi.SubItems.Add(item.name);
            lvi.Tag = item;
            listView1.Items.Add(lvi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Lecturer> lecList = new List<Lecturer>()
                    {
                new Lecturer {id = textBox1.Text, name = textBox2.Text}
                };

            for (int i = 0; i < lecList.Count; i++)
            {
                AddL(lecList[i]);
            }
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
