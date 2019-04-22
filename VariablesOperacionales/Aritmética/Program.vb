
Module aritmetica
    Sub Main(args As String())

        Dim Valor1 As Int32 = 4
        Dim Valor2 As Int32 = 10
        Dim Float1 As Double = 3.5
        Dim Float2 As Double = 2.8
        Console.WriteLine("Suma")
        Console.WriteLine(Valor1 & " + " & Valor2 & " = " & Valor1 + Valor2)
        Console.WriteLine(Valor1 & " + " & Float2 & " = " & Valor1 + Float2)
        Console.WriteLine(Valor2 & " + " & Float1 & " = " & Valor2 + Float1)
        Console.WriteLine("Resta")
        Console.WriteLine(Valor1 & " - " & Float1 & " = " & Valor1 - Float1)
        Console.WriteLine(Float1 & " - " & Valor2 & " = " & Float1 - Valor2)
        Console.WriteLine(Float2 & " - " & Valor1 & " = " & Float2 - Valor1)
        Console.WriteLine("Multiplicacion")
        Console.WriteLine(Valor1 & " * " & Valor2 & " = " & Valor1 * Valor2)
        Console.WriteLine(Valor2 & " * " & Float2 & " = " & Valor2 * Float2)
        Console.WriteLine(Float1 & " * " & Float2 & " = " & Float1 * Float2)
        Console.WriteLine("Division")
        Console.WriteLine(Valor1 & " / " & Valor2 & " = " & Valor1 / Valor2)
        Console.WriteLine(Valor2 & " / " & Float2 & " = " & Valor2 / Float2)
        Console.WriteLine(Float1 & " / " & Float2 & " = " & Float1 / Float2)
    End Sub
End Module
