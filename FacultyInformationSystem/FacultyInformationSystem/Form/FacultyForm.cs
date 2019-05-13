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

        University u = University.GetUniversity();//singleton design
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                u.addFaculty(new Faculty(textBox1.Text, textBox2.Text));//textBox'lardan fakültenin id va name'ini alarak University classından fakülte üretme
                listBox1.Items.Clear();
                foreach (Faculty faculties in University.GetFaculties) //Üniversitedeki fakülte list'ine eklenen değerleri listbox'a atma
                {
                    listBox1.Items.Add(faculties.ToString());
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
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
            DepartmentForm departmentForm = new DepartmentForm();//Bölüm ekleme formuna yönlendirme
            departmentForm.Show();
            this.Hide();
        }
    }
}
