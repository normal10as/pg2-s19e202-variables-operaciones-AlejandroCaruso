
Module variables_tipos
    Sub Main()

        Dim NombrePersona As String
        Dim NumeroDocumento As UInteger
        Dim LugarNacimiento As String
        Dim FechaNacimiento As Date
        Dim AlturaCorporal As UShort
        Dim Argentino As Boolean
        Dim TemperaturaAmbiente As UShort
        Dim NombreCalle As String
        Dim AlturaCalle As UShort
        Dim DistanciaCiudades As UShort
        Dim ProfundidadMar As UShort
        Dim Habitantes As UInteger
        Dim Producto As Double
        Dim Monto As Double

        NombrePersona = "Alejandro"
        NumeroDocumento = 40159753
        LugarNacimiento = "Posadas Misiones"
        FechaNacimiento = #1/29/1997#
        AlturaCorporal = 175
        Argentino = True
        TemperaturaAmbiente = 25
        NombreCalle = "Llamas"
        AlturaCalle = 2970
        DistanciaCiudades = 350
        ProfundidadMar = 3000
        Habitantes = 40000000
        Producto = 3.5
        Monto = 53.99

        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Documento: " & NumeroDocumento)
        Console.WriteLine("Lugar de Nacimiento: " & LugarNacimiento)
        Console.WriteLine("Fecha de Nacimiento: " & FechaNacimiento)
        Console.WriteLine("Altura Corporal: " & AlturaCorporal)
        Console.WriteLine("Es Argentino: " & Argentino)
        Console.WriteLine("Temperatura Ambiente: " & TemperaturaAmbiente)
        Console.WriteLine("Nombre de Calle: " & NombreCalle)
        Console.WriteLine("Altura de Calle: " & AlturaCalle)
        Console.WriteLine("Distancia entre ciudades: " & DistanciaCiudades)
        Console.WriteLine("Profundidad del Mar: " & ProfundidadMar)
        Console.WriteLine("Habitantes de Argentina: " & Habitantes)
        Console.WriteLine("Peso del producto: " & Producto)
        Console.WriteLine("Monto del producto: " & Monto)

    End Sub
End Module
