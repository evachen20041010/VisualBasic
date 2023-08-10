Public Class Form1
    '******************************
    '* 11900-1060305 Program Start *
    '******************************
    Private Sub btn_05_Click(sender As Object, e As EventArgs) Handles btn_05.Click
        Dim a(2, 2), b(2, 2), c(2, 2) As Integer    'c陣列存結果

        '抓資料
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060305.SM", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose(1)

        Dim i, j As Integer

        ''相加(For...Next)
        'For i = 1 To 2
        '    For j = 1 To 2
        '        c(i, j) = a(i, j) + b(i, j)
        '    Next
        'Next

        ''相加(Do While...Loop)
        'i = 1
        'Do While i <= 2
        '    j = 1
        '    Do While j <= 2
        '        c(i, j) = a(i, j) + b(i, j)
        '        j = j + 1
        '    Loop
        '    i = i + 1
        'Loop

        '相加(Do...Loop While)
        i = 1
        Do
            j = 1
            Do
                c(i, j) = a(i, j) + b(i, j)
                j = j + 1
            Loop While j <= 2
            i = i + 1
        Loop While i <= 2

        Dim m0 As String = ""

        m0 = m0 & "[" & c(1, 1) & "    " & c(1, 2) & "]" & vbCrLf
        m0 = m0 & "[" & c(2, 1) & "    " & c(2, 2) & "]"
        txt_01.Text = "第五題結果：" & vbCrLf & m0
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/10]" & vbCrLf & vbCrLf
        m0 = m0 & txt_01.Text

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
