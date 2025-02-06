using System.Diagnostics.Metrics;

namespace PartialClass
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Country obj = new Country();
            obj.CountryMethod();
            obj.ParentCountryMethod();
        }
    }
}