using Quick.Poc.Helpers;

namespace Quick.Poc.Set1
{

    public static class RunSetOneDemos
    {

        public static void Run()
        {
            DemoPrograms.Run(new NamesWithStringCollection(), "Names With ArrayList");
            DemoPrograms.Run(new NamesWithList(), "Names With List");
            DemoPrograms.Run(new NullableBoxingDemo(), "Nullable Boxing Demo");
            DemoPrograms.Run(new TypeOfDemo(), "TypeOf() Demo");
        }

    }

}
