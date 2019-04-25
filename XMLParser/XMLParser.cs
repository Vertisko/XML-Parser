using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;


namespace XMLParser
{
    public static class XMLParser
    {
        public static bool LoadXml(string filePath)
        {
            try
            {
                //loading xml file into string
                var content = LoadFileIntoString(filePath);
                //if incorrect 
                if (!IsValidXmlString(content))
                {
                    //repair
                    content = RemoveInvalidCharactersUsingLoop(content);
                }

                // load string with standard XML library
                XElement parsedFile = XElement.Parse(content);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string LoadFileIntoString(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static string RemoveInvalidCharactersUsingLoop(string content)
        {
            if (string.IsNullOrEmpty(content))
                return content;

            var length = content.Length;
            var stringBuilder = new StringBuilder(length);

            for (var i = 0; i < length; ++i)
            {
                if (XmlConvert.IsXmlChar(content[i]))
                {
                    stringBuilder.Append(content[i]);
                }
                else if (i + 1 < length && XmlConvert.IsXmlSurrogatePair(content[i + 1], content[i]))
                {
                    stringBuilder.Append(content[i]);
                    stringBuilder.Append(content[i + 1]);
                    ++i;
                }
            }

            return stringBuilder.ToString();
        }

        public static string RemoveInvalidCharactersUsingRegex(string content)
        {
            const string pattern = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            return Regex.Replace(content, pattern, "");
        }

        public static bool IsValidXmlString(string content)
        {
            try
            {
                XmlConvert.VerifyXmlChars(content);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}