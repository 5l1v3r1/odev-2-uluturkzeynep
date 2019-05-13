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

        University u = University.GetUniversity();
        private void button1_Click(object sender, EventArgs e)
        {
            u.addFaculty(new Faculty(textBox1.Text,textBox2.Text));
            listBox1.Items.Clear();
            foreach (Faculty faculties in University.GetFaculties)
            {
                listBox1.Items.Add(faculties.ToString());
            }
            
        }
        public void add()
        {

        }
        private void FacultyForm_Load(object sender, EventArgs e)
        {
           
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
            this.Hide();
        }
    }
}
