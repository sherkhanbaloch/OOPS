using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Students
    {
        private int RollNo;
        private String Name;

        public void Accept(int RollNo, String Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine("Roll No. is {0} and Name is {1}", RollNo, Name);
        }

        public static void Main(String[] args)
        {
            Students s1 = new Students();
            s1.Accept(101, "Sher Khan");
            s1.Display();

            Students s2 = new Students();
            s2.Accept(102, "Afaque");
            s2.Display();
        }
    }
}
