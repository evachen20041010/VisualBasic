Imports System.Text

Public Class Form1
    '******************************
    '* 11900-1060307 Program Start *
    '******************************

    Dim suit(4) As String
    Dim card_p() = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
    Dim card_v() = {13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
    Dim mark(51) As Integer
    Dim gn As Integer
    Dim play, bank, result As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        suit(0) = Encoding.UTF8.GetString({226, 153, 160})
        suit(1) = Encoding.UTF8.GetString({226, 153, 165})
        suit(2) = Encoding.UTF8.GetString({226, 153, 166})
        suit(3) = Encoding.UTF8.GetString({226, 153, 163})

        Call rdata()
        Call game()
        Call wdata()
    End Sub

    Sub rdata()
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060307.SM", OpenMode.Input)
        Input(1, gn)

        For i = 1 To gn * 2
            Dim m0 As Single
            Dim m1 As Integer
            Do
                Input(1, m0)
                m1 = Int(m0 * 52)
            Loop While mark(m1) = 1
            mark(m1) = 1
            If i Mod 2 = 1 Then
                play.Add(m1)
            Else
                bank.Add(m1)
            End If
        Next
        FileClose(1)
    End Sub

    Sub game()
        For i = 0 To gn - 1
            Dim s As Integer
            s = card_v(play(i) Mod 13) - card_v(bank(i) Mod 13)
            Select Case s
                Case Is < 0
                    result.Add("莊家贏")
                Case 0
                    result.Add("平手")
                Case Is > 0
                    result.Add("玩家贏")
            End Select
        Next
    End Sub

    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("序號")
        dt.Columns.Add("玩家")
        dt.Columns.Add("莊家")
        dt.Columns.Add("結果")

        For i = 0 To gn - 1
            Dim dr As DataRow = dt.NewRow
            dr(0) = i + 1
            dr(1) = suit(play(i) \ 13) & card_p(play(i) Mod 13)
            dr(2) = suit(bank(i) \ 13) & card_p(bank(i) Mod 13)
            dr(3) = result(i)
            dt.Rows.Add(dr)
        Next

        dgv.DataSource = dt
    End Sub
End Class
