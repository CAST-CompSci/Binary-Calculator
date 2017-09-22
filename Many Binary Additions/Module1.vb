Module Module1
    Sub Main()
        Dim binary As String
        Dim binary2 As String
        Dim len, len2 As Integer
        Dim countdown, countdown2, ram As Integer




        Console.WriteLine("please enter a binery number")
        binary = Console.ReadLine
        Console.WriteLine("please enter a binery number")
        binary2 = Console.ReadLine
        len = binary.Length
        len2 = binary2.Length

        Dim Val(len) As String
        Dim Val2(len2) As String
        Dim ans(len + 1) As String
        Dim L As String

        countdown = len
        For i = 1 To len
            Val(i) = binary.Chars(countdown - 1)
            countdown = countdown - 1

        Next

        countdown2 = len2
        For i = 1 To len2
            Val2(i) = binary.Chars(countdown2 - 1)
            countdown2 = countdown2 - 1
        Next


        L = len + 1

        For i = 1 To len
            If Val(i) + Val2(i) = 0 Then
                ans(L) = "0"
                ram = "0"
            ElseIf Val(i) + Val2(i) = 1 Then
                ans(L) = "1"
                ram = "0"
            ElseIf Val(i) + Val2(i) = 2 Then
                ans(L) = "0"
                ram = "1"
            ElseIf Val(i) + Val2(i) + ram = 3 Then
                ans(L) = "1"
                ram = "1"
            End If
            L = L - 1

        Next

        For Each num As String In ans
            Console.WriteLine(num & " ")

        Next
        Console.WriteLine("")

        Console.ReadLine()


    End Sub
End Module