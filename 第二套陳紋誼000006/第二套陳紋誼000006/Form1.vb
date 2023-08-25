Public Class Form1
    '******************************
    '* 11900-1060306 Program Start *
    '******************************

    Dim rno As Integer = 0
    Dim data(100, 4) As String
    Dim ec As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        For i = 1 To rno
            ec = ""
            If ec = "" Then sp1(i)
            If ec = "" Then sp2(i)
            If ec = "" Then sp3(i)
            data(i, 4) = ec
        Next
        Call wdata()
    End Sub

    Sub rdata()
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060306.SM", OpenMode.Input)
        Do While Not EOF(1)
            rno = rno + 1
            Input(1, data(rno, 1))
            Input(1, data(rno, 2))
            Input(1, data(rno, 3))
        Loop
        FileClose(1)
    End Sub

    Sub sp1(ByVal i)
        If Not data(i, 1) Like "[A-Z]#########" Then
            ec = "FORMAT ERROR"
        End If
    End Sub

    Sub sp2(ByVal i)
        Dim d As String
        d = Mid(data(i, 1), 2, 1) & data(i, 3)
        If d <> "1M" And d <> "2F" Then
            ec = "SEX CODE ERROR"
        End If
    End Sub

    Sub sp3(ByVal i)
        Dim l1 As String
        Dim pid_e As String = "ABCDEFGHJKLMNPQRSTUVXYWZIO"
        Dim x, x1, x2, y As Integer
        l1 = Mid(data(i, 1), 1, 1)
        x = InStr(pid_e, l1) + 9
        x1 = x \ 10
        x2 = x Mod 10
        y = x1 + x2 * 9
        For j = 2 To 9
            y = y + Mid(data(i, 1), j, 1) * (10 - j)
        Next
        y = y + Mid(data(i, 1), 10, 1)
        If y Mod 10 <> 0 Then
            ec = "CHECK SUM ERROR"
        End If
    End Sub

    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("ID_NO")
        dt.Columns.Add("NAME")
        dt.Columns.Add("SEX")
        dt.Columns.Add("ERROR")

        For i = 1 To rno
            Dim dr As DataRow = dt.NewRow
            dr(0) = data(i, 1)
            dr(1) = data(i, 2)
            dr(2) = data(i, 3)
            dr(3) = data(i, 4)
            dt.Rows.Add(dr)
        Next

        dgv.DataSource = dt
        dgv.Sort(dgv.Columns(0), 0)
    End Sub
End Class
