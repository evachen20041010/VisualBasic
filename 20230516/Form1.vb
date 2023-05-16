Public Class Form1
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\CSIE\source\repos\20230516\1060301.sm", OpenMode.Input)
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

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\CSIE\source\repos\20230516\1060303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        For i = 1 To m0
            If m0 Mod i = 0 Then m1 = m1 + 1
        Next
        If m1 = 2 Then
            txt_2.Text = "第三題結果:" & m0 & "is a prime number."
        Else
            txt_2.Text = "第三題結果:" & m0 & "is not a prime number."
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "C:\Users\CSIE\source\repos\20230516\1060305.SM", OpenMode.Input)
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

        txt_3.Text = "第五題結果：" & vbNewLine & m1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0
        Dim vn = vbNewLine
        m0 = m0 & "姓名：[陳紋誼] 准考證號碼：[999999]" & vn
        m0 = m0 & "座號：[01] 日期：[2018/01/21]" & vn & vn
        m0 = m0 & txt_1.Text & vn & vn
        m0 = m0 & txt_2.Text & vn & vn
        m0 = m0 & txt_3.Text & vn & vn

        Dim mtxt = m0
        Dim mfont = txt_1.Font
        Dim mcolor = Brushes.Black
        Dim x = 100
        Dim y = 100
        e.Graphics.DrawString(mtxt, mfont, mcolor, x, y)
    End Sub
End Class
