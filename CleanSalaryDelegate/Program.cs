using static CleanSalaryDelegate.Delegate;
namespace CleanSalaryDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate ClassObj = new Delegate(out double x);
            DelegateName delegateName = new DelegateName(ClassObj.MilFee);
            delegateName += ClassObj.Tax;
            delegateName(out double y);

            
            Console.WriteLine($"Clean salary: {y}");
        }
        

    }
}




