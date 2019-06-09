Imports System.DateTime

Module AjustarReloj
    Sub Main()
        Dim dia, hora As Byte
        Dim fechaModificada As Date
        Console.WriteLine("Ingrese el dia (1 a 31)")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese la hora (0 a 24)")
        hora = Console.ReadLine()
        fechaModificada = New DateTime(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)
        Console.WriteLine("La fecha modificada es: {0}", fechaModificada)
    End Sub
End Module
