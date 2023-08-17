Imports System.Text

Public Class Form1
    '******************************
    '* 11900-1060307 Program Start *
    '******************************

    Dim suit(4) As String   '花色
    Dim mark(51) As Integer '0沒有發過牌 1有發過牌
    Dim card_p() = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}   '點數
    Dim card_v() = {13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}  '比值
    Dim gn As Integer   '遊戲次數
    Dim play, bank, result As New ArrayList '紀錄發給玩家和莊家的牌以及比大小後的結果

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '宣告花色
        suit(0) = Encoding.UTF8.GetString({226, 153, 160})
        suit(1) = Encoding.UTF8.GetString({226, 153, 165})
        suit(2) = Encoding.UTF8.GetString({226, 153, 166})
        suit(3) = Encoding.UTF8.GetString({226, 153, 163})

        Call rdata()
        Call game()
        Call wdata()
    End Sub

    Sub rdata() '讀資料
        FileOpen(1, "C:\Users\mshome\source\11900\範例光碟\1060307.SM", OpenMode.Input)
        Input(1, gn)    '第一筆為遊戲次數
        For i = 1 To gn * 2
            Dim r As Single '存隨機數
            Dim k As Integer    '轉換成牌編號
            Do
                Input(1, r)
                k = Int(r * 52) 'Int()無條件捨去小數點
            Loop While mark(k) = 1  '不斷重複迴圈直到抽到的牌沒有被重複抽到
            mark(k) = 1 '標示已經被抽過
            If i Mod 2 = 1 Then
                play.Add(k) '牌發給玩家
            Else
                bank.Add(k) '牌發給莊家
            End If
        Next
    End Sub

    Sub game()  '比大小
        For i = 0 To gn - 1 'ArrayList從0開始
            Dim a As Integer    '紀錄比值相減的結果

            '算出各自的比值後相減
            '算比值：先將抽到的牌編號/13取餘數，得出0~12的結果，再到card_v()對應出比值
            a = card_v(play(i) Mod 13) - card_v(bank(i) Mod 13)
            Select Case a
                Case Is > 0
                    result.Add("玩家贏")
                Case 0
                    result.Add("平手")
                Case Is < 0
                    result.Add("莊家贏")
            End Select
        Next
    End Sub

    Sub wdata() '輸出結果
        Dim dt As New DataTable '新增資料表

        dt.Columns.Add("序號")    '新增欄位名稱
        dt.Columns.Add("玩家")
        dt.Columns.Add("莊家")
        dt.Columns.Add("結果")

        For i = 0 To gn - 1
            Dim dr As DataRow = dt.NewRow   '新增一列
            dr(0) = i + 1   '序號
            dr(1) = suit(play(i) \ 13) & card_p(play(i) Mod 13) '花色：取牌編號/13的整數 點數：取牌編號/13的餘數
            dr(2) = suit(bank(i) \ 13) & card_p(bank(i) Mod 13)
            dr(3) = result(i)   '結果

            dt.Rows.Add(dr) '將列新增到資料表
        Next

        dgv.DataSource = dt     '資料表內容顯示在dgv上
    End Sub
End Class
