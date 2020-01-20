using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            x:
            Console.WriteLine("Are u 1.Admin/ 2.Seller/ 3.Buyer \n");
            int c = int.Parse(Console.ReadLine());
           
            for (; ; )
            {
                switch (c)
                {
                    case 1:
                        break;
                    case 2:Console.WriteLine("1.For new user - SIGNUP/ 2.Already have an account thn LOGIN");
                          int ch = int.Parse(Console.ReadLine());
                          SellerBo sb = new SellerBo();
                        if (ch == 1)
                        {
                            Console.WriteLine("Enter details for signup");
                            Console.WriteLine("name,id,pwd,email_id,address,gstin,bank_details\n");
                            string s_name = Console.ReadLine();
                            int s_id = int.Parse(Console.ReadLine());
                            string pwd = Console.ReadLine();
                            string s_emailid = Console.ReadLine();
                            string postal_address = Console.ReadLine();
                            double gstin = double.Parse(Console.ReadLine());
                            string bank_details = Console.ReadLine();
                            sb.Signup(s_id, s_name, pwd, s_emailid, postal_address, gstin, bank_details);
                            Console.WriteLine("Sign Up Successfully\n");

                        }
                        else
                        {
                            Console.WriteLine("Enter ur user name and pwd to Login");
                            string uname = Console.ReadLine();
                            string upwd = Console.ReadLine();
                            bool x = sb.Login(uname, upwd);
                            if (x != true)
                                Console.WriteLine("Invalid credientials\n");
                            else
                            {
                                Console.WriteLine("login successfull\n");
                              
                                for (; ; )
                                {
                                    Console.WriteLine("1. Display seller details\n 2.Add item\n 3.Display Seller Items\n 4.Display list of remaining items\n 5.Exit");
                                    int ch2 = int.Parse(Console.ReadLine());
                                    ProductBo pb = new ProductBo();
                                    SellerBo sbo = new SellerBo();
                                    switch (ch2)
                                    {
                                        case 1:Console.WriteLine("Seller details are\n");
                                              sbo.Display();
                                              break;
                                        case 2:
                                             Console.WriteLine("Enter how many items u wanted to add");
                                             int num = int.Parse(Console.ReadLine());
                                             for (int i = 0; i < num; i++)
                                             {
                                                Console.WriteLine("enter category id:");
                                                int c_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter category name:");
                                                string c_name = Console.ReadLine();
                                                Console.WriteLine("Enter subcategory id:");
                                                int sub_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter subcategory name:");
                                                string sub_name = Console.ReadLine();
                                                Console.WriteLine("Enter gst");
                                                int gst = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter item id:");
                                                int i_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter item name");
                                                string i_name = Console.ReadLine();
                                                Console.WriteLine("Enter price of an item:");
                                                int price = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter stock number");
                                                int stk_num = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter seller id");
                                                int s_id = int.Parse(Console.ReadLine());
                                                pb.Add_Item(c_id, c_name, sub_id, sub_name, i_id, i_name, gst, price, stk_num,s_id);

                                            }//end of for
                                            break;
                                        case 3: sbo.Display_seller_items();
                                            break;
                                        case 5:
                                            //System.Environment.Exit(0);
                                            //break;
                                            goto x;
                                           
                                    }//end of switch
                                }//end of for
                            }//end of else
                        }//end of else
                           
                        break;
                    case 3:Console.WriteLine("1.For new user - SIGNUP/ 2.Already have an account thn LOGIN");
                           int ch1 = int.Parse(Console.ReadLine());
                            Buyer_Bo bb = new Buyer_Bo();

                        if (ch1 == 1)
                        {
                            Console.WriteLine("Enter details for signup\n");
                            Console.WriteLine("Enter name,id,pwd,email_id,phn ");
                            string b_name = Console.ReadLine();
                            int b_id = int.Parse(Console.ReadLine());
                            string b_pwd = Console.ReadLine();
                            string b_emailid = Console.ReadLine();
                            long b_phn =long.Parse(Console.ReadLine());
                            bb.Signup(b_id, b_name, b_pwd, b_emailid, b_phn);
                            Console.WriteLine("Sign Up Successfully\n");
                            
                        }
                        else
                        {
                            Console.WriteLine("Enter ur user name and pwd to Login");
                            string uname = Console.ReadLine();
                            string upwd = Console.ReadLine();
                            bool x = bb.Login(uname, upwd);
                            if (x != true)
                                Console.WriteLine("Invalid credientials\n");
                            else
                            {
                                Console.WriteLine("login successfull\n");
                                while(true)
                                {
                                    Console.WriteLine("1.Display/ 2.Search/3.Display Details/4.exit\n");
                                    int c1 = int.Parse(Console.ReadLine());
                                    if (c1 == 1)
                                        bb.Display();
                                    else if (c1 == 2)
                                        bb.Search();
                                    else if (c1 == 3)
                                        bb.Display_details();
                                    else
                                        goto x;

                                }
                            }
                        }
                        break;


                }//end of switch
                }//end of for
            }//end of main
            
    }//end of program
}//end of namespace
