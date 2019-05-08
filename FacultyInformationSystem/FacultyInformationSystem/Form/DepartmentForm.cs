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
       
        Faculty f = new Faculty();
        private void button1_Click(object sender, EventArgs e)
        {
          
            f.addDepartment(new Department(textBox1.Text, textBox2.Text));

            foreach (Department departments in f.departments)
            {

                listBox1.Items.Add(departments.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           f.deleteDepartment(new Department(textBox3.Text));
            foreach (Department departments in f.departments)
            {
                listBox1.Items.Remove(departments.ToString());
            }
        }
    }
}
