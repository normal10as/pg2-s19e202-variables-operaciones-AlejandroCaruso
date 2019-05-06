Module Variables
    Sub Main()
        Dim Nombre As String
        Dim Apellido As String
        Dim FechaNacimiento As Date

        Console.WriteLine("Escriba su nombre: ")
        Nombre = Console.ReadLine()
        Console.WriteLine("Escriba su apellido: ")
        Apellido = Console.ReadLine()
        Console.WriteLine("Escriba su fecha de Nacimiento (DD/MM/AAAA)")
        FechaNacimiento = Console.ReadLine()

        Console.WriteLine(Nombre & ", " & Apellido & ". Nacido el dia: " & FechaNacimiento)
    End Sub
End Module
