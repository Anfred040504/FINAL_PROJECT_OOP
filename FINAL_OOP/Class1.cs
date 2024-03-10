using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_OOP
{
    public class Class1
    {
        private string Item {  get; set; }
        private string Quantity { get; set; }
        private string TotalPrice { get; set; }
        public void Method()
        {

        }
    }
    public class Class: Class1 {
        public void Method()
        {

        }
    }
    public class Class2 : Class1
    {
        public void Method()
        {

        }
    }
    abstract class Class3
    {
        public abstract void newMethod();
    }
    }

