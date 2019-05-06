
Module Semanas
    Sub Main()
        Dim diasPorSemana As Double = 7
        Dim horasPorDia As Int16 = 24
        Dim minutosPorHora As Int16 = 60
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