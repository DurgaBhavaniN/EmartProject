using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class SubCategory : Category
    {
       public int sub_id { get; set; }
        public string sub_name { get; set; }
        public int gst { get; set; }
        public SubCategory(int c_id,string c_name,int sub_id,string sub_name,int gst):base(c_id,c_name)
        {
            this.sub_id = sub_id;
            this.sub_name = sub_name;
            this.gst = gst;
            this.c_id = c_id;
            this.c_name = c_name;
        }

    }
}
