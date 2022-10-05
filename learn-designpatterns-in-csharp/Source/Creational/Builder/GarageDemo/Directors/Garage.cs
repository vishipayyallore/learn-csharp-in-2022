using GarageDemo.Builders;

using static System.Console;

namespace GarageDemo.Directors
{

    /// <summary>
    /// Director
    /// </summary>
    public class Garage
    {
        private CarBuilder? _builder;

        public Garage()
        {
        }

        public void Construct(CarBuilder builder)
        {
            _builder = builder;

            _builder.BuildEngine();
            _builder.BuildFrame();
        }

        // variation: the show method on the director instead of on the product.
        public void Show()
        {
            WriteLine(_builder?.Car.ToString());
        }
    }

}
