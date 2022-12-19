Module ModuleVariables
    'Declaration is process reserve a portion in main memory for stroing content variable 
    'Primitive Data Type : Boolean, Byte, Short, Integer, Long, Single, Double, Decimal & Char
    Sub StoreVariable()
        Dim number As Integer = 200
        Dim myName As String = "Bootcamp .NET"
        Console.WriteLine("Number : " & number & ", myname : " & myName)
        myName = "CodeId"
        Console.WriteLine("myName : " & myName)

    End Sub

    'store constant variable
    Sub StoreConstant()
        Const PHI = 3.14159
        Console.WriteLine("Phi : " & PHI)
    End Sub

    'variable a, b, c
    'a=1, b=2, c=3 => a=3, b=1, c=2
    Sub SwapTwoVariable()
        'declare 3 variable
        Dim a, b, c As Integer
        Console.Write("Value A : ")
        a = Console.ReadLine()

        Console.Write("Value B : ")
        b = Console.ReadLine()


        Console.WriteLine("Before : a= " & a & " b=" & b)

        c = a
        a = b
        b = c
        Console.WriteLine("After : a= " & a & " b=" & b)

    End Sub
End Module
