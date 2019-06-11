<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Oplog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Oplog))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_UserName = New System.Windows.Forms.ComboBox()
        Me.Cmb_FormName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPicker_Start = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker_End = New System.Windows.Forms.DateTimePicker()
        Me.But_DateQuery = New System.Windows.Forms.Button()
        Me.Text_Keyword = New System.Windows.Forms.TextBox()
        Me.But_keywordQuery = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(769, 576)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.But_keywordQuery)
        Me.Panel1.Controls.Add(Me.Text_Keyword)
        Me.Panel1.Controls.Add(Me.DTPicker_End)
        Me.Panel1.Controls.Add(Me.DTPicker_Start)
        Me.Panel1.Controls.Add(Me.But_DateQuery)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cmb_FormName)
        Me.Panel1.Controls.Add(Me.Cmb_UserName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 74)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "登录人员："
        '
        'Cmb_UserName
        '
        Me.Cmb_UserName.FormattingEnabled = True
        Me.Cmb_UserName.Location = New System.Drawing.Point(73, 12)
        Me.Cmb_UserName.Name = "Cmb_UserName"
        Me.Cmb_UserName.Size = New System.Drawing.Size(121, 20)
        Me.Cmb_UserName.TabIndex = 3
        '
        'Cmb_FormName
        '
        Me.Cmb_FormName.FormattingEnabled = True
        Me.Cmb_FormName.Location = New System.Drawing.Point(73, 38)
        Me.Cmb_FormName.Name = "Cmb_FormName"
        Me.Cmb_FormName.Size = New System.Drawing.Size(121, 20)
        Me.Cmb_FormName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "操作功能："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "开始日期："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "结束日期："
        '
        'DTPicker_Start
        '
        Me.DTPicker_Start.Location = New System.Drawing.Point(306, 13)
        Me.DTPicker_Start.Name = "DTPicker_Start"
        Me.DTPicker_Start.Size = New System.Drawing.Size(122, 21)
        Me.DTPicker_Start.TabIndex = 6
        '
        'DTPicker_End
        '
        Me.DTPicker_End.Location = New System.Drawing.Point(305, 38)
        Me.DTPicker_End.Name = "DTPicker_End"
        Me.DTPicker_End.Size = New System.Drawing.Size(122, 21)
        Me.DTPicker_End.TabIndex = 6
        '
        'But_DateQuery
        '
        Me.But_DateQuery.Location = New System.Drawing.Point(433, 13)
        Me.But_DateQuery.Name = "But_DateQuery"
        Me.But_DateQuery.Size = New System.Drawing.Size(44, 46)
        Me.But_DateQuery.TabIndex = 5
        Me.But_DateQuery.Text = "查询"
        Me.But_DateQuery.UseVisualStyleBackColor = True
        '
        'Text_Keyword
        '
        Me.Text_Keyword.Location = New System.Drawing.Point(506, 26)
        Me.Text_Keyword.Name = "Text_Keyword"
        Me.Text_Keyword.Size = New System.Drawing.Size(166, 21)
        Me.Text_Keyword.TabIndex = 7
        '
        'But_keywordQuery
        '
        Me.But_keywordQuery.Location = New System.Drawing.Point(679, 26)
        Me.But_keywordQuery.Name = "But_keywordQuery"
        Me.But_keywordQuery.Size = New System.Drawing.Size(75, 23)
        Me.But_keywordQuery.TabIndex = 8
        Me.But_keywordQuery.Text = "关键字查询"
        Me.But_keywordQuery.UseVisualStyleBackColor = True
        '
        'Form_Oplog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Oplog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "操作日志"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_FormName As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_UserName As System.Windows.Forms.ComboBox
    Friend WithEvents DTPicker_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents But_keywordQuery As System.Windows.Forms.Button
    Friend WithEvents Text_Keyword As System.Windows.Forms.TextBox
    Friend WithEvents But_DateQuery As System.Windows.Forms.Button
End Class
