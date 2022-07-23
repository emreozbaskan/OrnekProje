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
    public partial class Form1 : Form
    { //global Sceope 
        public Form1()
        {
            InitializeComponent();
        }

        //Globale sehirler adında bir collection tanımlaması yapıldı.
        ArrayList sehirler = new ArrayList();

        //Arraylist Collection => aynı tipteki verileri bir arada tutmak için kullanılır.
        //IList interface => 


        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Bursa");
            sehirler.Add("Antalya");
            sehirler.Add("Ordu");
            sehirler.Add("Rize");

            ListRefresh();
        }


        private void btnArraylist_Click(object sender, EventArgs e)
        {
            //local

            //using System.Collection
            //Dinamik bir şekilde boyutlandırma yapılıyor.
            //Object tipinde item eklenebilir.
            //Add => metodu ile collection item eklenebilir.
            //object tipinde item istediği için boxing unboxing işlemi yapılması gerekir.
            //ArrayList sehirler = new ArrayList();
            //sehirler.Add("Ankara");
            //sehirler.Add("İstanbul");
            //sehirler.Add("İzmir");
            //sehirler.Add(123);
            //sehirler.Add(1234.45);
            //sehirler.Add(new Button());

            string eklenecekDeger = txtEklenecekItem.Text;
            sehirler.Add(eklenecekDeger);
            ListRefresh();
        }

        private void ListRefresh()
        {
            listBox1.Items.Clear();
            foreach (var item in sehirler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //listbox seçili bir değer yok ise aşağıdakş kodlar çalışmasın
            if (listBox1.SelectedIndex < 0) return;

            var dialogResult = MessageBox.Show("Seçilen item silmek istiyormusun?", "Array list", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                //Silme işlemini yap
                object selectedItem = listBox1.SelectedItem;
                //collection eleman silmek için remove method kullanılır.
                sehirler.Remove(selectedItem);
                
                ListRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Collection içerisideki bütün item silmek için kullanılır.
            sehirler.Clear();
            ListRefresh();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //collection baş aşağı yani tam terse çevirilir.
            sehirler.Reverse();
            ListRefresh();

            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert => collection içerisinde araya item eklemek için kullanılır.
            string eklenecekItem = txtEklenecekItem.Text;
            sehirler.Insert(0, eklenecekItem);

            ListRefresh();
        }

        private void btnRemoveRange_Click(object sender, EventArgs e)
        {
            //RemoveRange=> Collection içerisinde belli bir indexden başlayarak eleman silmek için kullanılır
            sehirler.RemoveRange(0, 5);

            ListRefresh();
        }
    }
}
