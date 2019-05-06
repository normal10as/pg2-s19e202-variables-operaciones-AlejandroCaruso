Module Module1
    Sub Main()
        Dim palabra As String
        Console.WriteLine("Ingrese una palabra")
        palabra = Console.ReadLine()
        Console.WriteLine("Primer A: " & Strings.InStr(palabra, "a"))
        Console.WriteLine("Primer O:" & Strings.InStr(palabra, "o"))
        Console.WriteLine("Invertida: " & Strings.StrReverse(palabra))
    End Sub
End Module
