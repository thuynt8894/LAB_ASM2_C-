using System;
using System.Collections.Generic;

namespace ConsoleApplication1.ASM2
{
    public class Product
    {
        public int ID;
        public string Name;
        public float Price;
        public int Qty;
        public string Image;
        public string Desc;
        public List<string> Gallery;
        

        public Product()
        {
            this.GetInfo();
            this.Noti();
            this.AddImg();
            this.DeleImg();
        }

        public Product(int x)
        {
            
        }

        public void GetInfo()
        {
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("Tên:" + Name);
            Console.WriteLine("Giá:" + Price);
            Console.WriteLine("Số lượng:" + Qty);
            Console.WriteLine("Hình ảnh:" + Image);
            Console.WriteLine("Giới thiệu:"+ Desc);
            Console.WriteLine("Bộ sưu tập:" + Gallery);
        }

        public void Noti()
        {
            if (Qty>0)
            {
                Console.WriteLine("In stock");
                return;
            }
            Console.WriteLine("Out of stock");
        }

        public void AddImg()
        {
            if (Gallery.Count <10)
            {
                Console.WriteLine("Nhap chuoi:");
                            string y = Console.ReadLine();
                            Gallery.Add(y);
                            return;
            }
            Console.WriteLine("Bộ sưu tập đã đầy, vui lòng xóa ảnh trước khi thêm.");
        }

        public void DeleImg()
        {
            int i = 0;
            foreach (string x in Gallery)
            {
                Console.WriteLine(i+"."+x);
                i++;
            }
            Console.WriteLine("Nhap anh can xoa");
            int a = Convert.ToInt32(Console.ReadLine());
            Gallery.RemoveAt(a);
        }
    }
    
}