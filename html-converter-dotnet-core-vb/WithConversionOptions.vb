Imports ceTe.DynamicPDF.HtmlConverter
Friend Class WithConversionOptions
    Friend Shared Sub Run()
        ' Create a conversion options class
        Dim options As ConversionOptions = New ConversionOptions(PageSize.Letter, PageOrientation.Portrait, 50.0F)

        ' Set Metadata for the PDF
        options.Author = "ceTe Software With Conversion Options Example"
        options.Creator = "ceTe Software"
        options.Producer = "HTML Converter"

        ' Set Header and Footer text
        options.Header = "<div style=""text-align:center;display:inline-block;width: 100%;font-size:12px;""><span class=""date""></span></div>"
        options.Footer = "<div style=""text-align:center;display:inline-block;width: 100%;font-size:12px;"">Page <span class=""pageNumber""></span> of <span class=""totalPages""></span></div>"

        ' Convert HTML to PDF with the conversion options specified
        Converter.Convert(New Uri("https://www.google.com"), "WithConversionOptions.pdf", options)
    End Sub
End Class
