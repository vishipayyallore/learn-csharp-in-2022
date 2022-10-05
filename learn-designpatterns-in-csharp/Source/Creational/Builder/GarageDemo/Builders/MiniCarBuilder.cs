namespace GarageDemo.Builders
{

    /// <summary>
    /// ConcreteBuilder1 class
    /// </summary>
    public class MiniCarBuilder : CarBuilder
    {
        public MiniCarBuilder() : base("Mini")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'3-door with stripes'");
        }
    }

}
