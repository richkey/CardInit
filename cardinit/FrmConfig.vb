Imports System.IO.Ports.SerialPort
Imports System.IO.File
Public Class FrmConfig
    Public Function GetAvaliableSerialPorts() As String() '获取串口号
        Dim portNames() As String = IO.Ports.SerialPort.GetPortNames()
        Array.Sort(portNames)
        Cmb_MainboardPort.Items.AddRange(portNames)
        Cmb_RetailPort.Items.AddRange(portNames)
        Cmb_ClubPort.Items.AddRange(portNames)
        Return portNames
    End Function

    Dim AddresName As String = "九龙广场店"
    Private Sub But_Quit_Click(sender As Object, e As EventArgs) Handles But_Quit.Click
        Me.Close()
    End Sub
    Private Sub LoadConfig()
        Dim LoadConfigRs As DataTable = DbOperation.DBOperate("SELECT * FROM DoorName WHERE 场地名称='" + AddresName + "'")
        If LoadConfigRs.Rows.Count > 0 Then
            LstDoorName.Items.Clear()
            For i = 0 To LoadConfigRs.Rows.Count - 1
                LstDoorName.Items.Add(LoadConfigRs.Rows(i)("门禁机名称"))
            Next
        End If
    End Sub
    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConfig()
        GetAvaliableSerialPorts()

    End Sub
  
    Private Sub LstDoorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstDoorName.SelectedIndexChanged
        Dim DoorNameStr As String
        DoorNameStr = LstDoorName.SelectedItem.ToString

        Dim DoorNameRs As DataTable = DbOperation.DBOperate("SELECT * FROM PortSetup WHERE 场地名称='" + AddresName + "' and 门禁机名称='" + DoorNameStr + "'")
        If DoorNameRs.Rows.Count > 0 Then
            But_Save.Text = "修改(&E)"
            Txt_DoorNumber.Text = DoorNameRs.Rows(0)("门禁编号").ToString
            Txt_DoorName.Text = DoorNameRs.Rows(0)("门禁机名称").ToString
            Cmb_MainboardPort.Text = DoorNameRs.Rows(0)("主控板端口").ToString
            Cmb_RetailPort.Text = DoorNameRs.Rows(0)("散客读卡端口").ToString
            Cmb_ClubPort.Text = DoorNameRs.Rows(0)("会员读卡端口").ToString
            Chk_Enabled.Checked = DoorNameRs.Rows(0)("是否启用")
        Else
            But_Save.Text = "保存(&S)"
            Txt_DoorNumber.Text = ""
            Txt_DoorName.Text = DoorNameStr
            Cmb_MainboardPort.Text = ""
            Cmb_RetailPort.Text = ""
            Cmb_ClubPort.Text = ""
            Chk_Enabled.Checked = False
        End If
    End Sub
    Private Sub SavePortsSetup()
        Dim EnabledBol As String = Chk_Enabled.Checked
        If But_Save.Text = "保存(&S)" Then
            Dim SavePortSetupStr As String = "INSERT INTO V_PortSetup(门禁编号,门禁机名称,主控板端口,散客读卡端口,会员读卡端口,是否启用,场地名称)VALUES(" & _
                "'" + Txt_DoorNumber.Text.Trim + "','" + Txt_DoorName.Text.Trim + "','" + Cmb_MainboardPort.Text.Trim + "','" + Cmb_RetailPort.Text.Trim + "','" + Cmb_ClubPort.Text.Trim + "'," & _
                "'" + EnabledBol + "','" + AddresName + "')"
            DbOperation.DBOperate(SavePortSetupStr)
        ElseIf But_Save.Text = "修改(&E)" Then

            Dim EditPortSetupStr As String = "UPDATE V_PortSetup SET 门禁编号='" + Txt_DoorNumber.Text.Trim + "',门禁机名称='" + Txt_DoorName.Text.Trim + "'," & _
                "主控板端口='" + Cmb_MainboardPort.Text.Trim + "',散客读卡端口='" + Cmb_RetailPort.Text.Trim + "',会员读卡端口='" + Cmb_ClubPort.Text.Trim + "',是否启用='" + EnabledBol + "'"
            DbOperation.DBOperate(EditPortSetupStr)
        End If
    End Sub

    Private Sub But_Save_Click(sender As Object, e As EventArgs) Handles But_Save.Click
        SavePortsSetup()
    End Sub
End Class