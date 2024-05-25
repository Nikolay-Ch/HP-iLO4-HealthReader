namespace HPiLO4HealthReader
{
    internal class Program
    {
        static void Main()
        {
            var hp = new ILO4DataReader(
                Environment.GetEnvironmentVariable("BaseUri")!,
                Environment.GetEnvironmentVariable("UserName")!,
                Environment.GetEnvironmentVariable("UserPass")!);

            var retVal1 = hp.GetHostData().Result;
            Console.WriteLine(retVal1);

            var retVal2 = hp.GetHealthAndUptime().Result;
            Console.WriteLine(retVal2.HealthAtAGlance);
        }
    }
}
