Public Class Form1
    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim h(3), w(3), bmi(3), s_bmi
        FileOpen(1, "C:\Users\CSIE\source\repos\1060304\1060304.sm", OpenMode.Input)
        For i = 1 To 3
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
        Next
        FileClose(1)

        s_bmi = bmi(1)
        For i = 1 To 3
            If bmi(i) < s_bmi Then s_bmi = bmi(i)
        Next
        Dim s_bmi45 As Integer = s_bmi

        If s_bmi45 >= 20 And s_bmi45 <= 25 Then
            txt_4.Text = "第四題結果:最小bmi值" & s_bmi45 & "，正常"
        Else
            txt_4.Text = "第四題結果:最大bmi值" & s_bmi45 & "，不正常"
        End If
    End Sub
End Class