Public Class Form1
    '******************************
    '* 11900-1060308 Program Start *
    '******************************
    Dim b, a, op, y, x, ans As New ArrayList    '存檔案的值和運算結果
    Dim rno As Integer  '紀錄資料筆數
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        Call sp()
        Call wdata()
    End Sub

    Sub rdata() '讀資料
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060308.SM", OpenMode.Input)
        Dim d   '暫存讀入的資料，型態不同所以不宣告型態
        Do While Not EOF(1) '讀完所有資料
            Input(1, d) : b.Add(d)
            Input(1, d) : a.Add(d)
            Input(1, d) : op.Add(d)
            Input(1, d) : y.Add(d)
            Input(1, d) : x.Add(d)
            rno = rno + 1   '資料筆數
        Loop
        FileClose(1)
    End Sub

    Sub sp()    '做四則運算
        Dim m1, m2, j As Integer   '存分子、分母、公因數
        For i = 0 To rno - 1
            '判斷運算符號，並算出分子分母
            Select Case op(i)
                Case "+"
                    m1 = b(i) * x(i) + a(i) * y(i)
                    m2 = a(i) * x(i)
                Case "-"
                    m1 = b(i) * x(i) - a(i) * y(i)
                    m2 = a(i) * x(i)
                Case "*"
                    m1 = b(i) * y(i)
                    m2 = a(i) * x(i)
                Case "/"
                    m1 = b(i) * x(i)
                    m2 = a(i) * y(i)
            End Select

            '約分到最簡分數
            j = 2
            Do While j <= m1 And j <= m2
                Do While m1 Mod j = 0 And m2 Mod j = 0
                    m1 = m1 / j
                    m2 = m2 / j
                Loop
                j = j + 1
            Loop

            '運算結果加入到ans
            If m1 = 0 Then
                ans.Add(0)
            ElseIf m2 = 1 Then
                ans.Add(m1)
            Else
                ans.Add(m1 & "/" & m2)
            End If
        Next
    End Sub

    Sub wdata() '輸出結果
        Dim dt As New DataTable
        dt.Columns.Add("VALUE1")
        dt.Columns.Add("OP")
        dt.Columns.Add("VALUE2")
        dt.Columns.Add("ANSWER")

        For i = 0 To rno - 1
            Dim dr As DataRow = dt.NewRow
            dr(0) = b(i) & "/" & a(i)
            dr(1) = op(i)
            dr(2) = y(i) & "/" & x(i)
            dr(3) = ans(i)
            dt.Rows.Add(dr)
        Next

        dgv.DataSource = dt
    End Sub
End Class
