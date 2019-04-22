
Module concatenacion
    Sub Main()
        Dim NombreEmpresa As String = "Analistas"
        Dim NombreCalle As String = "Tripoli"
        Dim AlturaCalle As UInteger = 3080
        Dim Fecha As Date = #4/22/2019#
        Console.WriteLine(NombreEmpresa & " " & NombreCalle & " " & AlturaCalle & " " & Fecha)
        Console.WriteLine(NombreEmpresa + " " + NombreCalle + " " + Convert.ToString(AlturaCalle) + " " + Convert.ToString(Fecha))
    End Sub
End Module
