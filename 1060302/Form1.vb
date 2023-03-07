Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\CSIE\source\repos\1060302\1060302.sm", OpenMode.Input)
        Input(1, m0)
        FileClose()

        For i = 1 To m0
            For j = 1 To i
                m1 = m1 & j
            Next
            m1 = m1 & vbNewLine
        Next

        txt_2.Text = "第二題結果：" & vbNewLine & m1

    End Sub
End Class