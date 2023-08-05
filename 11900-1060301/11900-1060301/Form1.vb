Public Class Form1
    '******************************
    '* 11900-1060301 Program Start *
    '******************************
    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0 As Integer   '存參考資料的數字

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060301.SM", OpenMode.Input) '開啟檔案(模式：讀取)
        Input(1, m0)    '存檔案的值
        FileClose(1)    '關檔

        Dim i, m1, m2, m3 As Integer
        Dim m4 As String = ""   '存倒過來的數字串
        m1 = m0

        '將數字串倒過來存入m0(For...Next)
        'For i = 1 To 9
        '    m2 = m1 Mod 10
        '    m3 = m1 \ 10
        '    m4 = m4 & m2
        '    If m3 = 0 Then
        '        Exit For
        '    End If
        '    m1 = m3
        'Next

        '將數字串倒過來存入m0(Do While...Loop)
        'i = 0
        'Do While i <= 9
        '    m2 = m1 Mod 10
        '    m3 = m1 \ 10
        '    m4 = m4 & m2
        '    If m3 = 0 Then
        '        Exit Do
        '    End If
        '    m1 = m3
        '    i = i + 1
        'Loop

        '將數字串倒過來存入m0(Do...Loop While)
        i = 0
        Do
            m2 = m1 Mod 10
            m3 = m1 \ 10
            m4 = m4 & m2
            If m3 = 0 Then
                Exit Do
            End If
            m1 = m3
            i = i + 1
        Loop While i <= 9

        '判斷數字串是不是迴文
        If m0 = m4 Then
            txt_01.Text = "第一題結果：" & m0 & " is a palindrome."
        Else
            txt_01.Text = "第一題結果：" & m0 & " is not a palindrome."
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf    '換行符號：vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/03]" & vbCrLf & vbCrLf  '標點符號和空格要全形
        m0 = m0 & txt_01.Text

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
        '列印：Graphics.DrawString(內容, 字型, 字的顏色, 列印位置, 列印位置)
    End Sub
End Class
