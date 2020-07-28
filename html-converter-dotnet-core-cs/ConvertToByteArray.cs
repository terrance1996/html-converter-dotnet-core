using System;
using System.IO;
using ceTe.DynamicPDF.HtmlConverter;

namespace html_converter_dotnet_core_cs
{
    class ConvertToByteArray
    {
        public static void Run()
        {
            // Convert HTML to PDF with the default conversion options
            byte[] pdfByteArray = Converter.Convert(new Uri("https://www.google.com"));
            // Write the bytes to disk, or you can do whatever you need to with it
            File.WriteAllBytes("ConvertToByteArray.pdf", pdfByteArray);
        }
    }
}
