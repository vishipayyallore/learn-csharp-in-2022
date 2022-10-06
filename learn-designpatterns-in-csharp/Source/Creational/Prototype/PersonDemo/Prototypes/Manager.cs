using Newtonsoft.Json;

namespace PersonDemo.Prototypes
{
    /// <summary>
    /// ConcretePrototype2
    /// </summary>
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                var objectAsJson = JsonConvert.SerializeObject(this, typeof(Manager), settings);

                return JsonConvert.DeserializeObject<Person>(objectAsJson, settings);
            }

            return (Person)MemberwiseClone();
        }
    }
}
