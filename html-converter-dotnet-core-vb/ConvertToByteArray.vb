Imports System.IO
Imports ceTe.DynamicPDF.HtmlConverter
Public Class ConvertToByteArray
    Friend Shared Sub Run()
        ' Convert HTML to PDF with the default conversion options
        Dim PdfByteArray As Byte() = Converter.Convert(New Uri("https://www.google.com"));
        ' Write the bytes to disk, Or you can do whatever you need to with it
        File.WriteAllBytes("ConvertToByteArray.pdf", PdfByteArray)
    End Sub
End Class
