using DriverInfo.ConsoleApp;

namespace ProcuraDeDriver.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
                DriverInformationService.GetDriversInfo();
        }
    }
}
