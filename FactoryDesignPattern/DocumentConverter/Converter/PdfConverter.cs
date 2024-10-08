using FactoryDesignPattern.DocumentConverter.IConverter;

namespace FactoryDesignPattern.DocumentConverter.Converter
{
    internal class PdfConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to PDF format...");
            // Logic for PDF conversion, simplified for this example
            return content + " [Converted to PDF]";
        }
        public string TargetExtension => ".pdf";
    }
}
