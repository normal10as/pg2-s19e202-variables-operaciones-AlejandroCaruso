Imports System.DateTime

Module Nueva_Fecha
    Sub Main()
        Dim fecha As Date
        Dim dia As Byte
        Console.WriteLine("Ingrese la fecha (dd/mm/yyyy)")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese los dias por adherir: ")
        dia = Console.ReadLine()
        Console.WriteLine("Fecha: " & fecha.AddDays(dia))
    End Sub
End Module
