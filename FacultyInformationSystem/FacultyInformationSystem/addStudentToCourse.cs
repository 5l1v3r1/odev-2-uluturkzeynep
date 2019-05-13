using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    public partial class addStudentToCourse : Form
    {
        public addStudentToCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            listBox1.Items.Add(comboBox2.SelectedItem.ToString()+" Course "+comboBox3.SelectedItem.ToString());
        }

        private void addStudentToCourse_Load(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            try
            {
                
                comboBox1.Items.Clear();
                //Form yüklendiği zaman combobox1'e öğrencinin ekleneceği bölümü seçenek olarak sunma 
                foreach (Course course in Department.GetCourses) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
                {
                    comboBox1.Items.Add(course.GetDepartment.getName.ToString());
                    if (comboBox3.SelectedItem != null)
                    {
                        this.Text = comboBox3.SelectedItem.ToString() + " Students";
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;

            try
            {
                comboBox2.Items.Clear();
                foreach (Student student in Department.GetStudents) //Seçilen Bölüme göre combobox2'de ilgili bölümün derslerini seçenek olarak sunma
                {
                    if (comboBox1.SelectedItem.ToString().Contains(student.GetDepartment.getName))//combobox1'de seçilen bölümü içeren öğrencilerin bilgisini combobox2'ye seçenek olarak sunma
                    {
                        comboBox2.Items.Add(student.ToString());
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//combobox1 yani bölüm seçildiğinde ilgili derslerin gelmesi için 
            comboBox3.Visible = true;
            try
            {
                comboBox3.Items.Clear();
                foreach (Course course in Department.GetCourses) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
                {
                    if (comboBox1.SelectedItem.ToString().Contains(course.GetDepartment.getName))
                        comboBox3.Items.Add(course.getName);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Dosya yazdırma işlemlerini listbox'taki elemanları ele alarak yaptım. Direkt Student'ın bilgilerini alarak yapmayı denedim ama 
            // aldığı ders bilgisini almada sorun yaşadığım için yapamadım.
            FileStream fileStream = new FileStream(@"./AboutStudents.txt", FileMode.OpenOrCreate);
            StreamWriter sW = new StreamWriter(fileStream);
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                sW.WriteLine();
            }
            
            sW.Close();
            fileStream.Close();
        }
    }
}
