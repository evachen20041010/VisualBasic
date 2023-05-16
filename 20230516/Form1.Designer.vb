<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.txt_3 = New System.Windows.Forms.TextBox()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btn_1
        '
        Me.btn_1.Location = New System.Drawing.Point(160, 67)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(168, 58)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "第一題"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Location = New System.Drawing.Point(524, 67)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(168, 58)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "第二題"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Location = New System.Drawing.Point(936, 67)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(168, 58)
        Me.btn_3.TabIndex = 2
        Me.btn_3.Text = "第三題"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1291, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 58)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "列印答案"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(58, 183)
        Me.txt_1.Multiline = True
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(348, 555)
        Me.txt_1.TabIndex = 4
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(432, 183)
        Me.txt_2.Multiline = True
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(365, 555)
        Me.txt_2.TabIndex = 5
        '
        'txt_3
        '
        Me.txt_3.Location = New System.Drawing.Point(830, 183)
        Me.txt_3.Multiline = True
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(384, 555)
        Me.txt_3.TabIndex = 6
        '
        'pd
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 872)
        Me.Controls.Add(Me.txt_3)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txt_1 As TextBox
    Friend WithEvents txt_2 As TextBox
    Friend WithEvents txt_3 As TextBox
    Friend WithEvents pd As Printing.PrintDocument
End Class
