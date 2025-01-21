'Jacob Horsley
'Spring 2025
'RCET 2265
'OperatorsExample
'https://github.com/horsjaco117/OperatorsExample

Option Compare Text



Imports System.Net.Http

Module OperatorsExample

    Sub Main()

        'sum operator
        Console.Write("5 + 3 = ") 'Print a string
        Console.WriteLine(5 + 3) 'print the sum
        Console.WriteLine()


        'subtraction(Difference) operator
        Console.Write("5 - 3 = ") 'Print a string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'multiplication operator
        Console.Write("5 * 3 = ") 'Print a string
        Console.WriteLine(5 * 3) 'print the multiplication
        Console.WriteLine()

        'Floating point division operation
        Console.Write("5 / 3 = ") 'Print a string
        Console.WriteLine(5 / 3) 'print the floating point quotient
        Console.WriteLine()

        'integer division operator
        Console.Write("5 \ 3 = ") 'Print a string
        Console.WriteLine(5 \ 3) 'print the quotient
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'Print a string
        Console.WriteLine(5 Mod 3) 'print the remainder
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'Print a string
        Console.WriteLine(5 ^ 3) 'print the exponent
        Console.WriteLine()

        'concatenation operator
        Console.Write("5" & "" & "+" & "3" & "=" & "8") 'Print a string
        Console.WriteLine()
        Console.WriteLine(vbNewLine & "wake up neo..." & vbNewLine & "follow the white rabbit...")
        Console.WriteLine(StrDup(10, "*"))

        'Compare
        Console.Write("5 > 3 =") 'print a string
        Console.WriteLine(5 > 3) '
        Console.WriteLine()

        Console.Write("5 < 3 =") 'print a string
        Console.WriteLine(5 < 3) '
        Console.WriteLine()

        Console.Write("does 5 = 3 ? ") 'print a string
        Console.WriteLine(5 = 3) '
        Console.WriteLine()

        Console.Write("is 5 not equal to 3 ? ") 'print a string
        Console.WriteLine(5 <> 3) '
        Console.WriteLine()

        Console.Write("A > B = ") 'print a string
        Console.WriteLine("A" > "B") '
        Console.WriteLine()

        Console.Write("is " & Chr(34) & "A" & Chr(34) & " the same as " & Chr(34) & "a" & Chr(34) & "  ") 'print a string
        Console.WriteLine("A" = "a") '
        Console.WriteLine()



    End Sub

End Module
