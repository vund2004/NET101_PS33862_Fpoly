using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET101_Assignment_NguyenDinhVu_DG1
{
    internal class Program
    {
        
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1.Nhap danh sach hoc vien");
            Console.WriteLine("2.Xuat danh sach hoc vien");
            Console.WriteLine("3.Tim kiem hoc vien theo khoang diem nhap tu ban phim");
            Console.WriteLine("4.Tim kiem hoc vien theo hoc luc nhap tu ban phim");
            Console.WriteLine("5.Tim hoc vien theo ma so va cap nhat thong tin hoc vien");
            Console.WriteLine("6.Sap xep hoc vien theo diem");
            Console.WriteLine("7.Xuat 5 hoc vien co diem cao nhat");
            Console.WriteLine("8.Tinh diem trung binh cua lop");
            Console.WriteLine("9.Xuat danh sach hoc vien co diem tren diem trung binh cua lop");
            Console.WriteLine("10.Tong hop so hoc vien theo hoc luc");
            Console.WriteLine("11.Thoat chuong trinh");
            int n;
            
            do
            {
                Console.WriteLine("Moi ban chon [1-11]: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 11);

            return n;

        }
        static void Main(string[] args)
        {
            
            sinhvien sv = new sinhvien();
            while (true)
            {
                int n = menu();
                if (n < 1 || n > 11)
                    continue;
                switch (n)
                {
                    case 1:
                        sv.chucnang1();
                      
                        break;
                    case 2:
                        sv.chucnang2();
                       
                        break;
                    case 3:
                        sv.chucnang3();
                      /*  int vitri=sv.chucnang3();
                        {
                            if(vitri==-1)
                            {
                                Console.WriteLine("không tìm thấy trong khoảng");
                            }    
                        }*/
                        break;
                    case 4:
                        sv.chucnang4();
                        break;
                    case 5:
                        sv.chucnang5();
                        break;
                    case 6:
                        sv.chucnang6();
                        sv.chucnang2();
                        break;
                    case 7:
                        sv.chucnang7();
                        break;
                    case 8:
                        sv.chucnang8();
                        break;
                    case 9:
                        sv.chucnang9();
                        break;
                    case 10:
                        sv.chucnang10();
                        break;
                    case 11:
                        Console.WriteLine("end");
                        Environment.Exit(exitCode: 0);
                        break;

                }
                Console.ReadKey();
            }
           
        }
            
        

    }
}
