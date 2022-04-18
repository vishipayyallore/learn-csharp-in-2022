using QuickPoc.Interfaces;
using System.Data;
using System.Reflection;
using static System.Console;

namespace QuickPoc.Set
{
    public class AssemblyTypesAndMethodsDemo : IDemoProgram
    {
        private DataSet? _ds;
        private HttpClient? _httpClient;

        public void ShowDemo()
        {
            _ds = new DataSet();
            _httpClient = new HttpClient();
            WriteLine($"DataSet: {_ds} || HttpClient: {_httpClient}");

            Assembly? _assembly = Assembly.GetEntryAssembly();
            if (_assembly == null)
            {
                return;
            }


            // loop through the assemblies that this app references
            foreach (AssemblyName assemblyName in _assembly.GetReferencedAssemblies())
            {
                Assembly? assembly = Assembly.Load(assemblyName);

                int methodCount = 0;

                foreach (TypeInfo typeInfo in assembly.GetTypes())
                {
                    methodCount += typeInfo.GetMethods().Length;
                }

                // output the count of types and their methods
                WriteLine(
                   "{0:N0} types with {1:N0} methods in {2} assembly.",
                   arg0: assembly.DefinedTypes.Count(),
                   arg1: methodCount, arg2: assemblyName.Name);
            }

        }

    }

}
