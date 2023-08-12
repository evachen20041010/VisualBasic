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
        For i = 1 To 9
            m2 = m1 Mod 10
            m3 = m1 \ 10
            m4 = m4 & m2
            If m3 = 0 Then
                Exit For
            End If
            m1 = m3
        Next

        '判斷數字串是不是迴文
        If m0 = m4 Then
            txt_01.Text = "第一題結果：" & m0 & " is a palindrome."
        Else
            txt_01.Text = "第一題結果：" & m0 & " is not a palindrome."
        End If
    End Sub

    '******************************
    '* 11900-1060303 Program Start *
    '******************************
    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles btn_03.Click
        Dim m0 As Integer = 0   '存輸入的數字

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060303.SM", OpenMode.Input) '開啟檔案(模式：讀取)
        Input(1, m0)    '存檔案的值
        FileClose(1)    '關檔

        Dim i As Integer = 0
        Dim x As Integer = 0   '可以整除的數有多少

        '(Do While...Loop)
        i = 1
        Do While i <= m0
            If m0 Mod i = 0 Then
                x = x + 1
            End If
            i = i + 1
        Loop

        If x = 2 Then
            txt_03.Text = "第三題結果：" & m0 & " is a prime number."
        Else
            txt_03.Text = "第三題結果：" & m0 & " is not a prime number."
        End If
    End Sub

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
        txt_05.Text = "第五題結果：" & vbCrLf & m0
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/13]" & vbCrLf & vbCrLf

        m0 = m0 & txt_01.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_03.Text & vbCrLf & vbCrLf
        m0 = m0 & txt_05.Text & vbCrLf & vbCrLf

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
