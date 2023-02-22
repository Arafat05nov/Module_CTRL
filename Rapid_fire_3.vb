'Longest word finder
Module Module1
    Sub Main()

        Dim inputSent As String
        Dim longestWord As String

        longestWord = " "

        Console.WriteLine("Please enter a string:")
        inputSent = Console.ReadLine()

        Dim words As String() = inputSent.Split(New Char() {" "c})
        For Each word As String In words
            If word.Length > longestWord.Length Then
                longestWord = word
            End If
        Next
        Console.WriteLine("The longest word in your string is: " & longestWord)

        Console.ReadLine()

        Console.ReadKey()
    End Sub

End Module

'Sort an array
Module Module2
    Sub Main()
        Dim array() As Integer
        Dim n As Integer
        Dim i As Integer
        Dim temp As Integer

        Console.Write("Enter the size of the array: ")
        n = Console.ReadLine()

        ReDim array(n - 1)

        For i = 0 To n - 1
            Console.Write("Enter element " & i + 1 & ": ")
            array(i) = Console.ReadLine()
        Next i

        For i = 0 To n - 2
            For j = 0 To n - i - 2
                If array(j) > array(j + 1) Then
                    temp = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp
                End If
            Next j
        Next i

        Console.Write("Sorted array: ")
        For i = 0 To n - 1
            Console.Write(array(i) & " ")
        Next i

        Console.ReadKey()
    End Sub
End Module

'Ride requirement checker
Module Module3
    Sub main()
        Dim passed, rejected As Integer
        Dim height As String
        passed = 0
        rejected = 0
        Do
            Console.WriteLine("Please enter the child's height in meters: ")
            height = CInt(Console.ReadLine())
            If height < 1.2 Then
                rejected = rejected + 1
            Else
                passed = passed + 1
            End If
        Loop Until passed = 6
        Console.WriteLine("The ride is ready to go, the number of rejected children is: " & rejected)

        Console.ReadKey()
    End Sub
End Module

'Library fine
Module Module4
    Sub main()
     
        Dim fine As Integer
        Dim late_days As String
        fine = 0
        Console.WriteLine("Please enter number of days")
        late_days = Console.ReadLine()

        If late_days <= 10 Then
            fine = late_days * 3
        ElseIf late_days <= 30 Then
            fine = late_days * 5
        Else
            fine = (30 * 7) + ((late_days - 30) * 10)
        End If
        Console.WriteLine("Your fine is " & fine)

        Console.ReadKey()
    End Sub

End Module

'Spot repeatition
Module Module5
    Sub main()
        Console.WriteLine("Please enter a string:")
        Dim inputString As String = Console.ReadLine()

        Dim result As String = FirstNonRepeatedChar(inputString)
        If result = "" Then
            Console.WriteLine("No non-repeated characters found.")
        Else
            Console.WriteLine("The first non-repeated character is: " & result)
        End If

        Console.ReadKey()
    End Sub
    Function FirstNonRepeatedChar(ByVal inputString As String) As String
        Dim charCount As New Dictionary(Of String, Integer)


        For i = 1 To Len(inputString)
            Dim currentChar As String = Mid(inputString, i, 1)
            If charCount.ContainsKey(currentChar) Then
                charCount(currentChar) = 1
            Else
                charCount(currentChar) = 1
            End If
        Next

        For i = 1 To Len(inputString)
            Dim currentChar As String = Mid(inputString, i, 1)
            If charCount(currentChar) = 1 Then
                FirstNonRepeatedChar = currentChar
                Exit Function
            End If
        Next

        FirstNonRepeatedChar = ""

    End Function

End Module
