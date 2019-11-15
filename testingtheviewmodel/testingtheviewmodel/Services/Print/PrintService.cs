using System.Diagnostics;

namespace testingtheviewmodel.Services.Print
{
    public class PrintService : IPrintService
    {
        public void Print()
        {
            Debug.WriteLine("This is a real message");
        }
    }
}