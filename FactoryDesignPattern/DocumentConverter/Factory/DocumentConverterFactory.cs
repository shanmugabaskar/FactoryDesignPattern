using FactoryDesignPattern.DocumentConverter.Converter;
using FactoryDesignPattern.DocumentConverter.IConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.DocumentConverter.Factory
{
    internal static class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(string format)
        {
            switch (format.ToLower())
            {
                case "docx":
                    return new DocxConverter();
                case "pdf":
                    return new PdfConverter();
                case "txt":
                    return new TxtConverter();
                default:
                    throw new ArgumentException("Unsupported document format");
            }
        }
    }
}
