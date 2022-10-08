using CityAdapter.Data;
using CityObjectAdapterDemo.Adaptees;
using CityObjectAdapterDemo.Targets;

namespace CityObjectAdapterDemo.Adapters
{

    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystemApi { get; private set; } = new();

        public City GetCity()
        {
            // call into the external system 
            var cityFromExternalSystem = ExternalSystemApi.GetCity();

            // adapt the CityFromExternalCity to a City 
            return new City(
                $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}"
                , cityFromExternalSystem.Inhabitants);
        }
    }

}
