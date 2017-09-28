Module Module1

    Sub Main()
        Dim userNum(0) As String
        Dim howMany As Integer
        Dim binary As Integer = 1
        Dim answer As String

        Console.WriteLine("Please enter how many binary strings you would like to add")
        howMany = Integer.Parse(Console.ReadLine())

        ReDim userNum(howMany)

        For i = 0 To howMany
            Console.WriteLine("Please Binary String " + i.ToString())
            userNum(i) = Console.ReadLine()
        Next

        For i = 0 To userNum.Length() - 1
            If userNum(i).Length < 64 Then
                For ib = 0 To (64 - userNum(i).Length())
                    userNum(i) = "0" + userNum(i)
                Next
            End If
        Next

        answer = addStrings(userNum(0), userNum(1), 64, 64)

        For i = 2 To howMany
            answer = addStrings(answer, userNum(i), 64, 64)
        Next

        Console.WriteLine(answer)
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
