Public Class Form1
    '******************************
    '* 11900-1060306 Program Start *
    '******************************
    Dim ec As String = ""   '儲存檢查結果
    Dim rno As Integer = 0  '讀進來的資料筆數
    Dim data(100, 4) As String  '讀進來的資料(可以存100筆，每筆四個位置)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()    '讀檔案資料

        For i = 1 To rno    '檢查每筆資料
            ec = ""
            If ec = "" Then sp1(i)
            If ec = "" Then sp2(i)
            If ec = "" Then sp3(i)

            data(i, 4) = ec '檢查結果寫入第四欄
        Next

        Call wdata()    '顯示檔案資料
    End Sub

    Sub rdata() '讀檔案資料
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060306.SM", OpenMode.Input)
        Do While Not EOF(1) '讀完檔案的所有資料
            rno = rno + 1   '資料筆數+1
            Input(1, data(rno, 1))  '身分證字號
            Input(1, data(rno, 2))  '姓名
            Input(1, data(rno, 3))  '性別
        Loop
        FileClose()
    End Sub

    Sub sp1(ByVal i)   '格式錯誤檢查(函式接收一個參數)
        Dim pid As String = data(i, 1)  '身分證字號
        Dim d As Integer = 0

        If pid.Length <> 10 Then ec = "FORMAT ERROR"    '字串長度不等於10時
        If Strings.Left(pid, 1) < "A" Or Strings.Left(pid, 1) > "Z" Then ec = "FORMAT ERROR"    '第一個字不是大寫
        For d = 2 To 10
            If Mid(pid, d, 1) < "0" Or Mid(pid, d, 1) > "9" Then ec = "FORMAT ERROR"    '後9位皆是數字
        Next
    End Sub

    Sub sp2(ByVal i)   '性別錯誤檢查(函式接收一個參數)
        Dim msex As String = Mid(data(i, 1), 2, 1) & data(i, 3) '字串第二個字+性別

        If msex <> "1M" And msex <> "2F" Then ec = "SEX CODE ERROR"
    End Sub

    Sub sp3(ByVal i)   '檢核數錯誤檢查(函式接收一個參數)
        Dim pid_e As String = Mid(data(i, 1), 1, 1) '取第一個英文字
        Dim s26 As String = "ABCDEFGHJKLMNPQRSTUVXYWZIO"    '規定的順序
        Dim x, x1, x2, y, j As Integer

        x = InStr(s26, pid_e) + 9   '取字母L1的代號
        x1 = x \ 10 '十位
        x2 = x Mod 10   '個位
        y = x1 + 9 * x2
        For j = 2 To 9
            y = y + (10 - j) * Mid(data(i, 1), j, 1)    '累加D1~D8的數
        Next
        y = y + Mid(data(i, 1), 10, 1)  '再加上D9(第10位)的數

        If y Mod 10 <> 0 Then ec = "CHECK SUM ERROR"
    End Sub

    Sub wdata() '顯示執行結果
        Dim i As Integer = 0
        Dim dt As New DataTable '宣告一個新的資料表

        dt.Columns.Add("ID_NO") '建立欄位名稱
        dt.Columns.Add("NAME")
        dt.Columns.Add("SEX")
        dt.Columns.Add("ERROR")

        '填入每筆資料
        For i = 1 To rno
            Dim dr As DataRow = dt.NewRow   '新增一個資料列
            dr(0) = data(i, 1)  '該列的第一欄
            dr(1) = data(i, 2)
            dr(2) = data(i, 3)
            dr(3) = data(i, 4)
            dt.Rows.Add(dr)
        Next

        '顯示資料
        dgv.DataSource = dt

        '照身分證由小到大排序
        dgv.Sort(dgv.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        '避免空白欄
        dgv.AllowUserToAddRows = False
    End Sub
End Class
