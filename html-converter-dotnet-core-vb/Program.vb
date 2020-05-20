Imports System

Module Program
    Sub Main(args As String())
        SimpleConversion.Run()
        Console.WriteLine("SimpleConversion is completed...")

        HtmlConversionUsingString.Run()
        Console.WriteLine("HtmlConversionUsingString is completed...")

        WithConversionOptions.Run()
        Console.WriteLine("WithConversionOptions is completed...")

        AsyncConversion.Run()
        Console.WriteLine("AsyncConversion was started...")

        Console.WriteLine("Completed...")
        Console.ReadLine()
    End Sub
End Module
