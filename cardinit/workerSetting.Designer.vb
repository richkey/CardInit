<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class workerSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(workerSetting))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Check_Status = New System.Windows.Forms.CheckBox()
        Me.Text_CheckPassword = New System.Windows.Forms.TextBox()
        Me.Text_Password = New System.Windows.Forms.TextBox()
        Me.Text_userName = New System.Windows.Forms.TextBox()
        Me.Text_operator = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmb_Authority = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_AddNew = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Save = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Enabled = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Disabled = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.Color.Chocolate
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DataGridView1.Location = New System.Drawing.Point(0, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(759, 374)
        Me.DataGridView1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Check_Status)
        Me.Panel1.Controls.Add(Me.Text_CheckPassword)
        Me.Panel1.Controls.Add(Me.Text_Password)
        Me.Panel1.Controls.Add(Me.Text_userName)
        Me.Panel1.Controls.Add(Me.Text_operator)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Cmb_Authority)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 94)
        Me.Panel1.TabIndex = 4
        '
        'Check_Status
        '
        Me.Check_Status.AutoSize = True
        Me.Check_Status.Location = New System.Drawing.Point(510, 61)
        Me.Check_Status.Name = "Check_Status"
        Me.Check_Status.Size = New System.Drawing.Size(156, 16)
        Me.Check_Status.TabIndex = 19
        Me.Check_Status.Text = "是否允许此用户登陆系统"
        Me.Check_Status.UseVisualStyleBackColor = True
        '
        'Text_CheckPassword
        '
        Me.Text_CheckPassword.Location = New System.Drawing.Point(332, 56)
        Me.Text_CheckPassword.Name = "Text_CheckPassword"
        Me.Text_CheckPassword.Size = New System.Drawing.Size(139, 21)
        Me.Text_CheckPassword.TabIndex = 16
        '
        'Text_Password
        '
        Me.Text_Password.Location = New System.Drawing.Point(331, 17)
        Me.Text_Password.Name = "Text_Password"
        Me.Text_Password.Size = New System.Drawing.Size(139, 21)
        Me.Text_Password.TabIndex = 16
        '
        'Text_userName
        '
        Me.Text_userName.Location = New System.Drawing.Point(93, 56)
        Me.Text_userName.Name = "Text_userName"
        Me.Text_userName.Size = New System.Drawing.Size(139, 21)
        Me.Text_userName.TabIndex = 17
        '
        'Text_operator
        '
        Me.Text_operator.Location = New System.Drawing.Point(93, 18)
        Me.Text_operator.Name = "Text_operator"
        Me.Text_operator.Size = New System.Drawing.Size(139, 21)
        Me.Text_operator.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(267, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "再次输入："
        '
        'Cmb_Authority
        '
        Me.Cmb_Authority.FormattingEnabled = True
        Me.Cmb_Authority.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.Cmb_Authority.Location = New System.Drawing.Point(569, 18)
        Me.Cmb_Authority.Name = "Cmb_Authority"
        Me.Cmb_Authority.Size = New System.Drawing.Size(128, 20)
        Me.Cmb_Authority.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(268, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "登录密码："
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(508, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "权限设置："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "职员姓名："
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "登录用户："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Location = New System.Drawing.Point(3, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 32)
        Me.Panel2.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_AddNew, Me.Tool_Delete, Me.Tool_Save, Me.Tool_Enabled, Me.Tool_Disabled})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(523, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_AddNew
        '
        Me.Tool_AddNew.Enabled = False
        Me.Tool_AddNew.Image = CType(resources.GetObject("Tool_AddNew.Image"), System.Drawing.Image)
        Me.Tool_AddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_AddNew.Name = "Tool_AddNew"
        Me.Tool_AddNew.Size = New System.Drawing.Size(68, 22)
        Me.Tool_AddNew.Text = "添加(&A)"
        '
        'Tool_Delete
        '
        Me.Tool_Delete.Enabled = False
        Me.Tool_Delete.Image = CType(resources.GetObject("Tool_Delete.Image"), System.Drawing.Image)
        Me.Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Delete.Name = "Tool_Delete"
        Me.Tool_Delete.Size = New System.Drawing.Size(85, 22)
        Me.Tool_Delete.Text = "删除（&D）"
        '
        'Tool_Save
        '
        Me.Tool_Save.Enabled = False
        Me.Tool_Save.Image = CType(resources.GetObject("Tool_Save.Image"), System.Drawing.Image)
        Me.Tool_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Save.Name = "Tool_Save"
        Me.Tool_Save.Size = New System.Drawing.Size(67, 22)
        Me.Tool_Save.Text = "保存(&S)"
        '
        'Tool_Enabled
        '
        Me.Tool_Enabled.Enabled = False
        Me.Tool_Enabled.Image = CType(resources.GetObject("Tool_Enabled.Image"), System.Drawing.Image)
        Me.Tool_Enabled.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Enabled.Name = "Tool_Enabled"
        Me.Tool_Enabled.Size = New System.Drawing.Size(148, 22)
        Me.Tool_Enabled.Text = "授权此电脑为本机专用"
        '
        'Tool_Disabled
        '
        Me.Tool_Disabled.Enabled = False
        Me.Tool_Disabled.Image = CType(resources.GetObject("Tool_Disabled.Image"), System.Drawing.Image)
        Me.Tool_Disabled.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Disabled.Name = "Tool_Disabled"
        Me.Tool_Disabled.Size = New System.Drawing.Size(112, 22)
        Me.Tool_Disabled.Text = "禁止计算机登录"
        '
        'workerSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 517)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "workerSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Check_Status As System.Windows.Forms.CheckBox
    Friend WithEvents Text_Password As System.Windows.Forms.TextBox
    Friend WithEvents Text_userName As System.Windows.Forms.TextBox
    Friend WithEvents Text_operator As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Authority As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_AddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents Text_CheckPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tool_Enabled As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Disabled As System.Windows.Forms.ToolStripButton
End Class
