Module Module1

    Sub Main()
        Dim palabra1 As String
        Dim palabra2 As String
        Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo."
        Console.WriteLine("Ingrese la palabra que quiere reemplazar")
        palabra1 = Console.ReadLine()
        Console.WriteLine("Ingrese la palabra que reemplazaria a la primera")
        palabra2 = Console.ReadLine()
        Console.WriteLine("Antes: " & frase)
        Console.WriteLine("Despues: " & Strings.Replace(frase, palabra1, palabra2))
    End Sub

End Module
