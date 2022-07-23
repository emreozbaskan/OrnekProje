
using Collection_Intro.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection_Intro
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        int id = 0;
        //değişken tanımlaması 
        Student selectedStudent;
        //Öğrenci listesi burada tutulacak
        ArrayList studentList = new ArrayList();
        //Sınıf Listesi
        ArrayList classList = new ArrayList() {
        "1. Sınıf",
        "2. Sınıf",
        "3. Sınıf",
        "4. Sınıf",
        "5. Sınıf",
        "6. Sınıf",
        "7. Sınıf",
        };

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FormFill();
        }

        private void FormFill()
        {
            FillClass();
        }

        private void FillClass()
        {
            cmbClass.Items.Clear();
            foreach (string item in classList)
            {
                cmbClass.Items.Add(item);
            }
            //ilk değer seçili olsun
            cmbClass.SelectedIndex = 0;
        }

        /// <summary>
        /// Ekrandaki Bütün kontrolleri temizlemek için kullanılacak
        /// </summary>
        private void FormClear()
        {
            txtIdNumber.Text = "";
            txtNameSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            dtBirthDate.Value = DateTime.Now;
            cmbClass.SelectedIndex = 0;
            //Ekranı boşaltırken eğer seçili bir nesne var ise onuda null set et
            selectedStudent = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormSave()
        {
            Student student = null;

            if (selectedStudent != null)
            {
                //seçilen nesne kullanıldı
                student = selectedStudent;
            } else
            {
                //yeni bir instance aldık
                student = new Student();
                student.Id = GetId(); //yeni bir kayıt sistemem giriliyor ise Id bilgisi verilecek
                //Öğrenciyi listeye ekle
                studentList.Add(student);
            }
         
            student.NameSurname = txtNameSurname.Text;
            student.Phone = txtPhone.Text;
            student.TcNo = txtIdNumber.Text;
            student.Email = txtEmail.Text;
            student.Address = txtAddress.Text;
            student.BirthDate = dtBirthDate.Value;
            student.ClassNumber = cmbClass.SelectedItem.ToString();
            if (rbMan.Checked)
            {
                //erkek seçilmiştir.
                student.Gender = true;
            }
            else
            {
                //bayan seçilmiştir.
                student.Gender = false;
            }

            //Yeni eklnene değerleri listbox güncelle
            RefreshListBox();
            //Ekranı Temizle 
            FormClear();
        }

        private void RefreshListBox()
        {
            lstOgrenciler.Items.Clear();
            foreach (Student student in studentList)
            {
                lstOgrenciler.Items.Add(student);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private int GetId()
        {
            return ++id;
        }

        private void lstOgrenciler_DoubleClick(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedIndex == -1) return;
            //ben listbox içerisindeki item Student nesnesini attım 
            //boxing unboxing olayını yapıyorum ve seçilen item bir öğrencidir. diyorum.
            selectedStudent = lstOgrenciler.SelectedItem as Student;
            //Seçilen Student Bilgilerini ekrana tekrardan bassın
            FillRecordForm();
        }

        private void FillRecordForm()
        {
            txtIdNumber.Text = selectedStudent.TcNo;
            txtNameSurname.Text = selectedStudent.NameSurname;
            txtPhone.Text = selectedStudent.Phone;
            txtEmail.Text = selectedStudent.Email;
            txtAddress.Text = selectedStudent.Address;
            dtBirthDate.Value = selectedStudent.BirthDate;
            if (selectedStudent.Gender == true)
            {
                rbMan.Checked = true;
            }
            else
            {
                rbWoman.Checked = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RecordRemove();
        }

        private void RecordRemove()
        {
            if (selectedStudent != null)
            {
                var dialogResult = MessageBox.Show("SEçilen kaydı silmek istiyormusunuz?", "Öğrenci Otomasyon", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    studentList.Remove(selectedStudent);
                    RefreshListBox();
                    FormClear();
                }
            }
        }
    }
}
