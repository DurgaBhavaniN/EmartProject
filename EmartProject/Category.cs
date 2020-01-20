using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
   abstract class Category
    {
       public int c_id { get; set; }
        public string c_name { get; set; }
        List<Category> ic = new List<Category>();
        public Category(int c_id,string c_name)
        {
            this.c_id = c_id;
            this.c_name = c_name;
        }
       /* public void Add_Category()
        {
            Console.WriteLine("Enter how many categories wanted to add");
            int num = int.Parse(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("Enter Category id");
                int c_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category name");
                string c_name = Console.ReadLine();
                ic.Add(new Category(c_id, c_name));

            }
        */
    }
}
