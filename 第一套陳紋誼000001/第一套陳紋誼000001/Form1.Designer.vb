<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_01 = New System.Windows.Forms.Button()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.txt_01 = New System.Windows.Forms.TextBox()
        Me.txt_02 = New System.Windows.Forms.TextBox()
        Me.btn_02 = New System.Windows.Forms.Button()
        Me.txt_03 = New System.Windows.Forms.TextBox()
        Me.btn_03 = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.txt_04 = New System.Windows.Forms.TextBox()
        Me.btn_04 = New System.Windows.Forms.Button()
        Me.txt_05 = New System.Windows.Forms.TextBox()
        Me.btn_05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(109, 71)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(102, 45)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "第一題"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'pd
        '
        '
        'txt_01
        '
        Me.txt_01.Location = New System.Drawing.Point(35, 122)
        Me.txt_01.Multiline = True
        Me.txt_01.Name = "txt_01"
        Me.txt_01.Size = New System.Drawing.Size(255, 401)
        Me.txt_01.TabIndex = 4
        '
        'txt_02
        '
        Me.txt_02.Location = New System.Drawing.Point(331, 122)
        Me.txt_02.Multiline = True
        Me.txt_02.Name = "txt_02"
        Me.txt_02.Size = New System.Drawing.Size(262, 401)
        Me.txt_02.TabIndex = 6
        '
        'btn_02
        '
        Me.btn_02.Location = New System.Drawing.Point(410, 71)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(102, 45)
        Me.btn_02.TabIndex = 5
        Me.btn_02.Text = "第二題"
        Me.btn_02.UseVisualStyleBackColor = True
        '
        'txt_03
        '
        Me.txt_03.Location = New System.Drawing.Point(631, 122)
        Me.txt_03.Multiline = True
        Me.txt_03.Name = "txt_03"
        Me.txt_03.Size = New System.Drawing.Size(255, 401)
        Me.txt_03.TabIndex = 8
        '
        'btn_03
        '
        Me.btn_03.Location = New System.Drawing.Point(703, 71)
        Me.btn_03.Name = "btn_03"
        Me.btn_03.Size = New System.Drawing.Size(102, 45)
        Me.btn_03.TabIndex = 7
        Me.btn_03.Text = "第三題"
        Me.btn_03.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(1424, 12)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(102, 45)
        Me.btn_print.TabIndex = 9
        Me.btn_print.Text = "列印答案"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'txt_04
        '
        Me.txt_04.Location = New System.Drawing.Point(925, 122)
        Me.txt_04.Multiline = True
        Me.txt_04.Name = "txt_04"
        Me.txt_04.Size = New System.Drawing.Size(255, 401)
        Me.txt_04.TabIndex = 11
        '
        'btn_04
        '
        Me.btn_04.Location = New System.Drawing.Point(997, 71)
        Me.btn_04.Name = "btn_04"
        Me.btn_04.Size = New System.Drawing.Size(102, 45)
        Me.btn_04.TabIndex = 10
        Me.btn_04.Text = "第四題"
        Me.btn_04.UseVisualStyleBackColor = True
        '
        'txt_05
        '
        Me.txt_05.Location = New System.Drawing.Point(1211, 122)
        Me.txt_05.Multiline = True
        Me.txt_05.Name = "txt_05"
        Me.txt_05.Size = New System.Drawing.Size(255, 401)
        Me.txt_05.TabIndex = 13
        '
        'btn_05
        '
        Me.btn_05.Location = New System.Drawing.Point(1283, 71)
        Me.btn_05.Name = "btn_05"
        Me.btn_05.Size = New System.Drawing.Size(102, 45)
        Me.btn_05.TabIndex = 12
        Me.btn_05.Text = "第五題"
        Me.btn_05.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 554)
        Me.Controls.Add(Me.txt_05)
        Me.Controls.Add(Me.btn_05)
        Me.Controls.Add(Me.txt_04)
        Me.Controls.Add(Me.btn_04)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_03)
        Me.Controls.Add(Me.btn_03)
        Me.Controls.Add(Me.txt_02)
        Me.Controls.Add(Me.btn_02)
        Me.Controls.Add(Me.txt_01)
        Me.Controls.Add(Me.btn_01)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents pd As Printing.PrintDocument
    Friend WithEvents txt_01 As TextBox
    Friend WithEvents txt_02 As TextBox
    Friend WithEvents btn_02 As Button
    Friend WithEvents txt_03 As TextBox
    Friend WithEvents btn_03 As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents txt_04 As TextBox
    Friend WithEvents btn_04 As Button
    Friend WithEvents txt_05 As TextBox
    Friend WithEvents btn_05 As Button
End Class
