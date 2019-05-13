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
    public partial class addLecturerToCourse : Form
    {
        public addLecturerToCourse()
        {
            InitializeComponent();
        }

        private void addLecturerToCourse_Load(object sender, EventArgs e)
        {//Form yüklendiği zaman combobox1'e hocanın ekleneceği bölümü seçenek olarak sunma 
            comboBox3.Visible = false;
            try
            {
                comboBox1.Items.Clear();
                foreach (Course course in Department.GetCourses) //ilgili dersin bölümünü comboBox'ta seçenek olarak seçilebilmesi için
                {
                    comboBox1.Items.Add(course.GetDepartment.getName.ToString());
                    if (comboBox3.SelectedItem != null)
                    {
                        this.Text = comboBox3.SelectedItem.ToString() + " Lecturers";
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
            {//Seçilen Bölüme göre combobox2'de ilgili bölümün derslerini seçenek olarak sunma
                comboBox2.Items.Clear();
                foreach (Lecturer lecturer in Department.GetLecturers)
                {
                    if (comboBox1.SelectedItem.ToString().Contains(lecturer.GetDepartment.getName)) //combobox1'de seçilen bölümü içeren öğretmenlerin bilgisini combobox2'ye seçenek olarak sunma
                    {
                        comboBox2.Items.Add(lecturer.ToString());
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//listbox'a comboboxlar'a eklenen ders ve öğretmenden seçilenleri ekleme
            {
                listBox1.Items.Add(comboBox2.SelectedItem.ToString() + " Course: "+comboBox3.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("You didnt select a lecturer or Course.");
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
        {//Dosya yazdırma işlemlerini listbox'taki elemanları ele alarak yaptım. Direkt Lecturer'ın bilgilerini alarak yapmayı denedim ama 
            // verdiği ders bilgisini almada sorun yaşadığım için yapamadım.
            FileStream fileStream = new FileStream(@"./AboutLecturer.txt", FileMode.OpenOrCreate);
            StreamWriter sW = new StreamWriter(fileStream);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sW.WriteLine(listBox1.Items[i].ToString());
            }
            sW.Close();
            fileStream.Close();
        }
    }
}
