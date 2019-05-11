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
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void uniButton_Click(object sender, EventArgs e)
        {
            UniversityForm f1 = new UniversityForm();
            f1.Show();
            this.Hide();
        }

        private void facultyButton_Click(object sender, EventArgs e)
        {
            FacultyForm f2 = new FacultyForm();
            f2.Show();
            this.Hide();
        }

        private void lecturerButton_Click(object sender, EventArgs e)
        {
            LecturerForm f3 = new LecturerForm();
            f3.Show();
            this.Hide();
        }

        private void lessonsButton_Click(object sender, EventArgs e)
        {
            LessonsForm f4 = new LessonsForm();
            f4.Show();
            this.Hide();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            Students f5 = new Students();
            f5.Show();
            this.Hide();
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            DepartmentForm f6 = new DepartmentForm();
            f6.Show();
            this.Hide();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
