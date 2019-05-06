
Module Interes
    Sub Main()
        Dim interesAnual As Double
        Dim monto As Decimal
        Dim tiempo As Int16
        Dim interes As Decimal

        Console.WriteLine("Ingrese el monto")
        monto = Console.ReadLine()
        Console.WriteLine("Ingrese el interes anual")
        interesAnual = Console.ReadLine()
        Console.WriteLine("Ingrese el tiempo")
        tiempo = Console.ReadLine()

        interes = (monto * interesAnual * tiempo) / (360 * 100)
        Console.WriteLine("El interes es de: " & interes)
    End Sub
End Module
