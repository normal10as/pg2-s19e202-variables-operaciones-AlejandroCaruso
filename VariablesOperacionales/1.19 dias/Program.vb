Imports System

Module Dias
    Enum diasSemana
        Domingo = 1
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
    End Enum
    Sub Main()
        Console.WriteLine(diasSemana.Domingo & ") {0}", diasSemana.Domingo)
        Console.WriteLine(diasSemana.Lunes & ") {0}", diasSemana.Lunes)
        Console.WriteLine(diasSemana.Martes & ") {0}", diasSemana.Martes)
        Console.WriteLine(diasSemana.Miercoles & ") {0}", diasSemana.Miercoles)
        Console.WriteLine(diasSemana.Jueves & ") {0}", diasSemana.Jueves)
        Console.WriteLine(diasSemana.Viernes & ") {0}", diasSemana.Viernes)
        Console.WriteLine(diasSemana.Sabado & ") {0}", diasSemana.Sabado)

    End Sub
End Module
