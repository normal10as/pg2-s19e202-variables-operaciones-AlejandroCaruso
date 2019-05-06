Imports System.Math
Module Mayor
    Sub Main()
        Dim numero1 As Decimal
        Dim numero2 As Decimal
        Dim numero3 As Decimal
        Console.WriteLine("Ingrese los tres numeros")
        numero1 = Console.ReadLine()
        numero2 = Console.ReadLine()
        numero3 = Console.ReadLine()
        Console.WriteLine("Mayor: " & Math.Max(Math.Max(numero1, numero2), numero3))
    End Sub
End Module
