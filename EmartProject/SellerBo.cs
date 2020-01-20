using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    
    class SellerBo
    {
        static List<Seller> slist = new List<Seller>();
       // static List<Product> plist= new List<Product>();

        public void Signup(int s_id, string s_name, string s_pwd, string s_emailid, string postal_address,double gstin, string bank_details)
        {
            
            
            slist.Add(new Seller(s_id, s_name, s_pwd, s_emailid, postal_address, gstin, bank_details));
           // Console.WriteLine("Sign up Successfully");

        }
        public bool Login(string uname,string upwd)
        {
            Seller sobj = slist.Find(e => e.s_name == uname && e.s_pwd == upwd);
            if (sobj != null)
                return true;
            else return false;
            
           
        }
        public void Display()
        {
            foreach(Seller s in slist)
            {
                Console.WriteLine("Seller Id :" +s.s_id);
                Console.WriteLine("Seller Name:" + s.s_name);
                Console.WriteLine("Seller Email_id:" + s.s_emailid);
                Console.WriteLine("Postal Address:" + s.postal_address);
                Console.WriteLine("Gstin: " +s.gstin);
            }
        }
        public void Display_seller_items()
        {
            ProductBo ibo = new ProductBo();
            Console.WriteLine("Enter seller id");
            int ch = int.Parse(Console.ReadLine());
            List<Product> lp = ibo.display(ch); 
            foreach (Product p in lp)
            {
                Console.WriteLine("Item Id \t Item Name \t Price");
                Console.WriteLine(p.i_id + " \t" + p.i_name + " \t" + p.price);
            }

        }
    }
}
