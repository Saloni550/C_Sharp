using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saloni
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            DelegateExample obj = new DelegateExample();
            myDel del = new myDel(obj.fun);
            del += obj.fun1;
            del();

        }
    }
}