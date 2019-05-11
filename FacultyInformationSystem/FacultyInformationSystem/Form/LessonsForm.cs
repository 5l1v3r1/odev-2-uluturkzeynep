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
            foreach (Department department in Faculty.GetDepartments) 
            {
                comboBox1.Items.Add(department.getName.ToString());
            }
        }
        Department d = new Department();
        private void button2_Click(object sender, EventArgs e)
        {
            d.addCourse(new Course(textBox1.Text, textBox2.Text, new Department(d.getID, d.getName, d.GetFaculty)));
            foreach (Course course in Department.GetCourses)
            {
                listBox1.Items.Add(course.ToString());
            }
        }
    }
}
