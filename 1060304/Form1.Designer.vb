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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(456, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 95)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "第四題"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_4
        '
        Me.txt_4.Location = New System.Drawing.Point(294, 265)
        Me.txt_4.Multiline = True
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(580, 286)
        Me.txt_4.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 738)
        Me.Controls.Add(Me.txt_4)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents txt_4 As TextBox
End Class