
Module sumatoriaymedia
    Sub Main()
        Dim a As Int16
        Dim b As Int16
        Dim c As Int16
        Dim d As Int16
        Console.WriteLine("Ingrese los 4 valores:")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        Console.WriteLine("Sumatoria de todos los numeros: " & a + b + c + d)
        Console.WriteLine("Media de los numeros: " & (a + b + c + d) / 4)

    End Sub
End Module
