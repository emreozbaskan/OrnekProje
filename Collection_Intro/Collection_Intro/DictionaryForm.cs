using System;
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
    public partial class DictionaryForm : Form
    {
        public DictionaryForm()
        {
            InitializeComponent();
        }
        //Keyvalue yapısında çalışan bir collectiondur.
        //using System.Collection.Generic
        //IDictionary<TKey,TValue> interface implemente etmiş
        //Key değeri Uniq olması gerekir.
        //her bir item tipi KeyValuePair<TKey,TValue> tipindedir.

        Dictionary<int, string> Ogrenciler = new Dictionary<int, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler.Add(1, "Yunus Emre");
            Ogrenciler.Add(2, "Erdi Şen");
            Ogrenciler.Add(3, "Taha Kayapınar");
            Ogrenciler.Add(4, "Selim Akay");
            //Ogrenciler.Add(1, "Emre Özbaşkan"); => Eklenen bir key değeri tekrardan eklenemez uniq olması gerekir.
            Ogrenciler.Add(5, null);
            Ogrenciler.Add(6, "");

            //indexer => yapısı ile key değerini verip value değerini alabilirsiniz.
            string value = Ogrenciler[4];
            string value1 = Ogrenciler[1];


            foreach (KeyValuePair<int, string> item in Ogrenciler)
            {
                //item.Value
                //item.Key
                //MessageBox.Show($"{item.Key} - {item.Value}");
            }
            
            
            //ContainsKey=> verilen key değeri var mı yok mu
            if (Ogrenciler.ContainsKey(1))
            { 
                
            }

            //ContainsValue => Value değeri içinde arama yapmak için kullanılır
            bool containsvalueResult = Ogrenciler.ContainsValue("Emre Özbaşkan");
            if (containsvalueResult)
            {
                MessageBox.Show("Aranan değer içeride var");
            }

            //Ogrenciler.Add(18, "Emre");
            //Ogrenciler.Append(new KeyValuePair<int, string>(19, "Yunus"));
        }
    }
}
