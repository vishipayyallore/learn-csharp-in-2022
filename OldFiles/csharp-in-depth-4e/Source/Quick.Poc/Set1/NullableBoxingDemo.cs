using Quick.Poc.Interfaces;

namespace Quick.Poc.Set1
{

    public class NullableBoxingDemo : IDemoProgram
    {

        public void ShowDemo()
        {
            int? noValue = new();
            object noValueBoxed = noValue;
            Console.WriteLine($"Original Value: {noValue} Value: {noValueBoxed} Type: {noValueBoxed.GetType()} Equals: {noValueBoxed == null}");

            int? someValue = new int?(5);
            object someValueBoxed = someValue;
            Console.WriteLine($"Original Value: {someValue} Value: {someValueBoxed} Type: {someValueBoxed.GetType()} Equals: {someValueBoxed == null}");
        }

    }

}
