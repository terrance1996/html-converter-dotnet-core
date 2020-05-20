using DynamicPDF.HtmlConverter;
using System;

namespace html_converter_dotnet_core_cs
{
    class WithConversionOptions
    {
        public static void Run()
        {
            // Create a conversion options class
            ConversionOptions options = new ConversionOptions(PageSize.Letter, PageOrientation.Portrait, 50.0f);
            
            // Set Metadata for the PDF
            options.Author = "ceTe Software With Conversion Options Example";
            options.Creator = "ceTe Software";
            options.Producer = "HTML Converter";

            // Set Header and Footer text
            options.Header = "<div style=\"text-align:center;display:inline-block;width:100%;font-size:12px;\"><span class=\"date\"></span></div>"; ;
            options.Footer = "<div style=\"text-align:center;display:inline-block;width:100%;font-size:12px;\">Page <span class=\"pageNumber\"></span> of <span class=\"totalPages\"></span></div>";
            
            // Convert HTML to PDF with the conversion options specified
            Converter.Convert(new Uri("https://www.google.com"), "WithConversionOptions.pdf", options);
        }
    }
}
