Public Class Form1
    '******************************
    '* 11900-1060304 Program Start *
    '******************************
    Private Sub btn_04_Click(sender As Object, e As EventArgs) Handles btn_04.Click
        Dim h(3), w(3) As Integer   '身高和體重的陣列
        Dim bmi(3) As Single    '存計算結果(可以存浮點數)

        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060304.SM", OpenMode.Input)  '開啟檔案(模式：讀取)

        Dim i As Integer = 0
        Dim bmi_s As Single = 0 '存最小BMI

        ''(For...Next)
        ''抓檔案資料並計算BMI
        'For i = 1 To 3
        '    Input(1, h(i))
        '    Input(1, w(i))
        '    bmi(i) = w(i) / (h(i) / 100) ^ 2
        'Next
        'FileClose(1)
        'bmi_s = bmi(1)
        ''找最小BMI
        'For i = 1 To 3
        '    If bmi(i) < bmi_s Then
        '        bmi_s = bmi(i)
        '    End If
        'Next

        ''(Do While...Loop)
        ''抓檔案資料並計算BMI
        'i = 1
        'Do While i <= 3
        '    Input(1, h(i))
        '    Input(1, w(i))
        '    bmi(i) = w(i) / (h(i) / 100) ^ 2
        '    i = i + 1
        'Loop
        'FileClose(1)
        'bmi_s = bmi(1)
        ''找最小BMI
        'i = 1
        'Do While i <= 3
        '    If bmi(i) < bmi_s Then
        '        bmi_s = bmi(i)
        '    End If
        '    i = i + 1
        'Loop

        '(Do...Loop While)
        '抓檔案資料並計算BMI
        i = 1
        Do
            Input(1, h(i))
            Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
            i = i + 1
        Loop While i <= 3
        FileClose(1)
        bmi_s = bmi(1)
        '找最小BMI
        i = 1
        Do
            If bmi(i) < bmi_s Then
                bmi_s = bmi(i)
            End If
            i = i + 1
        Loop While i <= 3

        '最小值做四捨五入
        Dim bmi45 As Integer = bmi_s    '自動做四捨五入
        If bmi45 >= 20 And bmi45 <= 25 Then
            txt_01.Text = "第四題結果：最小BMI值=" & bmi45 & "，正常"
        Else
            txt_01.Text = "第四題結果：最小BMI值=" & bmi45 & "，不正常"
        End If

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0 As String = ""

        m0 = m0 & "姓名：[陳紋誼]　　　　術科測試編號：[000001]" & vbCrLf
        m0 = m0 & "座號：[01]　　　　　　日期：[2023/08/09]" & vbCrLf & vbCrLf
        m0 = m0 & txt_01.Text & vbCrLf

        e.Graphics.DrawString(m0, txt_01.Font, Brushes.Black, 100, 100)
    End Sub
End Class
