using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Constructor
    {
        private int RollNo;
        private String Name;

        public Constructor()
        {
            this.RollNo = 101;
            this.Name = "Sher Khan";
        }

        public Constructor(int RollNo, String Name)
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
            Constructor s1 = new Constructor();
            s1.Display();

            Constructor s2 = new Constructor(102, "Afaque");
            s2.Display();
        }
    }
}
