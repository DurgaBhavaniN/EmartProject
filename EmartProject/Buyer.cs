using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class Buyer
    {
        

        public int b_id { get; set; }
       
        public string b_name { get; set; }
         public string b_pwd { get; set; }
        public string b_email_id { get; set; }
        public long b_phn { get; set; }

        public Buyer(int b_id,string b_name,string b_pwd,string b_email_id,long b_phn)
        {
            this.b_id = b_id;
            this.b_name = b_name;
            this.b_pwd =b_pwd;
            this.b_email_id =b_email_id;
            this.b_phn =b_phn;
        }
        //public void search(int item)
        //{
        //    b.display();
        //}
        //public void display()
        //{
        //    Console.WriteLine("List of items are:"+items);
          
        //}
    }
}
