Public Class Form1
    '******************************
    '* 11900-1060301 Program Start *
    '******************************
    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0 As Integer

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        Dim m1, m2, m3, m4 As Integer
        m1 = m0
        For i = 1 To 9
            m2 = m1 Mod 10
            m4 = m4 & m2
            m3 = m1 \ 10
            If m3 = 0 Then
                Exit For
            End If
            m1 = m3
        Next

        If m0 = m4 Then
            txt_01.Text = "第一題結果：" & m0 & " is a palindrome."
        Else
            txt_01.Text = "第一題結果：" & m0 & " is not a palindrome."
        End If

    End Sub

    '******************************
    '* 11900-1060302 Program Start *
    '******************************
    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        Dim m0 As Integer

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060302.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        Dim m1 As String = ""
        For i = 1 To m0
            For j = 1 To i
                m1 = m1 & j
            Next
            m1 = m1 & vbCrLf
        Next

        txt_02.Text = "第二題結果：" & vbCrLf & m1
    End Sub

    '******************************
    '* 11900-1060303 Program Start *
    '******************************
    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles btn_03.Click
        Dim m0 As Integer

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060303.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        Dim x As Integer = 0
        For i = 1 To m0
            If m0 Mod i = 0 Then
                x += 1
            End If
        Next
        If x = 2 Then
            txt_03.Text = "第三題結果：" & m0 & " is a prime number."
        Else
            txt_03.Text = "第三題結果：" & m0 & " is not a prime number."
        End If
    End Sub

    '******************************
    '* 11900-1060304 Program Start *
    '******************************
    Private Sub btn_04_Click(sender As Object, e As EventArgs) Handles btn_04.Click
        Dim h(3), w(3) As Integer
        Dim bmi(3) As Single

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060304.SM", OpenMode.Input)
        Input(1, h(1)) : Input(1, w(1))
        Input(1, h(2)) : Input(1, w(2))
        Input(1, h(3)) : Input(1, w(3))
        FileClose(1)

        For i = 1 To 3
            bmi(i) = w(i) / (h(i) / 100) ^ 2
        Next

        Dim bmi_s As Single = bmi(1)
        If bmi(2) < bmi_s Then
            bmi_s = bmi(2)
        ElseIf bmi(3) < bmi_s Then
            bmi_s = bmi(3)
        End If

        Dim bmi45 As Integer
        bmi_s = bmi_s + 0.5
        bmi45 = bmi_s - bmi_s Mod 1

        If bmi45 >= 20 And bmi45 <= 25 Then
            txt_04.Text = "第四題結果：最小BMI值=" & bmi45 & "，正常"
        Else
            txt_04.Text = "第四題結果：最小BMI值=" & bmi45 & "，不正常"
        End If
    End Sub

    '******************************
    '* 11900-1060305 Program Start *
    '******************************
    Private Sub btn_05_Click(sender As Object, e As EventArgs) Handles btn_05.Click
        Dim a(2, 2), b(2, 2), ans(2, 2) As Integer

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060305.SM", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose(1)

        For i = 1 To 2
            For j = 1 To 2
                ans(i, j) = a(i, j) + b(i, j)
            Next
        Next

        txt_05.Text = "第五題結果：" & vbCrLf
        txt_05.Text += "[" & ans(1, 1) & "   " & ans(1, 2) & "]" & vbCrLf
        txt_05.Text += "[" & ans(2, 1) & "   " & ans(2, 2) & "]" & vbCrLf
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/25]" & vbCrLf & vbCrLf
        m0 = m0 & txt_01.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_02.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_03.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_04.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_05.Text & vbCrLf & vbCrLf

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
