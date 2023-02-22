'Largest number finder
Module Module1

    Sub main()
        Dim largestNumber As Integer = FindLargestNumber()
        Console.WriteLine("The largest number is: " & largestNumber)
        Console.ReadKey()
    End Sub

    Function FindLargestNumber() As Integer
        Console.WriteLine("Enter a list of integers, separated by commas:")
        Dim input As String = Console.ReadLine()
        Dim stringNumbers() As String = input.Split(",")
        Dim numbers(stringNumbers.Length - 1) As Integer
        For i As Integer = 0 To stringNumbers.Length - 1
            numbers(i) = Integer.Parse(stringNumbers(i))
        Next
        Dim largestNumber As Integer = numbers(0)
        For i As Integer = 1 To numbers.Length - 1
            If numbers(i) > largestNumber Then
                largestNumber = numbers(i)
            End If
        Next
        Return largestNumber
    End Function

End Module

'Vowel remover
Module Module2
    Sub main()
        Dim inputString As String
        Dim outputString As String

        inputString = InputBox("Enter a string:")

        outputString = RemoveVowels(inputString)

        MsgBox("The string with all vowels removed is: " & outputString)
    End Sub

    Function RemoveVowels(inputString As String) As String
        Dim outputString As String
        Dim i As Integer
        outputString = " "

        For i = 1 To Len(inputString)
            Select Case LCase(Mid(inputString, i, 1))
                Case "a", "e", "i", "o", "u"
                Case Else
                    outputString = outputString & Mid(inputString, i, 1)
            End Select
        Next i

        RemoveVowels = outputString
    End Function
End Module

'Letters and digit counter
Module Module3
    Sub Main()
        Dim inputString As String
        Dim letterCount As Integer = 0
        Dim digitCount As Integer = 0
        Console.WriteLine("Enter a sentence:")
        inputString = Console.ReadLine()
        For Each c As Char In inputString
            If Char.IsLetter(c) Then
                letterCount += 1
            ElseIf Char.IsDigit(c) Then
                digitCount += 1
            End If
        Next
        Console.WriteLine("LETTERS " & letterCount)
        Console.WriteLine("DIGITS " & digitCount)
        Console.ReadLine()

    End Sub
End Module

'Count characters
Module Module4
    Sub Main()
        Dim inputString As String
        Dim inputChar As Char
        Dim charCount As Integer
        Dim i As Integer

        Console.Write("Enter a string: ")
        inputString = Console.ReadLine()
        Console.Write("Enter a character to count: ")
        inputChar = Console.ReadKey().KeyChar

        For i = 0 To inputString.Length - 1
            If inputString.Chars(i) = inputChar Then
                charCount += 1
            End If
        Next

        Console.WriteLine()
        Console.WriteLine("The character '" & inputChar & "' appears " & charCount & " times in the string.")
        Console.ReadLine()
        Console.ReadKey()
    End Sub

End Module

'Measuring weight
Module Module5
    Sub Main()
        Dim totalWeight As Integer = 0
        Dim rejectedCount As Integer = 0

        For i As Integer = 1 To 5
            Console.WriteLine("Enter weight of parcel " & i & " in kilograms: ")
            Dim weight As Integer = Integer.Parse(Console.ReadLine())

            If weight > 25 Then
                rejectedCount += 1
            Else
                totalWeight += weight
            End If
        Next

        Console.WriteLine("Total weight of accepted parcels: " & totalWeight & " kg")
        Console.WriteLine("Number of parcels rejected: " & rejectedCount)
        Console.ReadLine()
    End Sub

End Module

'Salary calculator
Module Module6
    Sub Main()

        Dim salary As Double
        Dim yearsOfService As Integer
        Dim bonus As Double

        salary = CDbl(InputBox("Enter your salary:"))
        yearsOfService = CInt(InputBox("Enter your years of service:"))

        If yearsOfService > 5 Then
            bonus = 0.05 * salary
            MsgBox("Congratulations! Your net bonus amount is $" & bonus & ".")
        Else
            MsgBox("Sorry, you are not eligible for bonus.")
        End If

    End Sub

End Module
