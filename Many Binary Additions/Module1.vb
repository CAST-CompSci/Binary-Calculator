Module Module1

    Sub Main()
        Dim userNum, userNum2 As String
        Dim len1, len2 As Integer
        Dim binary As Integer = 1

        Console.WriteLine("Enter first Binary")
        userNum = Console.ReadLine()
        Console.WriteLine("Enter binary to add")
        userNum2 = Console.ReadLine()

        len1 = userNum.Length()
        len2 = userNum2.Length()

        Console.WriteLine(addStrings(userNum, userNum2, len1, len2))
        Console.ReadLine()

    End Sub

    Function addStrings(userNum As String, userNum2 As String, len1 As Integer, len2 As Integer)
        Dim character, character2, temp, result, remind As String
        Dim length1 As Integer = len1
        Dim length2 As Integer = len2
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
        Return result
    End Function
End Module
