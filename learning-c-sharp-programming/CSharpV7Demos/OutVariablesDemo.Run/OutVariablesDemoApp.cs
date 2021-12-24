using OutVariablesDemo.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariablesDemo.Run
{
    public class OutVariablesDemoApp
    {

        private readonly IIntegerParser _integerParser;

        public OutVariablesDemoApp(IIntegerParser integerParser)
        {
            _integerParser = integerParser ?? throw new ArgumentNullException(nameof(integerParser));
        }

        public void Run()
        {
            var value1 = "125";
            var value2 = "A125";

            _integerParser.IntTryParseV1(value1);
            _integerParser.IntTryParseV1(value2);
            
            _integerParser.IntTryParseV2(value1);
            _integerParser.IntTryParseV2(value2);
        }

    }

}
