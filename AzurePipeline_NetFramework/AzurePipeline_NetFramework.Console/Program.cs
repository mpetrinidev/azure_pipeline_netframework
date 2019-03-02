using System.Configuration;

namespace AzurePipeline_NetFramework.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorAppSetting = ConfigurationManager.AppSettings["Environment"];
            System.Console.WriteLine($"value of app config: {valorAppSetting}");

            var valorCnnString = ConfigurationManager.ConnectionStrings["CnnStr"].ToString();
            System.Console.WriteLine($"value of connection string: {valorCnnString}");

            System.Console.ReadLine();
        }
    }
}
