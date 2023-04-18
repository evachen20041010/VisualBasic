Public Class UserControl1
    Dim d(100, 4), rno, ec
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        For i = 1 To rno
            ec = ""
            If ec = "" Then Call sp1(i)
            If ec = "" Then Call sp2(i)
            If ec = "" Then Call sp3(i)
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

    Sub sp2(ByVal i)
        Dim sex_12 = Mid(d(i, 1), 2, 1)
        Dim sex_MF = d(i, 3)
        Dim msex = sex_12 & sex_MF
        If msex <> "1M" And msex <> "2F" Then ec = "SEX CODE ERROR"
    End Sub

    Sub sp3(ByVal i)
        Dim L1 = Mid(d(i, 1), 1, 1)
        Dim s26 = "ABCDEFGHJKLMNPQRSTUVXYWZIO"
        Dim m1 = InStr(s26, L1) + 9
        Dim x1 = m1 \ 10
        Dim x2 = m1 Mod 10

        Dim a(9)
        For j = 2 To 10
            a(j - 1) = Mid(d(i, 1), j, 1)
        Next

        Dim y = x1 + 9 * x2
        For j = 1 To 8
            y = y + (9 - j) * a(j)
        Next
        y = y + a(9)
        If y Mod 10 <> 0 Then ec = "check sum error"
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
            dr(1) = d(i, 2)
            dr(2) = d(i, 3)
            dr(3) = d(i, 4)
            dt.Rows.Add(dr)
        Next
        DGV.DataSource = dt

    End Sub

End Class
