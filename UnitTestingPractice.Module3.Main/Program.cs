namespace UnitTestingPractice.Module3.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int invoiceId = Int32.Parse(Console.ReadLine());
            
            StartUp1.Start(invoiceId);

            StartUp2.Start(invoiceId);

            StartUp3.Start(invoiceId);

            StartUp4.Start(invoiceId);
        }
    }
}