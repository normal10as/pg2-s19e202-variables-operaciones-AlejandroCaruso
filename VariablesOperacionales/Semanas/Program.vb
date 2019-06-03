
Module Semanas
    Sub Main()
        Const diasPorSemana As Double = 7
        Const horasPorDia As Int16 = 24
        Const minutosPorHora As Int16 = 60
        Dim numeroDias As Double
        Dim semanas As Double
        Dim horas As Int16
        Dim minutos As Int16
        Console.WriteLine("Ingrese numero de dias.")
        numeroDias = Console.ReadLine()
        semanas = numeroDias / diasPorSemana
        horas = numeroDias * horasPorDia
        minutos = numeroDias * horasPorDia * minutosPorHora
        Console.WriteLine("En " & numeroDias & " dias hay " & semanas & " semanas, " & horas & " horas y " & minutos & " minutos.")
    End Sub
End Module