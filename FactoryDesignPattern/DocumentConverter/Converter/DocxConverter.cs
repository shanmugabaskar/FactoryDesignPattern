using FactoryDesignPattern.DocumentConverter.IConverter;

namespace FactoryDesignPattern.DocumentConverter.Converter
{
    internal class DocxConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to DOCX format...");
            // Logic for DOCX conversion, simplified for this example
            return content + " [Converted to DOCX]";
        }
        public string TargetExtension => ".docx";
    }
}
