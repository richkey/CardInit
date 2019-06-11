<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox_addresName = New System.Windows.Forms.ComboBox()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_userName = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox_addresName)
        Me.Panel1.Controls.Add(Me.Button_Quit)
        Me.Panel1.Controls.Add(Me.Button_Enter)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox_password)
        Me.Panel1.Controls.Add(Me.TextBox_userName)
        Me.Panel1.Location = New System.Drawing.Point(99, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 244)
        Me.Panel1.TabIndex = 3
        '
        'ComboBox_addresName
        '
        Me.ComboBox_addresName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_addresName.FormattingEnabled = True
        Me.ComboBox_addresName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ComboBox_addresName.Items.AddRange(New Object() {"九龙店", "中交店"})
        Me.ComboBox_addresName.Location = New System.Drawing.Point(105, 27)
        Me.ComboBox_addresName.Name = "ComboBox_addresName"
        Me.ComboBox_addresName.Size = New System.Drawing.Size(220, 20)
        Me.ComboBox_addresName.TabIndex = 0
        '
        'Button_Quit
        '
        Me.Button_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Quit.Location = New System.Drawing.Point(233, 186)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Quit.TabIndex = 4
        Me.Button_Quit.Text = "退出 (&Q)"
        Me.Button_Quit.UseVisualStyleBackColor = True
        '
        'Button_Enter
        '
        Me.Button_Enter.Enabled = False
        Me.Button_Enter.Location = New System.Drawing.Point(52, 186)
        Me.Button_Enter.Name = "Button_Enter"
        Me.Button_Enter.Size = New System.Drawing.Size(75, 23)
        Me.Button_Enter.TabIndex = 3
        Me.Button_Enter.Text = "登录(&E)"
        Me.Button_Enter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "登录密码："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "选择区域："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "登录帐号："
        '
        'TextBox_password
        '
        Me.TextBox_password.Enabled = False
        Me.TextBox_password.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox_password.Location = New System.Drawing.Point(104, 130)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_password.Size = New System.Drawing.Size(221, 21)
        Me.TextBox_password.TabIndex = 2
        '
        'TextBox_userName
        '
        Me.TextBox_userName.Enabled = False
        Me.TextBox_userName.Location = New System.Drawing.Point(104, 84)
        Me.TextBox_userName.Name = "TextBox_userName"
        Me.TextBox_userName.Size = New System.Drawing.Size(221, 21)
        Me.TextBox_userName.TabIndex = 1
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.Button_Enter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_Quit
        Me.ClientSize = New System.Drawing.Size(552, 306)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统登录"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_addresName As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Quit As System.Windows.Forms.Button
    Friend WithEvents Button_Enter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_userName As System.Windows.Forms.TextBox
End Class
