using CityAdapterData;
using CityClassAdapterDemo.Adaptees;
using CityClassAdapterDemo.Targets;

namespace CityClassAdapterDemo.Adapters
{

    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            // call into the external system 
            var cityFromExternalSystem = base.GetCity();

            // adapt the CityFromExternalCity to a City 
            return new City(
                $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}"
                , cityFromExternalSystem.Inhabitants);
        }
    }

}
