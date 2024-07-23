using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NET101_Assignment_NguyenDinhVu_DG1
{
    public abstract class sinhviennhapxuat
    {



        string _mssv;
        string _hoten;
        float _diem;
        string _email;
        public sinhviennhapxuat()
        {

        }
        public sinhviennhapxuat(string hoten, float diem, string email, string mssv)
        {
            this.hoten = hoten;
            this.diem = diem;
            this.email = email;
            this.mssv = mssv;
        }
        public string mssv
        {
            get { return _mssv; }
            set { _mssv = value; }
        }

        public string hoten
        {
            get { return _hoten; }
            set
            {
                _hoten = value;
            }
        }
        public float diem
        {
            get { return _diem; }
            set { _diem = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        


        


        public abstract void chucnang1();
        public abstract void chucnang2();
        public abstract int chucnang3();
        public abstract void chucnang4();
        public abstract void chucnang5();
        public abstract void chucnang6();
        public abstract void chucnang7();
        public abstract void chucnang8();
        public abstract void chucnang9();
        public abstract void chucnang10();
       
        

    }
}
