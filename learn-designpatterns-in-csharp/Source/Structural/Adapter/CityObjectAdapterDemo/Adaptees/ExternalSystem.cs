using CityAdapter.Data;

namespace CityObjectAdapterDemo.Adaptees
{

    /// <summary>
    /// Adaptee
    /// </summary>
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity() => new("Antwerp", "'t Stad", 500000);
    }

}
