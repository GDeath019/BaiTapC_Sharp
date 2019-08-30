using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienAV
{
    class Program
    {
       static Dictionary<String, String> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while(true)
            {
                menu();

                Console.WriteLine("Bạn có tiếp tục sử dụng từ điển không?(c/k)");
                string s = Console.ReadLine();
                if (s == "k")
                    break;
            }
            Console.WriteLine("BYE BYE!");
            Console.ReadKey();
        }
        private static void menu()
        {
            Console.WriteLine("1. Tạo từ mới.");
            Console.WriteLine("2. Sửa từ mới.");
            Console.WriteLine("3. Tra cứu từ.");
            Console.WriteLine("4. Xóa từ.");
            Console.WriteLine("5. Xem từ điển.");
            Console.WriteLine("Bạn chọn chức năng nào?");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTuMoi();
                        break;
                    case 3:
                        TraCuuTu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    case 5:
                        Display();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai.");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private static void Display()
        {
            if(dic.Count == 0)
            {
                Console.WriteLine("Từ điển trống!!!");
            }
            else
            {
                Console.WriteLine("Từ Điển!!!");
                foreach (KeyValuePair<String, String> item in dic)
                {
                    Console.WriteLine(item.Key + "   " + item.Value);
                }
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhạp vào từ tiếng Anh: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ {0} đã tồn tại rồi", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào Tiếng Việt: ");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
                Console.WriteLine("ADD DONE!");
            }
        }
        private static void SuaTuMoi()
        {
            Console.WriteLine("Nhập vào Tiếng Anh cần sửa lại nghĩa: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta)==false)
            {
                Console.WriteLine("Từ Tiếng Anh bạn nhập không có trong từ điển!!!");
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng Việt:");
                string tv = Console.ReadLine();
                dic[ta] = tv;
                Console.WriteLine("EDIT DONE!");
            }
        }
        private static void TraCuuTu()
        {
            Console.WriteLine("Mời bạn nhập từ tiếng anh cần tìm: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta)==false)
            {
                Console.WriteLine("Từ Tiếng Anh bạn nhập không có trong từ điển!!!");
            }
            else
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa tiếng Việt của từ bạn vừa nhập là: " + tv);
            }
        }
        private static void XoaTu()
        {
            Console.WriteLine("Moi nhap tu tieng anh: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Tu ban vua nhap khong co trong tu dien");
            }
            else
            {
                dic.Remove(ta);
                Console.WriteLine("REMOVE DONE");
            }
        }
    }
}