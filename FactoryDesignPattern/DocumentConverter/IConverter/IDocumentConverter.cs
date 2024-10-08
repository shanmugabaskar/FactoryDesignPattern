using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.DocumentConverter.IConverter
{
    internal interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }
}
