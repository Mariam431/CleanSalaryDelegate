using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSalaryDelegate
{
    internal class Delegate
    {
        public double dirtySalary { get; set; }
        public Delegate(out double dirtySalary)
        {
            Console.Write("Enter dirty salary: ");
            dirtySalary = double.Parse(Console.ReadLine());
            this.dirtySalary = dirtySalary;
        }

        public delegate void DelegateName(out double y); //Delegate


        public void MilFee(out double cleanSalary)
        {
            double militaryFee = 0.1 * dirtySalary;
            cleanSalary = dirtySalary - militaryFee;
        }



        public void Tax(out double cleanSalary )
        {
            double taxes = 0.05 * dirtySalary;
            cleanSalary = dirtySalary - taxes;
        }

    }
}
