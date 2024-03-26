using System.Management;
using DriverInfo.ConsoleApp.Extensions;

namespace DriverInfo.ConsoleApp;

public static class DriverInformationService
{
    public static void GetDriversInfo()
    {
        var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

        foreach (ManagementObject driverMO in searcher.Get())
        {
            var driver = CreateDriverFromManagementObject(driverMO);
            Console.WriteLine(driver.ToString());
        }

        Console.ReadLine();
    }

    private static Driver CreateDriverFromManagementObject(ManagementObject driverMO)
    {
        var driver = new Driver();

        foreach (PropertyData property in driverMO.Properties)
        {
            SetProperty(driver, property.Name, property.Value);
        }

        return driver;
    }

    private static void SetProperty(Driver driver, string propertyName, object propertyValue)
    {
        var propertyInfo = typeof(Driver).GetProperty(propertyName);
        if (propertyInfo == null) return;

        object valueToSet = propertyValue;

        if (propertyInfo.PropertyType == typeof(DateTime?))
        {
            valueToSet = propertyValue?.ToString().ConvertWmiDateToDateTime();
        }

        propertyInfo.SetValue(driver, valueToSet);
    }
}
