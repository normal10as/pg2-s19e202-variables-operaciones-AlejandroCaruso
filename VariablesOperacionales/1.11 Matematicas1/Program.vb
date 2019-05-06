Imports System.Math
Module Matematicas1
    Sub Main()
        Dim numero As Decimal
        Console.WriteLine("Ingrese un numero")
        numero = Console.ReadLine()
        Console.WriteLine("Valor absoluto: " & Math.Abs(numero))
        Console.WriteLine("Decima potencia: " & (numero ^ 10))
        Console.WriteLine("Raiz cuadrada: " & Sqrt(numero))
    End Sub
End Module
