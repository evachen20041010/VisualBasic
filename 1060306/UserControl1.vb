Public Class UserControl1
    Dim d(100, 4), rno, ec
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        For i = 1 To rno
            ec = ""
            If ec = "" Then Call sp1(i)
            d(i, 4) = ec
        Next
        Call wdata()
    End Sub

    Sub rdata()
        FileOpen(1, "C:\Users\CSIE\source\repos\1060306\1060306.SM", OpenMode.Input)
        rno = 0
        Do While Not EOF(1)
            rno = rno + 1
            For j = 1 To 3
                Input(1, d(rno, j))
            Next
        Loop
        FileClose(1)
    End Sub

    Sub sp1(ByVal i)
        Dim idno = d(i, 1)
        Dim m1 = Len(idno)
        If m1 <> 10 Then ec = "format error"

        Dim m2 = Mid(idno, 1, 1)
        If m2 < "A" Or m2 > "Z" Then ec = "format error"

        For j = 2 To 10
            Dim m3 = Mid(idno, j, 1)
            If m3 < "0" Or m3 > "9" Then ec = "format error"
        Next
    End Sub

    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("ID_NO")
        dt.Columns.Add("NAME")
        dt.Columns.Add("SEX")
        dt.Columns.Add("ERROR")
        For i = 1 To rno
            Dim dr As DataRow = dt.NewRow
            dr(0) = d(i, 1)
            dr(3) = d(i, 4)
            dt.Rows.Add(dr)
        Next
        DGV.DataSource = dt

    End Sub

End Class
