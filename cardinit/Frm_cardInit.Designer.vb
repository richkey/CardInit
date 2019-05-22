<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cardInit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cardInit))
        Me.But_Stop = New System.Windows.Forms.Button()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_CompanyName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_CardCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_msgbox = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_statusImage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_CardSetup = New System.Windows.Forms.Panel()
        Me.Radio_ReadCard = New System.Windows.Forms.RadioButton()
        Me.Radio_FormatCard = New System.Windows.Forms.RadioButton()
        Me.Panel_saveData = New System.Windows.Forms.Panel()
        Me.Radio_RetailCard = New System.Windows.Forms.RadioButton()
        Me.Radio_SaveClubCard = New System.Windows.Forms.RadioButton()
        Me.Timer_FormatCard = New System.Windows.Forms.Timer(Me.components)
        Me.Label_msgBox = New System.Windows.Forms.Label()
        Me.ListBox_CardUID = New System.Windows.Forms.ListBox()
        Me.Timer_readCardNo = New System.Windows.Forms.Timer(Me.components)
        Me.Button_ClearListData = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_CardSetup.SuspendLayout()
        Me.Panel_saveData.SuspendLayout()
        Me.SuspendLayout()
        '
        'But_Stop
        '
        Me.But_Stop.Location = New System.Drawing.Point(581, 453)
        Me.But_Stop.Name = "But_Stop"
        Me.But_Stop.Size = New System.Drawing.Size(191, 34)
        Me.But_Stop.TabIndex = 0
        Me.But_Stop.Text = "停止(&S)"
        Me.But_Stop.UseVisualStyleBackColor = True
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(581, 364)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(191, 42)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "启动(&R)"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Tool_CompanyName, Me.ToolStripStatusLabel2, Me.Tool_CardCount, Me.Tool_msgbox, Me.Tool_statusImage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(779, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "区域名称："
        '
        'Tool_CompanyName
        '
        Me.Tool_CompanyName.AutoSize = False
        Me.Tool_CompanyName.Name = "Tool_CompanyName"
        Me.Tool_CompanyName.Size = New System.Drawing.Size(180, 17)
        Me.Tool_CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel2.Text = "IC卡数量："
        '
        'Tool_CardCount
        '
        Me.Tool_CardCount.AutoSize = False
        Me.Tool_CardCount.ForeColor = System.Drawing.Color.Blue
        Me.Tool_CardCount.Name = "Tool_CardCount"
        Me.Tool_CardCount.Size = New System.Drawing.Size(60, 17)
        Me.Tool_CardCount.Text = "0"
        '
        'Tool_msgbox
        '
        Me.Tool_msgbox.Name = "Tool_msgbox"
        Me.Tool_msgbox.Size = New System.Drawing.Size(0, 17)
        '
        'Tool_statusImage
        '
        Me.Tool_statusImage.Image = CType(resources.GetObject("Tool_statusImage.Image"), System.Drawing.Image)
        Me.Tool_statusImage.Name = "Tool_statusImage"
        Me.Tool_statusImage.Size = New System.Drawing.Size(48, 17)
        Me.Tool_statusImage.Text = "状态"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(282, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(490, 346)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel_CardSetup
        '
        Me.Panel_CardSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_CardSetup.Controls.Add(Me.Radio_ReadCard)
        Me.Panel_CardSetup.Controls.Add(Me.Radio_FormatCard)
        Me.Panel_CardSetup.Location = New System.Drawing.Point(282, 366)
        Me.Panel_CardSetup.Name = "Panel_CardSetup"
        Me.Panel_CardSetup.Size = New System.Drawing.Size(282, 53)
        Me.Panel_CardSetup.TabIndex = 5
        '
        'Radio_ReadCard
        '
        Me.Radio_ReadCard.AutoSize = True
        Me.Radio_ReadCard.BackColor = System.Drawing.Color.Transparent
        Me.Radio_ReadCard.ForeColor = System.Drawing.Color.Green
        Me.Radio_ReadCard.Location = New System.Drawing.Point(159, 17)
        Me.Radio_ReadCard.Name = "Radio_ReadCard"
        Me.Radio_ReadCard.Size = New System.Drawing.Size(77, 16)
        Me.Radio_ReadCard.TabIndex = 1
        Me.Radio_ReadCard.Text = "读取UID码"
        Me.Radio_ReadCard.UseVisualStyleBackColor = False
        '
        'Radio_FormatCard
        '
        Me.Radio_FormatCard.AutoSize = True
        Me.Radio_FormatCard.Checked = True
        Me.Radio_FormatCard.ForeColor = System.Drawing.Color.Blue
        Me.Radio_FormatCard.Location = New System.Drawing.Point(14, 17)
        Me.Radio_FormatCard.Name = "Radio_FormatCard"
        Me.Radio_FormatCard.Size = New System.Drawing.Size(83, 16)
        Me.Radio_FormatCard.TabIndex = 1
        Me.Radio_FormatCard.TabStop = True
        Me.Radio_FormatCard.Text = "格式化IC卡"
        Me.Radio_FormatCard.UseVisualStyleBackColor = True
        '
        'Panel_saveData
        '
        Me.Panel_saveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_saveData.Controls.Add(Me.Radio_RetailCard)
        Me.Panel_saveData.Controls.Add(Me.Radio_SaveClubCard)
        Me.Panel_saveData.Location = New System.Drawing.Point(282, 435)
        Me.Panel_saveData.Name = "Panel_saveData"
        Me.Panel_saveData.Size = New System.Drawing.Size(282, 53)
        Me.Panel_saveData.TabIndex = 6
        '
        'Radio_RetailCard
        '
        Me.Radio_RetailCard.AutoSize = True
        Me.Radio_RetailCard.Location = New System.Drawing.Point(159, 18)
        Me.Radio_RetailCard.Name = "Radio_RetailCard"
        Me.Radio_RetailCard.Size = New System.Drawing.Size(95, 16)
        Me.Radio_RetailCard.TabIndex = 0
        Me.Radio_RetailCard.TabStop = True
        Me.Radio_RetailCard.Text = "存入零售卡库"
        Me.Radio_RetailCard.UseVisualStyleBackColor = True
        '
        'Radio_SaveClubCard
        '
        Me.Radio_SaveClubCard.AutoSize = True
        Me.Radio_SaveClubCard.Location = New System.Drawing.Point(14, 18)
        Me.Radio_SaveClubCard.Name = "Radio_SaveClubCard"
        Me.Radio_SaveClubCard.Size = New System.Drawing.Size(95, 16)
        Me.Radio_SaveClubCard.TabIndex = 0
        Me.Radio_SaveClubCard.TabStop = True
        Me.Radio_SaveClubCard.Text = "存入会员卡库"
        Me.Radio_SaveClubCard.UseVisualStyleBackColor = True
        '
        'Timer_FormatCard
        '
        Me.Timer_FormatCard.Interval = 500
        '
        'Label_msgBox
        '
        Me.Label_msgBox.BackColor = System.Drawing.Color.Transparent
        Me.Label_msgBox.Location = New System.Drawing.Point(502, 9)
        Me.Label_msgBox.Name = "Label_msgBox"
        Me.Label_msgBox.Size = New System.Drawing.Size(270, 23)
        Me.Label_msgBox.TabIndex = 7
        '
        'ListBox_CardUID
        '
        Me.ListBox_CardUID.FormattingEnabled = True
        Me.ListBox_CardUID.ItemHeight = 12
        Me.ListBox_CardUID.Location = New System.Drawing.Point(12, 6)
        Me.ListBox_CardUID.Name = "ListBox_CardUID"
        Me.ListBox_CardUID.Size = New System.Drawing.Size(260, 484)
        Me.ListBox_CardUID.TabIndex = 8
        '
        'Timer_readCardNo
        '
        Me.Timer_readCardNo.Interval = 500
        '
        'Button_ClearListData
        '
        Me.Button_ClearListData.Location = New System.Drawing.Point(581, 413)
        Me.Button_ClearListData.Name = "Button_ClearListData"
        Me.Button_ClearListData.Size = New System.Drawing.Size(191, 34)
        Me.Button_ClearListData.TabIndex = 0
        Me.Button_ClearListData.Text = "清除列表(&C)"
        Me.Button_ClearListData.UseVisualStyleBackColor = True
        '
        'Frm_cardInit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 526)
        Me.Controls.Add(Me.ListBox_CardUID)
        Me.Controls.Add(Me.Label_msgBox)
        Me.Controls.Add(Me.Panel_saveData)
        Me.Controls.Add(Me.Panel_CardSetup)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_ClearListData)
        Me.Controls.Add(Me.But_Stop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_cardInit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IC卡企业化工具"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_CardSetup.ResumeLayout(False)
        Me.Panel_CardSetup.PerformLayout()
        Me.Panel_saveData.ResumeLayout(False)
        Me.Panel_saveData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_Stop As System.Windows.Forms.Button
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tool_CompanyName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tool_CardCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_CardSetup As System.Windows.Forms.Panel
    Friend WithEvents Panel_saveData As System.Windows.Forms.Panel
    Friend WithEvents Radio_ReadCard As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_FormatCard As System.Windows.Forms.RadioButton
    Friend WithEvents Timer_FormatCard As System.Windows.Forms.Timer
    Friend WithEvents Tool_msgbox As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Radio_RetailCard As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_SaveClubCard As System.Windows.Forms.RadioButton
    Friend WithEvents Label_msgBox As System.Windows.Forms.Label
    Friend WithEvents ListBox_CardUID As System.Windows.Forms.ListBox
    Friend WithEvents Timer_readCardNo As System.Windows.Forms.Timer
    Friend WithEvents Button_ClearListData As System.Windows.Forms.Button
    Friend WithEvents Tool_statusImage As System.Windows.Forms.ToolStripStatusLabel

End Class
