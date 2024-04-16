namespace HPiLO4HealthReader
{
    internal class Program
    {
        static void Main()
        {
            var hp = new ILO4HealthReader(
                Environment.GetEnvironmentVariable("BaseUri")!,
                Environment.GetEnvironmentVariable("UserName")!,
                Environment.GetEnvironmentVariable("UserPass")!);

            var retVal = hp.GetHealthAndUptime().Result;
            Console.WriteLine(retVal.HealthAtAGlance);
        }
    }
}
