using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class abstraction
    {
        //abstract class Animal

        //Abstarct method(does not have a body)
        public abstract void animalsound();
        //regular methid
        public void sleep()
        {
            Console.WriteLine("'Zzz");
        }  
    }
        //Derived class(inherent from animal)
    class Cow : Animal
    {
        public override void animalsound()
        {
         Console.WriteLine("the Cow saya:hmm hmm");

    }
    }
    class Program
    {
        static void Main(string[] arg)
        {
            Cow mycow = new Cow();
            mycow.animalsound();
            mycow.sleep();
        }
}
    }

}
