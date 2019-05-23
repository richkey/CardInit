Module WSR


    Public Ret As Integer
    Public Port As Integer = 0
    Public URL As String = "richkey.3322.org"
    Public AddresName As String
    Public CardNo As Double
    Public CardNumber As Double
    ' 默认刷卡监控消息
    Private Const GWL_WNDPROC = -4
    Public Const GWL_USERDATA = (-21)
    Public Const WM_USER = &H400
    Public Const MSG_GETCARDNO = WM_USER + 1000
    '-------------------------------------------------------------------------------------------------
    ' 与端口通讯相关函数
    '-------------------------------------------------------------------------------------------------
    '打开端口
    Public Declare Function ws_openPort Lib "WSR.dll" (ByVal Port As Integer) As Integer
    '关闭端口
    Public Declare Function ws_closePort Lib "WSR.dll" (ByVal Port As Integer) As Integer
    '设置端口波特率
    Public Declare Sub ws_setBaud Lib "WSR.dll" (ByVal Port As Integer, ByVal Baud As Integer)
    '-------------------------------------------------------------------------------------------------
    ' 设备操作函数
    '-------------------------------------------------------------------------------------------------
    '点名
    Public Declare Function ws_callDevice Lib "WSR.dll" (ByVal Port As Integer) As Integer
    Public Declare Function ws_callDevice1 Lib "WSR.dll" (ByVal Port As Integer, ByVal Model As String, ByRef CPUType As Integer, ByRef Version As Double) As Integer
    '设置当前操作的设备机号
    Public Declare Sub ws_setNumber Lib "WSR.dll" (ByVal Port As Integer, ByVal Number As Integer)
    '蜂鸣
    Public Declare Function ws_beep Lib "WSR.dll" (ByVal Port As Integer) As Integer
    '-------------------------------------------------------------------------------------------------
    ' Mifare卡基本操作函数
    '-------------------------------------------------------------------------------------------------
    '取卡号
    Public Declare Function ws_getCardNo_DWORD Lib "WSR.dll" (ByVal Port As Integer, ByRef CardNo As UInteger) As Integer
    Public Declare Function ws_getCardNo_Double Lib "WSR.dll" (ByVal Port As Integer, ByRef CardNo As Double) As Integer
    Public Declare Function ws_getCardNo_String Lib "WSR.dll" (ByVal Port As Integer, ByVal CardNo As String) As Integer
    Public Declare Function ws_getCardNo_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal CardNo As String) As Integer
    Public Declare Function ws_getCardNo_Char Lib "WSR.dll" (ByVal Port As Integer, ByRef CardNo As Byte) As Integer
    '设置卡序列号的顺序 0-默认卡号  1-反转卡号
    Public Declare Function ws_set_mode_cardseq Lib "WSR.dll" (ByVal seq As Integer) As Integer
    '---------------- 刷卡监控 -------------------------------------------
    '开始监控
    Public Declare Sub ws_monitor_begin Lib "WSR.dll" (ByVal Port As Integer, ByVal Handle As Integer)
    '停止监控
    Public Declare Sub ws_monitor_end Lib "WSR.dll" ()
    '获取监控状态
    Public Declare Function ws_monitor_getstatus Lib "WSR.dll" () As Integer
    '设置刷卡监控消息值
    Public Declare Sub ws_monitor_setmessage Lib "WSR.dll" (ByVal message As Integer)
    '----------------以Char字符串方式操作-------------------------------------------
    '装载密码
    Public Declare Function ws_loadKey Lib "WSR.dll" (ByVal Port As Integer, ByRef Key As Byte, ByVal KeyType As Integer) As Integer
    '读块数据
    Public Declare Function ws_readBlock Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByRef Data As Byte) As Integer
    Public Declare Function ws_readData Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByRef Data As Byte, ByVal Length As Integer) As Integer
    '写块数据
    Public Declare Function ws_writeBlock Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByRef Data As Byte) As Integer
    Public Declare Function ws_writeData Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByRef Data As Byte, ByVal Length As Integer) As Integer
    '修改密码
    Public Declare Function ws_changeKey Lib "WSR.dll" (ByVal Port As Integer, ByVal Sector As Integer, ByRef NewKeyA As Byte, ByRef NewAC As Byte, ByRef NewKeyB As Byte) As Integer
    '----------------以Hex字符串方式操作-------------------------------------------
    '装载密码
    Public Declare Function ws_loadKey_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Key As String, ByVal KeyType As Integer) As Integer
    '读块数据
    Public Declare Function ws_readBlock_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Data As String) As Integer
    Public Declare Function ws_readData_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Data As String) As Integer
    '写块数据
    Public Declare Function ws_writeBlock_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Data As String) As Integer
    Public Declare Function ws_writeData_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Data As String) As Integer
    '修改密码
    Public Declare Function ws_changeKey_Hex Lib "WSR.dll" (ByVal Port As Integer, ByVal Sector As Integer, ByVal NewKeyA As String, ByVal NewAC As String, ByVal NewKeyB As String) As Integer
    '-------------------------------------------------------------------------------------------------
    ' 增减值
    '-------------------------------------------------------------------------------------------------
    '初始化值
    Public Declare Function ws_initValue Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Value As Integer) As Integer
    '读值
    Public Declare Function ws_readValue Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByRef Value As Integer) As Integer
    '增值
    Public Declare Function ws_incValue Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Value As Integer) As Integer
    '减值
    Public Declare Function ws_decValue Lib "WSR.dll" (ByVal Port As Integer, ByVal Block As Integer, ByVal Value As Integer) As Integer
    '-------------------------------------------------------------------------------------------------
    ' 液晶显示
    '-------------------------------------------------------------------------------------------------
    '清屏
    Public Declare Function ws_clearText Lib "WSR.dll" (ByVal Port As Integer) As Integer
    '显示文本
    Public Declare Function ws_displayText Lib "WSR.dll" (ByVal Port As Integer, ByVal LineNo As Integer, ByVal Length As Integer, ByVal Text As String) As Integer
    '-------------------------------------------------------------------------------------------------
    ' 辅助函数
    '-------------------------------------------------------------------------------------------------
    '计算扇区块对应的物理块号
    Public Declare Function ws_getBlock Lib "WSR.dll" (ByVal Sector As Integer, ByVal SecotrBlock As Integer) As Integer
    '计算扇区密码区对应的物理块号
    Public Declare Function ws_getKeyBlock Lib "WSR.dll" (ByVal Sector As Integer) As Integer
    '转换函数 Hex->Char
    Public Declare Sub ws_strHexToChar Lib "WSR.dll" (ByRef StrHexValue As Byte, ByVal iLen As Integer, ByRef CharValue As Byte)
    '转换函数 Char->Hex
    Public Declare Sub ws_charToStrHex Lib "WSR.dll" (ByRef CharValue As Byte, ByVal iLen As Integer, ByRef StrHexValue As Byte)
    '-------------------------------------------------------------------------------------------------
    ' 动态库相关信息函数
    '-------------------------------------------------------------------------------------------------
    Public Declare Sub ws_getDLLInfo Lib "WSR.dll" (ByRef Version As Double, ByRef BuildDate As Double)

    Public Function GetCardNo() As String
        ws_openPort(Port)
        Ret = ws_getCardNo_Double(Port, CardNumber)
        If Ret < 0 Then
            'MessageBox.Show("没有读到IC卡，请检查IC是否在读卡器上，或IC卡损坏！")
            GetCardNo = ""
            ws_closePort(Port)
            Exit Function
        End If
        GetCardNo = CardNumber
        ws_beep(Port)
        ws_closePort(Port)
    End Function
    Public Sub WriteCard(ByVal Falg As Integer, ByVal CardData As String) '写入数据
        Dim WriteDataStr As String = CardData
        ws_openPort(Port)
        Falg += 4
        ws_loadKey_Hex(Port, "013002300897", 0)
        Ret = ws_writeBlock_Hex(Port, Falg, WriteDataStr)
        ws_beep(Port)
        ws_closePort(Port)
    End Sub
    Public Function ReadCard(ByVal Falg As Integer) As String '读取取数据

        If CheckCardBln() = False Then Return ""
        Dim ReadCardStr As String = "                                        "
        ws_openPort(Port)
        Falg += 4
        ws_loadKey_Hex(Port, "013002300897", 0)
        Ret = ws_readBlock_Hex(Port, Falg, ReadCardStr)
        ws_beep(Port)
        ws_closePort(Port)
        ReadCard = ReadCardStr
    End Function
    Public Function CheckCardBln() As Boolean '判断是否为公司卡
        CheckCardBln = False
        Dim ReadCardStr As String = "                                        "
        ws_openPort(Port)
        ws_loadKey_Hex(Port, "013002300897", 0)
        Ret = ws_readBlock_Hex(Port, 8, ReadCardStr)

        ReadCardStr = Mid(ReadCardStr, 1, 12)

        If ReadCardStr = "013983830690" Then
            CheckCardBln = True
        Else
            MessageBox.Show("IC卡非法，此卡非本公司卡！")
            CheckCardBln = False
        End If
        ws_closePort(Port)
    End Function
End Module


