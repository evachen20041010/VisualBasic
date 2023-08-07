Public Class Form1
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

        '(For...Next)
        'For i = 1 To m0
        '    If m0 Mod i = 0 Then
        '        x = x + 1
        '    End If
        'Next

        '(Do While...Loop)
        'i = 1
        'Do While i <= m0
        '    If m0 Mod i = 0 Then
        '        x = x + 1
        '    End If
        '    i = i + 1
        'Loop

        '(Do...Loop While)
        i = 1
        Do
            If m0 Mod i = 0 Then
                x = x + 1
            End If
            i = i + 1
        Loop While i <= m0

        If x = 2 Then
            txt_01.Text = "第三題結果：" & m0 & " is a prime number."
        Else
            txt_01.Text = "第三題結果：" & m0 & " is not a prime number."
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/07]" & vbCrLf & vbCrLf
        m0 = m0 & txt_01.Text & vbCrLf

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
