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
            foreach (Course course in Department.getCourses)
            {
                comboBox1.Items.Add(course.ToString());
            }
        }
        Department d = new Department();
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
