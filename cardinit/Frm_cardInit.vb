Imports System.IO.Ports

Public Class Frm_cardInit
    Dim saveFlag As Integer
    Dim checkCardNo As String
    Dim logStr As String = ""
    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        If Radio_FormatCard.Checked = True Then
            Timer_FormatCard.Enabled = True
            Timer_readCardNo.Enabled = False
        End If
        If Radio_ReadCard.Checked = True Then
            Timer_readCardNo.Enabled = True
            Timer_FormatCard.Enabled = False
        End If

    End Sub
    Private Sub readCardNoSave() '读卡并存入数据库
        Timer_readCardNo.Enabled = False
        Dim cardNo As String = GetCardNo() '获取UID
        If cardNo = "" Then                 '检查是否读卡成功
            Timer_readCardNo.Enabled = True
            Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led_Green.png")
            Exit Sub
        End If

        If checkCardNo = cardNo Then       '检查读卡器上的UID码是否重复
            Tool_msgbox.Text = "IC卡重复，请不要重复读取！"
            Timer_readCardNo.Enabled = True
            Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led_Green.png")
            Timer_readCardNo.Enabled = True
            Exit Sub
        End If
        Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led.png")

        Dim checkByCradNoStr As String = "SELECT * FROM CardUIDInfo WHERE  UID='" & cardNo & "'"
        Dim saveSql As String = "INSERT INTO CardUIDInfo(UID)VALUES ('" & cardNo & "')"
        If saveFlag = 1 Then
            checkByCradNoStr = "SELECT * FROM BarCodeInBank WHERE  UID编号='" & cardNo & "'"
            saveSql = "INSERT INTO BarCodeInBank(UID编号)VALUES ('" & cardNo & "')"
        End If
        Dim checkByCardRs As DataTable = DbOperation.DBOperate(checkByCradNoStr)  '检测数据表中是否有重复UID
        If checkByCardRs.Rows.Count > 0 Then
            Tool_msgbox.Text = "此卡已在数据表中，请不要重复操作！"
            Tool_msgbox.BackColor = Color.Red
            Timer_readCardNo.Enabled = True
            Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led_Green.png")
            Timer_readCardNo.Enabled = True
            Exit Sub
        End If
        DbOperation.DBOperate(saveSql)    '存入数据表
        checkCardNo = cardNo
        Timer_readCardNo.Enabled = True
        ListBox_CardUID.Items.Add(cardNo)
        Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led_Green.png")
        Tool_CardCount.Text = ListBox_CardUID.Items.Count
    End Sub


    '---------------格式化IC卡并存入数据库-------------------------
    Private Sub CardFormatInit()
        Timer_FormatCard.Enabled = False
        Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led_Green.png")
        Dim cardNo As String = GetCardNo() '获取UID

        If cardNo = "" Then                 '检查是否读卡成功
            Timer_FormatCard.Enabled = True
            Tool_msgbox.Text = "读卡程序准备就绪！"
            Exit Sub
        End If

        If checkCardNo = cardNo Then       '检查读卡器上的UID码是否重复
            Tool_msgbox.Text = "数据卡重复，请不要重复读取！"
            Timer_FormatCard.Enabled = True
            Exit Sub
        End If
        Tool_statusImage.Image = Image.FromFile(Application.StartupPath & "\led.png")

        Dim checkByCradNoStr As String = "SELECT * FROM CardUIDInfo WHERE  UID='" & cardNo & "'"
        Dim saveSql As String = "INSERT INTO CardUIDInfo(UID)VALUES ('" & cardNo & "')"
        If saveFlag = 1 Then
            checkByCradNoStr = "SELECT * FROM BarCodeInBank WHERE  UID编号='" & cardNo & "'"
            saveSql = "INSERT INTO BarCodeInBank(UID编号)VALUES ('" & cardNo & "')"
        End If
        Dim checkByCardRs As DataTable = DbOperation.DBOperate(checkByCradNoStr)  '检测数据表中是否有重复UID
        If checkByCardRs.Rows.Count > 0 Then
            Timer_FormatCard.Enabled = True
            Exit Sub
        End If


        '--------------加载原始密钥-----------------------------

        ws_openPort(Port)
        Dim LoadkeyStr As String = "FFFFFFFFFFFF"
        ws_loadKey_Hex(Port, LoadkeyStr, 0)

        Dim dataA As String = "013002300897"
        Dim dataB As String = "FF078069"
        Dim dataC As String = "013983830690"
        '---------------写入4，5 ，6数据块---------------------

        Dim data55 As String = "55000000000000000000000000000000"
        For w = 4 To 6
            ws_writeBlock_Hex(Port, w, data55)
        Next
        '---------------写入8数据块------------------------------
        Dim data13983830690 = "01398383069000000000000000000000"
        ws_writeBlock_Hex(Port, 8, data13983830690)
        '---------------写入密钥数据块--------------------------
        Dim Data32 As String = dataA & dataB & dataC
        For i = 3 To 63 Step 4
            Ret = ws_writeBlock_Hex(Port, i, Data32)
        Next i
        '------------存入数据库----------------------------------
        DbOperation.DBOperate(saveSql)    '存入数据表
        checkCardNo = cardNo
        Timer_FormatCard.Enabled = True
        ListBox_CardUID.Items.Add(cardNo)
        Tool_CardCount.Text = ListBox_CardUID.Items.Count

    End Sub

    Private Sub Radio_SaveClubCard_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_SaveClubCard.CheckedChanged, Radio_RetailCard.CheckedChanged
        If Radio_SaveClubCard.Checked = True Then
            Tool_msgbox.Text = "自动写入到《会员卡库》"
            logStr = "'" + Me.Text + "','存入会员卡！'"
            record_Oplog(logStr)
            saveFlag = 0
        End If
        If Radio_RetailCard.Checked = True Then
            Tool_msgbox.Text = "自动写入到《零售卡库》"
            logStr = "'" + Me.Text + "','存入零售卡！'"
            record_Oplog(logStr)
            saveFlag = 1
        End If
        Button_Start.Enabled = True
    End Sub
    Private Sub Frm_cardInit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tool_CompanyName.Text = AddresName
        Tool_userName.Text = User_Name.Trim
        logStr = "'" + Me.Text + "','企业化IC卡进入成功！'"
        record_Oplog(logStr)
        PortNames()
    End Sub


    Private Sub But_Stop_Click(sender As Object, e As EventArgs) Handles But_Stop.Click
        Tool_msgbox.Text = ""
        Timer_FormatCard.Enabled = False
        Timer_readCardNo.Enabled = False
    End Sub

    Private Sub Timer_Start_Tick(sender As Object, e As EventArgs) Handles Timer_FormatCard.Tick
        CardFormatInit()
    End Sub

    Private Sub Timer_readCardNo_Tick(sender As Object, e As EventArgs) Handles Timer_readCardNo.Tick
        readCardNoSave()
    End Sub

    Private Sub Button_ClearListData_Click(sender As Object, e As EventArgs) Handles Button_ClearListData.Click
        ListBox_CardUID.Items.Clear()
        Tool_CardCount.Text = 0
        Tool_msgbox.Text = ""
        Timer_FormatCard.Enabled = False
        Timer_readCardNo.Enabled = False
    End Sub
    Private Sub PortNames()
        Combo_PortName.Items.Add("HID")
        For Each s As String In SerialPort.GetPortNames()
            Combo_PortName.Items.Add(s)
        Next
        Combo_PortName.SelectedIndex = 0
    End Sub
 
    Private Sub Combo_PortName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_PortName.SelectedIndexChanged
        Dim comName As String = Combo_PortName.Text
        If comName.Length > 3 Then
            Port = CInt(comName.Substring(3, 1))
        Else
            Port = 0
        End If

    End Sub


   
    Private Sub Button_TelTest_Click(sender As Object, e As EventArgs) Handles Button_TelTest.Click
        checkCom()
    End Sub

    Private Sub Tool_userName_Click(sender As Object, e As EventArgs) Handles Tool_userName.Click
        If Authority <> "A" Then
            MsgBox("权限不足，如需要调整用户信息，请通知系统管理员！", MsgBoxStyle.OkOnly, "错误提示")
            logStr = "'" + Me.Text + "','打开用户信息管理因权限不足而失败！'"
            record_Oplog(logStr)
            Exit Sub
        Else
            logStr = "'" + Me.Text + "','打开用户信息管理成功！'"
            record_Oplog(logStr)
            workerSetting.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Tool_oplog_Click(sender As Object, e As EventArgs) Handles Tool_oplog.Click
        If Authority <> "A" Then
            MsgBox("权限不足，操作日志须要系统管理权限！", MsgBoxStyle.OkOnly, "错误提示")
            logStr = "'" + Me.Text + "','打开操作日志因权限不足而失败！'"
            record_Oplog(logStr)
            Exit Sub
        Else
            logStr = "'" + Me.Text + "','打开操作日志成功！'"
            record_Oplog(logStr)
            Form_Oplog.Show()
            Me.Close()
        End If
    End Sub
End Class
