Public Class UserControl1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "C:\Users\CSIE\source\repos\1060305\1060305\1060305.SM", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose()

        Dim i = 1
        Do
            Dim j = 1
            Do
                c(i, j) = a(i, j) + b(i, j)
                j = j + 1

            Loop While j <= 2
            i = i + 1
        Loop While i <= 2

        Dim m1
        m1 = m1 & "[" & c(1, 1) & "       " & c(1, 2) & "]" & vbNewLine
        m1 = m1 & "[" & c(2, 1) & "   " & c(2, 2) & "]" & vbNewLine

        txt_5.Text = "第五題結果：" & vbNewLine & m1
    End Sub
End Class
