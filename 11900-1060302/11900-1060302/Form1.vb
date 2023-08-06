Public Class Form1
    '******************************
    '* 11900-1060302 Program Start *
    '******************************
    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        Dim m0 As Integer   '存三角形高度

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060302.SM", OpenMode.Input) '開啟檔案(模式：讀取)
        Input(1, m0)    '存檔案的值
        FileClose(1)    '關檔

        Dim m1 As String = ""   '存列印結果
        Dim i, j As Integer

        '(For...Next)
        'For i = 1 To m0
        '    For j = 1 To i
        '        m1 = m1 & j
        '    Next
        '    m1 = m1 & vbCrLf
        'Next

        '(Do While...Loop)
        'i = 1
        'Do While i <= m0
        '    j = 1
        '    Do While j <= i
        '        m1 = m1 & j
        '        j = j + 1
        '    Loop
        '    m1 = m1 & vbCrLf
        '    i = i + 1
        'Loop

        '(Do...Loop While)
        i = 1
        Do
            j = 1
            Do
                m1 = m1 & j
                j = j + 1
            Loop While j <= i
            m1 = m1 & vbCrLf
            i = i + 1
        Loop While i <= m0

        txt_01.Text = "第二題結果：" & vbCrLf & m1
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m1 As String = ""

        m1 = m1 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m1 = m1 & "座號：[01]　　　　　　日期：[2023/08/06]" & vbCrLf & vbCrLf
        m1 = m1 & txt_01.Text
        e.Graphics.DrawString(m1, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
