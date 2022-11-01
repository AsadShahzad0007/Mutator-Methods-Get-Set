using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        };
        static void Main(string[] args)
        {
            Books bb;
            bb.author = "40";
            Books cc;
            Students ss = new Students();
            ss.UserName = "asdasdasd";
            
            if (ss.UserName == "OK")
            {
                Console.WriteLine("Data FOund");
            }
            else
            {
                Console.WriteLine(ss.UserName);
            }
            //Test tt = new Test();
            //if (tt.flag == true)
            //{
            //    //COde working fine
            //}
            Console.ReadLine();
        }
    }

    public class Test
    {
        int a, b, c;
        public bool flag = false;
        public Test(int x, int y, int z)
        {
            a = x;
            b = y;
            c = z;
            if (z == 1)
            {
                flag = true;
            }
        }

        public void GetName()
        { }
        public Test()
        {
            a = 0;
            b = 0;
            c = 0;
        }
    }

    public class Students
    {
        private string accountnumber { get; set; }
        public string UserName
        {
            get { return returnnanme(accountnumber); }
            set { accountnumber = CheckName(value); }
        }

        public string CheckName(string name)
        {
            if (name == "asd" || name == "dsa")
            {
                return "123456";
            }
            else
            {
                return "0";
            }
        }

        public string returnnanme(string name)
        {
            if (accountnumber == "123456")
            {
                return "OK";
            }
            return "Error Account Number Not Found";
        }
    }
}
