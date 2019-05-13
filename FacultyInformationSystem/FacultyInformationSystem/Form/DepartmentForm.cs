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
            try
            {
                f.addDepartment(new Department(textBox1.Text, textBox2.Text, new Faculty(comboBox1.SelectedItem.ToString())));
                listBox1.Items.Clear();
                foreach (Department departments in Faculty.GetDepartments)//Fakültedeki bölüm list'ine eklenen değerleri listbox'a ekleme
                {
                    listBox1.Items.Add(departments.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }

        
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Faculty faculties in University.GetFaculties) //Üniversitedeki fakülte list'ine eklenen değerlerden olan fakülte ismini combobox'a seçenek olarak sunma
                {
                    comboBox1.Items.Add(faculties.getName.ToString());
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show(); this.Hide(); 
        }
    }
}
