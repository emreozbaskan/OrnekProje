using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Intro.Model
{
    public class Student
    {
        //Kaydın programatik olarak sistem tarafından verilen Id numarasıdır.
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //TcKimlikno
        private string _TcNo; //field
        public string TcNo //property
        {
            get { return _TcNo; }
            set { _TcNo = value; }
        }

        //AdıSoyadı
        private string _NameSurname;
        public string NameSurname
        {
            get { return _NameSurname; }
            set { _NameSurname = value; }
        }

        //Telefon
        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        //Email
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        //Sınıf Bilgisi
        private string _ClassNumber;
        public string ClassNumber
        {
            get { return _ClassNumber; }
            set { _ClassNumber = value; }
        }

        //Cinsiyet Bilgisi
        //true erkek false bayan
        private bool _Gender;
        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        //doğum Tarih
        private DateTime _BirthDate;
        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        //doğum Tarih
        private string _Address; //field
        public string Address //property
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.NameSurname}";
        }


    }
}
