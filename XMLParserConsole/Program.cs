using static XMLParser.XMLParser;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace XMLParserConsole
{
    public class CompareXmlCorrection
   {   
       [Benchmark]
       public string BenchmarkRegex() => RemoveInvalidCharactersUsingRegex(LoadFileIntoString(@"/Users/davidkakis/RiderProjects/XMLParser/XMLParser/test.xml"));
      
       [Benchmark]
       public string BenchmarkLoopingChars() => RemoveInvalidChractersUsingLoop(LoadFileIntoString(@"/Users/davidkakis/RiderProjects/XMLParser/XMLParser/test.xml"));
       
   }
    class Program
    {
       
        private static void Main()
        {
            BenchmarkRunner.Run<CompareXmlCorrection>();
        }
    }
    
   
}