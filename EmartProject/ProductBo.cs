using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class ProductBo
    {
        static List<Product> plist = new List<Product>();
        static List<SubCategory> slist = new List<SubCategory>();
        public void Add_Item(int c_id,string c_name,int sub_id,string sub_name,int i_id, string i_name,int gst,int price,int stk_num,int s_id)
        {

            SubCategory sub_obj = new SubCategory(c_id,c_name,sub_id,sub_name,gst);
            Product pdt_obj = new Product(i_id, i_name,price, stk_num, s_id) ;
            slist.Add(sub_obj);
            plist.Add(pdt_obj);
            Console.WriteLine("Item Added successfully");

          }
        public List<Product> display(int sid)
        {
            List<Product> iplist = plist.FindAll(e => e.s_id == sid);
            return iplist;
        }
        public void display()
        {
            
            foreach(Category c in slist)
            {
                Console.WriteLine(" Category_id\t Category_Name ");
                Console.WriteLine(+c.c_id + "\t" + c.c_name);
            }
            Console.WriteLine("Enter cid for visit subcategories");
            int ch = int.Parse(Console.ReadLine());
            foreach(SubCategory s in slist)
            {
                if(s.c_id==ch)
                { Console.WriteLine("SubCategory_Id \t Sub_category_Name \t Gst");  
                    Console.WriteLine(+s.sub_id + "\t" + s.sub_name + "\t" +s.gst);
                }
            }
            Console.WriteLine("Enter sub_id for visit items");
            int ch1 = int.Parse(Console.ReadLine());
            foreach (SubCategory s in slist)
            {
                foreach (Product p in plist)
                {
                    if (s.sub_id == ch1)
                    {
                        Console.WriteLine("Item_id \t Item_name \t Price");
                        Console.WriteLine(+p.i_id + " \t" + p.i_name + " \t" + p.price);
                    }
                }
            }
        }
        public void search()
        {
            Console.WriteLine("1.Search an item using item Id/2.Search an item using item name");
            Console.WriteLine("Enter ur choice");
            int ch = int.Parse(Console.ReadLine());
            int flag = 0;
            if(ch==1)
            {
                Console.WriteLine("Enter Item Id");
                int i = int.Parse(Console.ReadLine());
                foreach(Product pi in plist)
                {
                    if (pi.i_id == i)
                    {
                        Console.WriteLine("Item_Id \t Item_Name \t Item_Price");
                        Console.WriteLine(+pi.i_id + " " + pi.i_name + " " + pi.price);
                        flag = 1;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Item Name");
                string name = Console.ReadLine();
                foreach(Product ip in plist)
                {
                    if (ip.i_name == name)
                    {
                        Console.WriteLine("Item_Id \t Item_Name \t Item_Price");
                        Console.WriteLine(+ip.i_id + " " + ip.i_name + " " + ip.price);
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 0)
                Console.WriteLine("Item Not Found");
            
        }
        }
}
