using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class Buyer_Bo
    {
        static List<Buyer> blist = new List<Buyer>();
        ProductBo pbo = new ProductBo();
        
        public void Signup(int b_id, string b_name, string b_pwd, string b_emailid, long b_phn)
        {


            blist.Add(new Buyer(b_id, b_name, b_pwd, b_emailid, b_phn));
           // Console.WriteLine("Sign up Successfully");

        }
        public bool Login(string b_name, string b_pwd)
        {
            Buyer bobj = blist.Find(e => e.b_name == b_name && e.b_pwd == b_pwd);
            if (bobj != null)
                return true;
            else return false;

        }
        public void Search()
        {
            pbo.search();
        }
        public void Display()
        {
            pbo.display();
        }
        public void Display_details()
        {
            foreach (Buyer b in blist)
            {
                Console.WriteLine("Buyer Name:" + b.b_name);
                Console.WriteLine("Buyer Id: " + b.b_id);
                Console.WriteLine("Email_is : " + b.b_email_id);
                Console.WriteLine("Phn is: " + b.b_phn);

            }
        }
       
    }
}