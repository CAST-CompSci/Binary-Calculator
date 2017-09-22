Module Module1

    Sub Main()
        Dim userNum, userNum2, character, character2, temp, remind, result As String
        Dim length1, length2, len1, len2 As Integer
        Dim binary As Integer = 1

        Console.WriteLine("Enter first Binary")
        userNum = Console.ReadLine()
        Console.WriteLine("Enter binary to add")
        userNum2 = Console.ReadLine()

        length1 = userNum.Length
        len1 = length1
        length2 = userNum2.Length
        len2 = length2

        remind = "0"
        result = ""

        For i = 1 To len1

            character = userNum.Chars(len1 - 1)
            character2 = userNum2.Chars(len2 - 1)


            temp = character & character2 & remind


            If temp = "000" Then
                result = "0" & result
            ElseIf temp = "100" Then
                result = "1" & result
            ElseIf temp = "010" Then
                result = "1" & result
            ElseIf temp = "001" Then
                result = "1" & result
            ElseIf temp = "110" Then
                result = "0" & result
                remind = "1"
            ElseIf temp = "101" Then
                result = "0" & result
                remind = "1"
            ElseIf temp = "011" Then
                result = "0" & result
                remind = "1"
            ElseIf temp = "111" Then
                result = "1" & result
                remind = "1"
            End If

            If temp = "111" And i = length1 Then
                result = "1" & result
            ElseIf temp = "011" And i = length1 Then
                result = "1" & result
            ElseIf temp = "110" And i = length1 Then
                result = "1" & result
            ElseIf temp = "101" And i = length1 Then
                result = "1" & result
            End If

            len1 = len1 - 1
            len2 = len2 - 1
            temp = ""
        Next

        Console.WriteLine(result)
        Console.ReadLine()

    End Sub

End Module
