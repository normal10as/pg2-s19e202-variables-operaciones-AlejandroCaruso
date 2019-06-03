Imports System.DateTime

Module AjustarReloj
    Sub Main()
        Dim dia As Byte
        Dim hora As Byte
        Dim fechaModificada As Date = Now
        Console.WriteLine("Ingrese el dia (1 a 31)")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese la hora (0 a 24)")
        hora = Console.ReadLine()

    End Sub
End Module
