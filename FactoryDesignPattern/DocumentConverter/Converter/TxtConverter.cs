﻿using FactoryDesignPattern.DocumentConverter.IConverter;

namespace FactoryDesignPattern.DocumentConverter.Converter
{
    internal class TxtConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to TXT format...");
            // Logic for TXT conversion, simplified for this example
            return content + " [Converted to TXT]";
        }
        public string TargetExtension => ".txt";
    }
}
