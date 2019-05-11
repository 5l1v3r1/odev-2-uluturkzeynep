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
            f.addDepartment(new Department(textBox1.Text,textBox2.Text,new Faculty(comboBox1.SelectedItem.ToString())));
            foreach (Department departments in Faculty.GetDepartments)
            {
                listBox1.Items.Add(departments.ToString());
            }
            AddStudent add = new AddStudent();
            add.Show();
        }

        
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            foreach (Faculty faculties in University.GetFaculties)
            {
                comboBox1.Items.Add(faculties.getName.ToString());
            }


        }
    }
}
