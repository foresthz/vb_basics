<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hello_gui
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_one = New System.Windows.Forms.Button()
        Me.cbox_fuquan = New System.Windows.Forms.CheckBox()
        Me.btn_open_url = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbox_url = New System.Windows.Forms.TextBox()
        Me.label_url = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_one
        '
        Me.btn_one.Location = New System.Drawing.Point(109, 301)
        Me.btn_one.Name = "btn_one"
        Me.btn_one.Size = New System.Drawing.Size(75, 23)
        Me.btn_one.TabIndex = 0
        Me.btn_one.Text = "vb按钮"
        Me.btn_one.UseVisualStyleBackColor = True
        '
        'cbox_fuquan
        '
        Me.cbox_fuquan.AutoSize = True
        Me.cbox_fuquan.Location = New System.Drawing.Point(26, 308)
        Me.cbox_fuquan.Name = "cbox_fuquan"
        Me.cbox_fuquan.Size = New System.Drawing.Size(48, 16)
        Me.cbox_fuquan.TabIndex = 1
        Me.cbox_fuquan.Text = "复权"
        Me.cbox_fuquan.UseVisualStyleBackColor = True
        '
        'btn_open_url
        '
        Me.btn_open_url.Location = New System.Drawing.Point(439, 181)
        Me.btn_open_url.Name = "btn_open_url"
        Me.btn_open_url.Size = New System.Drawing.Size(75, 23)
        Me.btn_open_url.TabIndex = 2
        Me.btn_open_url.Text = "打开网页"
        Me.btn_open_url.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbox_url
        '
        Me.tbox_url.Location = New System.Drawing.Point(157, 181)
        Me.tbox_url.Name = "tbox_url"
        Me.tbox_url.Size = New System.Drawing.Size(256, 21)
        Me.tbox_url.TabIndex = 4
        '
        'label_url
        '
        Me.label_url.AutoSize = True
        Me.label_url.Location = New System.Drawing.Point(70, 186)
        Me.label_url.Name = "label_url"
        Me.label_url.Size = New System.Drawing.Size(23, 12)
        Me.label_url.TabIndex = 5
        Me.label_url.Text = "url"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(326, 136)
        Me.ListBox1.TabIndex = 6
        '
        'hello_gui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 343)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.label_url)
        Me.Controls.Add(Me.tbox_url)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_open_url)
        Me.Controls.Add(Me.cbox_fuquan)
        Me.Controls.Add(Me.btn_one)
        Me.Name = "hello_gui"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_one As System.Windows.Forms.Button
    Friend WithEvents cbox_fuquan As System.Windows.Forms.CheckBox
    Friend WithEvents btn_open_url As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbox_url As System.Windows.Forms.TextBox
    Friend WithEvents label_url As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
