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
        Me.btn_print = New System.Windows.Forms.Button()
        Me.txt_01 = New System.Windows.Forms.TextBox()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(80, 43)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(95, 29)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "第一題"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(248, 43)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(95, 29)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "列印答案"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'txt_01
        '
        Me.txt_01.Location = New System.Drawing.Point(80, 97)
        Me.txt_01.Multiline = True
        Me.txt_01.Name = "txt_01"
        Me.txt_01.Size = New System.Drawing.Size(360, 240)
        Me.txt_01.TabIndex = 2
        '
        'pd
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_01)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_01)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents txt_01 As TextBox
    Friend WithEvents pd As Printing.PrintDocument
End Class
