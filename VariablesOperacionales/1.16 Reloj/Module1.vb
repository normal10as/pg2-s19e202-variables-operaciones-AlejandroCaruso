Imports System.DateTime
Module Module1

    Sub Main()
        Dim fecha1 As Date = Now
        Console.WriteLine("Dia del año: " & fecha1.Day)
        Console.WriteLine("Mes: " & fecha1.Month)
        Console.WriteLine("Minuto y segundo: " & fecha1.Minute & ":" & fecha1.Second)
        Console.ReadLine()
    End Sub

End Module