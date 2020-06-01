Imports ceTe.DynamicPDF.HtmlConverter
Friend Class SimpleConversion
    Friend Shared Sub Run()
        ' Convert HTML to PDF with the default conversion options
        Converter.Convert(New Uri("https://www.google.com"), "SimpleConversion.pdf")
    End Sub
End Class
