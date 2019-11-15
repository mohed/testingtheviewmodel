using System.Diagnostics;

namespace testingtheviewmodel.Services.Print
{
    public class MockPrintService: IPrintService
    {
        public void Print()
        {
            Debug.WriteLine("This is a mock message");
        }
    }
}