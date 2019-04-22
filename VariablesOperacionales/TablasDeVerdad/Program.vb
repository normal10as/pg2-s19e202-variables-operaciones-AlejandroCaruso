
Module Booleans
    Sub Main()
        Dim a As Boolean = True
        Dim b As Boolean = False
        Dim c As Boolean
        Console.WriteLine("Conjuncion")
        c = a And a
        Console.WriteLine("V y V " & c)
        c = a And b
        Console.WriteLine("V y F " & c)
        c = b And a
        Console.WriteLine("F y V " & c)
        c = b And b
        Console.WriteLine("F y F " & c)
        Console.WriteLine("Negacion")
        c = Not a
        Console.WriteLine("No V " & c)
        c = Not b
        Console.WriteLine("No F " & c)
        Console.WriteLine("Disyuncion inclusiva")
        c = a Or a
        Console.WriteLine("V o V " & c)
        c = a Or b
        Console.WriteLine("V o F " & c)
        c = b Or a
        Console.WriteLine("F o V " & c)
        c = b Or b
        Console.WriteLine("F o F " & c)
        Console.WriteLine("Disyuncion exclusiva")
        c = a Xor a
        Console.WriteLine("V o V " & c)
        c = a Xor b
        Console.WriteLine("V o F " & c)
        c = b Xor a
        Console.WriteLine("F o v " & c)
        c = b Xor b
        Console.WriteLine("F o F " & c)

    End Sub
End Module
