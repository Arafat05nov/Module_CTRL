'Count vowels
Module Module1
    Sub CountVowels()
        Dim count As Integer = 0
        Console.Write("Please Enter a Message: ")
        Dim strInput As String = Console.ReadLine()
        For i As Integer = 0 To (strInput.Length - 1)
            If strInput(i) = "a" Or strInput(i) = "e" Or strInput(i) = "i" Or strInput(i) = "o" Or strInput(i) = "u" Then
                count += 1
            End If
        Next
        Console.WriteLine("Vowels in {0}: {1}", strInput, count)
    End Sub

End Module

'Even number sum
Module Module2
    Function SumEvenNumbers(numbers As List(Of Integer)) As Integer
        Dim sum As Integer = 0
        For Each num As Integer In numbers
            If num Mod 2 = 0 Then
                sum += num
            End If
        Next
        Return sum
    End Function

End Module

'Average calculator
Module Module3
    Function CalculateAverage(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Double
        Dim sum As Integer = num1 + num2 + num3 + num4
        Dim average As Double = sum / 4.0
        Return average
    End Function

End Module

'Squareroot calculator
Module Module4
    Function CalculateSquareRoot(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Double
        Dim sumSquareRoots As Double = 0.0
        Dim numCount As Integer = 0

        For Each num As Integer In {num1, num2, num3, num4}
            Dim squareRoot As Double = 0.0
            Dim prevSquareRoot As Double = -1.0

           
            While squareRoot <> prevSquareRoot
                prevSquareRoot = squareRoot
                squareRoot = (squareRoot + num / squareRoot) / 2
            End While

            sumSquareRoots += squareRoot
            numCount += 1
        Next

        Dim averageSquareRoot As Double = sumSquareRoots / numCount
        Return averageSquareRoot
    End Function

End Module

'Upper and lower case counter
Module Module5
    Sub CountUpperCaseLowerCase(sentence As String)
        Dim upperCount As Integer = 0
        Dim lowerCount As Integer = 0

        For Each c As Char In sentence
            If c >= "A" AndAlso c <= "Z" Then
                upperCount += 1
            ElseIf c >= "a" AndAlso c <= "z" Then
                lowerCount += 1
            End If
        Next

        Console.WriteLine("UPPER CASE " & upperCount)
        Console.WriteLine("LOWER CASE " & lowerCount)
    End Sub
    

