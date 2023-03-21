<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 覆寫 Dispose 以清除元件清單。
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(361, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(258, 128)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "第五題"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_5
        '
        Me.txt_5.Location = New System.Drawing.Point(189, 271)
        Me.txt_5.Multiline = True
        Me.txt_5.Name = "txt_5"
        Me.txt_5.Size = New System.Drawing.Size(614, 339)
        Me.txt_5.TabIndex = 1
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_5)
        Me.Controls.Add(Me.Button5)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(1041, 660)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents txt_5 As TextBox
End Class
