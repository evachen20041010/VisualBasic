Public Class Form1
    '******************************
    '* 11900-1060308 Program Start *
    '******************************

    Dim b, a, op, y, x, ans As New ArrayList
    Dim rno As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        Call sp()
        Call wdata()
    End Sub

    Sub rdata()
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060308.SM", OpenMode.Input)
        Do While Not EOF(1)
            Dim d
            rno = rno + 1
            Input(1, d) : b.Add(d)
            Input(1, d) : a.Add(d)
            Input(1, d) : op.Add(d)
            Input(1, d) : y.Add(d)
            Input(1, d) : x.Add(d)
        Loop
        FileClose(1)
    End Sub

    Sub sp()
        For i = 0 To rno - 1
            Dim m0, m1 As Integer
            Select Case op(i)
                Case "+"
                    m0 = b(i) * x(i) + a(i) * y(i)
                    m1 = a(i) * x(i)
                Case "-"
                    m0 = b(i) * x(i) - a(i) * y(i)
                    m1 = a(i) * x(i)
                Case "*"
                    m0 = b(i) * y(i)
                    m1 = a(i) * x(i)
                Case "/"
                    m0 = b(i) * x(i)
                    m1 = a(i) * y(i)
            End Select

            Dim j As Integer = 2
            Do While j <= m0 And j <= m1
                Do While m0 Mod j = 0 And m1 Mod j = 0
                    m0 = m0 / j
                    m1 = m1 / j
                Loop
                j = j + 1
            Loop

            If m0 = 0 Then
                ans.Add(0)
            ElseIf m1 = 1 Then
                ans.Add(m0)
            Else
                ans.Add(m0 & "/" & m1)
            End If
        Next
    End Sub

    Sub wdata()
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
