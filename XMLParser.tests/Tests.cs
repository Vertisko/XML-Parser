using NUnit.Framework;
using static XMLParser.XMLParser;
namespace XMLParser.tests

{
    public class Tests
    {
        [TestCase(@"/Users/davidkakis/RiderProjects/XMLParser/XMLParser/test.xml")]
        public void When_InvalidFile_Expect_False(string filePath){
            Assert.That(IsValidXmlString(LoadFileIntoString(filePath)), Is.False);   
        }
        
        [TestCase(@"/Users/davidkakis/RiderProjects/XMLParser/XMLParser/test.xml")]
        public void When_InvalidFile_Expect_True(string filePath){
            Assert.That(LoadXml(filePath), Is.True);   
        }
    }
}