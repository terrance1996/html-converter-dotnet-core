using ceTe.DynamicPDF.HtmlConverter;
using System;

namespace html_converter_dotnet_core_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleConversion.Run();
            Console.WriteLine("SimpleConversion is completed...");

            HtmlConversionUsingString.Run();
            Console.WriteLine("HtmlConversionUsingString is completed...");
            
            WithConversionOptions.Run();
            Console.WriteLine("WithConversionOptions is completed...");
            
            AsyncConversion.Run();
            Console.WriteLine("AsyncConversion was started...");

            Console.WriteLine("Completed...");
            Console.ReadLine();
        }
    }
}
