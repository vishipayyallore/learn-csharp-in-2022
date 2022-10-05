namespace GarageDemo.Builders
{

    /// <summary>
    /// ConcreteBuilder2 class
    /// </summary>
    public class BMWCarBuilder : CarBuilder
    {
        // Invoke base class constructor
        public BMWCarBuilder() : base("BMW")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metallic finish'");
        }
    }

}
