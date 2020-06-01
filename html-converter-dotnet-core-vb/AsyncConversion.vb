Imports ceTe.DynamicPDF.HtmlConverter

Friend Class AsyncConversion
    Friend Shared Sub Run()
        ' Create a conversion options class
        Dim conversionOptions As ConversionOptions = New ConversionOptions(PageSize.A4, PageOrientation.Portrait, 54.0F)

        ' Create a simple HTML string 
        Dim sampleHtml As String = "<html><body><p>This is a very simple HTML string including a Table below.</p>" _
                        & "<h4>Two rows and three columns:</h4><table border=""1""><tr><td>100</td><td>200</td>" _
                        & "<td>300</td></tr><tr><td>400</td><td>500</td><td>600</td></tr></table></body></html>"

        ' Asynchronously Convert HTML to PDF with the conversion options specified
        Converter.ConvertAsync(sampleHtml, "AsyncConversion.pdf")
    End Sub
End Class
