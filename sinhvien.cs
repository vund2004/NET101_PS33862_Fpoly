using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace NET101_Assignment_NguyenDinhVu_DG1
{
    internal class sinhvien : sinhviennhapxuat
    {
        ArrayList svlist= new ArrayList();
        
        public sinhvien() :base()
        { }
        public sinhvien(string hoten,float diem,string email,string mssv): base(hoten,diem,email,mssv)
        {
            
        }
        public void nhapsv()
        {
            
            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine();
           
            do
            {
                Console.Write("Nhập điểm: ");
                
                diem= float.Parse(Console.ReadLine());
            }
            while (diem <0 || diem > 10);
           
            Console.Write("Nhập email: ");
            email = Console.ReadLine();
            Console.Write("Nhập mssv: ");
            mssv = Console.ReadLine();
                
            
            Console.WriteLine("=====================");
        }
        public void xuatsv()
        {

        Console.WriteLine(hoten +"\t\t"+diem+"\t\t"+email+"\t\t"+hocluc(diem));
        }

       public string hocluc(float diem)
       {
       if (diem >= 9) return "suất sắc";
       else if (diem >= 7.5) return "giỏi";
       else if (diem >= 6.5) return "khá";
       else if (diem >= 5) return "Trung bình";
       else if (diem >= 3) return "Yếu";
       else return "kém";

       }
        public override void chucnang1()
        {
            sinhvien sv = new sinhvien();
            Console.WriteLine("_______Chương tình thứ 1: (Nhập sv)_______");
            Console.Write("Nhập số sinh viên: ");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++) 
            {
                
                sv.nhapsv();
                bool a = false;
                if (svlist.Count > 0)
                {

                    for (int j = 0; j < svlist.Count; j++)
                    {
                        sinhvien sv_temp = (sinhvien)svlist[j];
                        if (sv.mssv == sv_temp.mssv)
                        {
                            a = true;
                            break;
                        }

                    }
                    if (a == true)
                    {
                        Console.WriteLine("Mã số sinh viên bị trùng");
                    }
                    else
                    {

                        svlist.Add(sv);
                    }
                }
                else
                {
                    svlist.Add(sv);
                }
            }
          /*  bool b = false;
            
            if (svlist.Count > 0)
            {
                for(int i=0;i<svlist.Count;i++)
                {
                   
                    sinhvien tam = (sinhvien)svlist[i];
                    if(tam.hoten == sv.hoten)
                    {
                        b = true;
                        break;
                    }    
                }  
                if (b==true)
                {
                    Console.WriteLine("Họ tên bị tùng");
                } 
                else
                {
                    sv.nhapsv();
                }    
            }
            else
            {
                sv.nhapsv();
            }   */ 
            
        }

        public override void chucnang2()
        {
            Console.WriteLine("_______Chương tình thứ 2: (Xuất sv)_______");
            Console.WriteLine("Ho tên\t\tĐiểm\t\tEmail\t\tHọc lực");
            foreach (sinhvien sv in svlist)
            {

                sv.xuatsv();

            
            }

        }

        public override int chucnang3()
        {
            
            float sodau, socuoi;
            Console.WriteLine("_______Chương tình thứ 3: (Tìm kím sinh vien theo khoảng)_______");
            Console.WriteLine("Nhập khoảng đầu: ");
            sodau = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập khoảng cuối: ");
            socuoi = float.Parse(Console.ReadLine());
            Console.WriteLine("Ho tên\t\tĐiểm\t\tEmail\t\tHọc lực");
            for (int i = 0; i < svlist.Count; i++)
            {
                sinhvien sv = (sinhvien)svlist[i];
                if (sodau <= sv.diem && sv.diem <= socuoi)
                {
                    sv.xuatsv();
                }
                
            }
            
            return -1;
            
        }
        
        public override void chucnang4()
        {
            
           
            Console.WriteLine("_______Chương tình thứ 4: (Tìm kím theo học lực)_______");
            Console.WriteLine("______*<1>: Học lực xuất sắc*__________________________");
            Console.WriteLine("______*<2>: Học lực giỏi*______________________________");
            Console.WriteLine("______*<3>: Học lực khá*_______________________________");
            Console.WriteLine("______*<4>: Học lực trung bình*________________________");
            Console.WriteLine("______*<5>: Học lực yếu*_______________________________");
            Console.WriteLine("______*<6>: Học lực kém*_______________________________");
         
            int hoclucnhap;
            do
            {
                Console.WriteLine("Nhập học lực muốn tìm (1,2,3,4,5,6): ");
                hoclucnhap = int.Parse(Console.ReadLine());
            }
            while (hoclucnhap < 1 || hoclucnhap > 6);
            switch (hoclucnhap)
            {
                
                case 1:
                    {
                        Console.WriteLine("Học lực suất sắc");
                        for (int i=0;i<svlist.Count;i++)
                        {
                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem >= 9)
                            {
                                
                                sv.xuatsv();

                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Học lực giỏi");
                        for (int i=0;i<svlist.Count;i++)
                        {
                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem >= 7.5&&sv.diem<9)
                            {
                                
                                sv.xuatsv();

                            }  
                            
                           
                        }    
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Học lực khá");
                        for (int i = 0; i < svlist.Count; i++)
                        {
                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem >= 6.5&&sv.diem<7.5)
                            {
                                
                                sv.xuatsv();
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Học lực TB");
                        for (int i = 0; i < svlist.Count; i++)
                        {
                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem >= 5&&sv.diem<6.5)
                            {
                                
                                sv.xuatsv();
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Học lực yếu");
                        for (int i = 0; i < svlist.Count; i++)
                        {

                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem >= 3&&sv.diem<5)
                            {
                                
                                sv.xuatsv();
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Học lực kém");
                        for (int i = 0; i < svlist.Count; i++)
                        {
                            sinhvien sv = (sinhvien)svlist[i];
                            if (sv.diem<3)
                            {
                                
                                sv.xuatsv();
                            }
                        }
                        break;
                    }

            }
        }
        //cách 2 
       
        public override void chucnang5()
        {
            int dem = 0;
            Console.WriteLine("_______Chương tình thứ 5: (Tìm học viên theo mã số)_______");
            Console.WriteLine("Nhập mssv cần tìm: ");
            string mssv = Console.ReadLine();
            for (int i = 0; i < svlist.Count; i++)
            {
                
                sinhvien sv = (sinhvien)svlist[i];
                if (sv.mssv == mssv)
                {
                    Console.WriteLine("_________Nhập và thay thế________ ");

                    Console.Write("Nhập họ tên: ");
                    sv.hoten = Console.ReadLine();

                    do
                    {
                        Console.Write("Nhập điểm: ");
                        sv.diem = float.Parse(Console.ReadLine());
                    }
                    while (diem < 0 || diem > 10);

                    Console.Write("Nhập email: ");
                    sv.email = Console.ReadLine();


                }
                else
                {
                    dem = dem + 1;
                    if (dem == svlist.Count)
                    {
                        Console.WriteLine("Không tìm thấy mã số sinh viên");
                        Console.WriteLine("Bạn có muốn thêm không(yes|| no)");
                        string nhap = Console.ReadLine();
                        if(nhap=="yes")
                        {

                            Console.Write("Nhập họ tên: ");
                            hoten = Console.ReadLine();

                            do
                            {
                                Console.Write("Nhập điểm: ");

                                diem = float.Parse(Console.ReadLine());
                            }
                            while (diem < 0 || diem > 10);

                            Console.Write("Nhập email: ");
                            email = Console.ReadLine();

                            svlist.Add(new sinhvien(hoten,diem,email,mssv));
                            break;
                        }   
                        else
                        {
                            Console.WriteLine("không thêm");
                        }    
                        
                    }
                }
            }
        }
        public override void chucnang6()
        {
            Console.WriteLine("_______Chương tình thứ 6: (Sắp xếp học viên theo điểm)_______");

            for (int i=0;i<svlist.Count-1;i++)
            {
                for(int j=i+1;j<svlist.Count;j++)
                {
                    sinhvien a = (sinhvien)svlist[i];
                    sinhvien b = (sinhvien)svlist[j];
                    if(a.diem>b.diem)
                    {
                        sinhvien tam = (sinhvien)svlist[j];
                        svlist[j] = svlist[i];
                        svlist[i] = tam;
                    }       
                }    
            }
            
        }
        public override void chucnang7()
        {
            Console.WriteLine("_______Chương tình thứ 7: (Xuất 5 học viên có điểm cao nhât)_______");
            Console.WriteLine("Ho tên\t\tĐiểm\t\tEmail\t\tHọc lực");
            for (int i = 0; i < svlist.Count - 1; i++)
                {
                    for (int j = i + 1; j < svlist.Count; j++)
                    {
                        sinhvien a = (sinhvien)svlist[i];
                        sinhvien b = (sinhvien)svlist[j];
                        if (a.diem < b.diem)
                        {
                            sinhvien tam = (sinhvien)svlist[j];
                            svlist[j] = svlist[i];
                            svlist[i] = tam;
                        }
                    }
                }
                
                for(int i=0;i<5&&i<svlist.Count;i++)
                {
                    sinhvien sv = (sinhvien)svlist[i];
                    sv.xuatsv();
                }    
            
        }
        public override void chucnang8()
        {
            Console.WriteLine("_______Chương tình thứ 8: (Điểm trung bình của lớp)_______");
            float tongdiem = 0;
            float dtb = 0;
            for (int i = 0; i < svlist.Count; i++)
            {

                sinhvien sv = (sinhvien)svlist[i];
                tongdiem = tongdiem + sv.diem;
            }
            dtb = tongdiem / svlist.Count;
            Console.WriteLine("Điểm tb của lớp: {0}", dtb);
        }
        public override void chucnang9()
        {
            Console.WriteLine("_______Chương tình thứ 9: (Xuất danh sách có học viên trên TB)_______");
            Console.WriteLine("Ho tên\t\tĐiểm\t\tEmail\t\tHọc lực");
            for (int i=0;i<svlist.Count;i++)
            {
                sinhvien sv = (sinhvien)svlist[i];
                if(sv.diem>=5)
                {
                    sv.xuatsv();
                }    
            }    
        }
        public override void chucnang10()
        {
            Console.WriteLine("_______Chương tình thứ 10: (Tổng hợp học viên theo học lực)_______");
            int demss = 0;
            int gioi = 0;
            int kha = 0;
            int tb = 0;
            int yeu = 0;
            int kem = 0;
            for (int i=0;i<svlist.Count;i++)
            {
                sinhvien sv = (sinhvien)svlist[i];
                if (sv.diem >= 9)
                {
                    demss = demss + 1;
          
                } 
                    
                else if (sv.diem >= 7.5)
                {
                    
                    gioi = gioi + 1;

                }

                else if (sv.diem >= 6.5)
                {
                    
                    kha = kha + 1;
                }
                else if (sv.diem >= 5)
                {
                    
                    tb = tb + 1;
                }
                else if (sv.diem >= 3)
                {
                    yeu = yeu + 1;
                }
                else
                {
                    kem = kem + 1;
                }    
            }
            Console.WriteLine("Học lực suất sắc có <{0}> sinhvien", demss);
            Console.WriteLine("Học lực giỏi có <{0}> sinhvien",gioi);
            Console.WriteLine("Học lực khá có <{0}> sinhvien", kha);
            Console.WriteLine("Học lực trung bình có <{0}> sinhvien", tb);
            Console.WriteLine("Học lực yếu có <{0}> sinhvien", yeu);
            Console.WriteLine("Học lực kem có <{0}> sinhvien", kem);

        }
    }
}
