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

        Department d = new Department();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0) //Combobo1'deki öğrencinin seçtiği öğrenim durumuna göre lisans,yüksek lisans,
                                                 //doktora öğrencisi oluşturma ve listbox'a atma
                {
                    d.addStudent(new Graduate(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                    listBox1.Items.Clear();
                    foreach (Student student in Department.GetStudents)
                    {
                        listBox1.Items.Add(student.ToString());
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    d.addStudent(new Undergraduate(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                    listBox1.Items.Clear();
                    foreach (Student student in Department.GetStudents)
                    {
                        listBox1.Items.Add(student.ToString());
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    d.addStudent(new PhD(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                    listBox1.Items.Clear();
                    foreach (Student student in Department.GetStudents)
                    {
                        listBox1.Items.Add(student.ToString());
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
           
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            foreach (Department department in Faculty.GetDepartments) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
            {
                comboBox2.Items.Add(department.getName.ToString()); //Form yüklendiği zaman combobox2'e öğrencinin ekleneceği bölümü seçenek olarak sunma
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show(); this.Hide();
        }
    }
}
