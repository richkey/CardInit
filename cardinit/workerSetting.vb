Public Class workerSetting
    Dim userNameID As String
    Dim logStr As String = ""
    Private Sub getUserName()
        Dim getUserNameStr As String = "SELECT id,userName,operator,password,authority,status,cpuId FROM cardInitialize"
        Dim getUserNameRs As DataTable = DbOperation.systemControl(getUserNameStr)
        If getUserNameRs.Rows.Count > 0 Then
            DataGridView1.DataSource = getUserNameRs
            DataGridView1.Columns(0).Width = 30
            DataGridView1.Columns(1).Width = 80
            DataGridView1.Columns(2).Width = 120
            DataGridView1.Columns(3).Width = 170
            DataGridView1.Columns(4).Width = 80
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(6).Width = 160
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub Check_Status_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Status.CheckedChanged
        If userNameID = "" Then Exit Sub
        Dim status = IIf(Check_Status.Checked, 1, 0)
        Dim checkStatusStr As String = "UPDATE cardInitialize SET status=" & status & " WHERE id='" + userNameID + "'"
        DbOperation.systemControl(checkStatusStr)
        logStr = "'" + Me.Text + "','修改用户登录权限！'"
        record_Oplog(logStr)
        getUserName()
        clsText()
    End Sub
    Private Sub Tool_Delete_Click(sender As Object, e As EventArgs) Handles Tool_Delete.Click
        If userNameID = "" Then Exit Sub
        Dim deleteStr As String = "DELETE FROM cardInitialize WHERE id='" + userNameID.Trim + "' "
        DbOperation.systemControl(deleteStr)
        logStr = "'" + Me.Text + "','删除用户信息！'"
        record_Oplog(logStr)
        getUserName()
        clsText()
    End Sub
    Private Sub SaveData()
        Dim SaveDataStr As String 
        If userNameID = "" Then
            SaveDataStr = "INSERT INTO cardInitialize(userName,operator,password,authority,status)VALUES(" & _
                "'" + Text_userName.Text.Trim + "','" + Text_operator.Text.Trim + "','" + EncryptDes(Text_Password.Text.Trim, "hjr060713", "") + "', '" + Cmb_Authority.Text.Trim + "',1)"
            logStr = "'" + Me.Text + "','新增用户！'"
            record_Oplog(logStr)
        Else
            SaveDataStr = "UPDATE cardInitialize SET userName='" + Text_userName.Text.Trim + "',operator='" + Text_operator.Text.Trim + "'," & _
            "password='" + EncryptDes(Text_Password.Text.Trim, "hjr060713", "") + "', authority='" + Cmb_Authority.Text.Trim + "' WHERE id='" + userNameID.Trim + "'"
            logStr = "'" + Me.Text + "','修改用户信息！'"
            record_Oplog(logStr)
        End If

        DbOperation.systemControl(SaveDataStr)
        getUserName()
        clsText()
    End Sub

    Private Sub workerSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Authority <> "A" Then
            MsgBox("操作用户管理权限不足，请与系统管理员联系！")
            logStr = "'" + Me.Text + "','修改用户权限不足！'"
            record_Oplog(logStr)
            Exit Sub
        End If
        getUserName()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            userNameID = DataGridView1.Rows(e.RowIndex).Cells("id").Value
            Text_userName.Text = DataGridView1.Rows(e.RowIndex).Cells("userName").Value.ToString
            Text_operator.Text = DataGridView1.Rows(e.RowIndex).Cells("operator").Value.ToString
            Text_Password.Text = DecryptDes(DataGridView1.Rows(e.RowIndex).Cells("password").Value.ToString.Trim, "hjr060713", "")
            Cmb_Authority.Text = DataGridView1.Rows(e.RowIndex).Cells("authority").Value.ToString
            Check_Status.Checked = DataGridView1.Rows(e.RowIndex).Cells("status").Value
            Tool_AddNew.Enabled = True
            Tool_Delete.Enabled = True
            Tool_Save.Enabled = True
            Tool_Enabled.Enabled = True
            Tool_Disabled.Enabled = True
        Catch ex As Exception
            Tool_AddNew.Enabled = False
            Tool_Delete.Enabled = False
            Tool_Save.Enabled = False
            Tool_Enabled.Enabled = False
            Tool_Disabled.Enabled = False
        End Try

    End Sub
    Private Sub clsText()
        Text_operator.Text = ""
        Text_userName.Text = ""
        Text_Password.Text = ""
        Text_CheckPassword.Text = ""
        Cmb_Authority.Text = ""
        Tool_Delete.Enabled = False
        Tool_Save.Enabled = True
        Tool_Enabled.Enabled = False
        Tool_Disabled.Enabled = False
        userNameID = ""
    End Sub
    Private Sub Tool_AddNew_Click(sender As Object, e As EventArgs) Handles Tool_AddNew.Click
        clsText()
    End Sub

    Private Sub Text_userName_TextChanged(sender As Object, e As EventArgs) Handles Text_userName.TextChanged
        Tool_Save.Enabled = True
    End Sub

    Private Sub Tool_Save_Click(sender As Object, e As EventArgs) Handles Tool_Save.Click
        SaveData()
    End Sub
    Private Sub Tool_Enabled_Click(sender As Object, e As EventArgs) Handles Tool_Enabled.Click
        Dim cpuId As String = EncryptDes(getCPUID(), "hjr060713", "")
        Dim authorizationStr As String = "UPDATE cardInitialize SET cpuId='" + cpuId + "' WHERE id='" + userNameID.Trim + "'"
        DbOperation.systemControl(authorizationStr)
        logStr = "'" + Me.Text + "','授权计算机登录权限！'"
        record_Oplog(logStr)
        getUserName()
    End Sub

    Private Sub Tool_Disabled_Click(sender As Object, e As EventArgs) Handles Tool_Disabled.Click
        Dim authorizationStr As String = "UPDATE cardInitialize SET cpuId='' WHERE id='" + userNameID.Trim + "'"
        DbOperation.systemControl(authorizationStr)
        logStr = "'" + Me.Text + "','禁止计算机登录！'"
        record_Oplog(logStr)
        getUserName()
    End Sub
End Class