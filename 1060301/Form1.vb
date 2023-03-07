Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\CSIE\source\repos\1060301\1060301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose()
        m1 = m0
        For i = 1 To 9
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then Exit For
            m1 = m2
        Next

        If m0 = m4 Then
            txt_1.Text = "第一題結果：" & m0 & "is a plaindrome"
        Else
            txt_1.Text = "第一題結果：" & m0 & "is not a plaindrome"
        End If

    End Sub
End Class