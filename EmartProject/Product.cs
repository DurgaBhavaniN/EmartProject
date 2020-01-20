using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class Product
    {
        internal int sub_id;
        public int i_id { get; set; }
public double price { get; set; }
       public int stk_num { get; set; }
               public string i_name { get; set; }
        public int s_id { get; set; }

        public Product(int i_id, string i_name, double price, int stk_num,int s_id)
        {
            this.i_id = i_id;
            this.price = price;
            this.stk_num = stk_num;
            this.i_name = i_name;
            this.s_id = s_id;
        }
        
        //public void display()
        //{
        //    Console.WriteLine("Details are");
        //    Console.WriteLine("Category name: "+c_name+"lnSubCategory Name: " +sub_name+"\nItem name: " + i_name + "\n price: " + price);
        //}


        }
    }

