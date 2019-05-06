Imports System.Math
Module Redondeo
    Sub Main()
        Dim numero As Decimal
        Console.WriteLine("Ingrese un numero")
        numero = Console.ReadLine()
        Console.WriteLine("Exceso: " & Math.Ceiling(numero))
        Console.WriteLine("Defecto: " & Math.Floor(numero))
        Console.WriteLine("Redondeo: " & Math.Round(numero))
    End Sub
End Module
