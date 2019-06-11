Public Class FrmLogin
    Dim logStr As String = ""
    Dim loginCount As Integer = 0
    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        If loginCount >= 6 Then
            MsgBox("登录次数超过5次，系统将退出。")
            End
        End If
        If TextBox_userName.Text.Trim = "" Then
            MessageBox.Show("登录帐户不能为空，请输入...！")
            Exit Sub
        End If
        If TextBox_password.Text.Trim = "" Then
            MessageBox.Show("登录密码不能为空！请输入...！")
            TextBox_password.Text = ""
            Exit Sub
        End If
        Dim pwds As String = EncryptDes(TextBox_password.Text.Trim, "hjr060713", "")
        Dim sql As String = "SELECT * FROM cardInitialize WHERE userName='" + TextBox_userName.Text.Trim + "' AND password='" + pwds + "' AND status=1"
        Dim checkLoginRs As DataTable = DbOperation.systemControl(sql)
        If checkLoginRs.Rows.Count < 1 Then
            MsgBox("用户名或密码错误，请检查...", MsgBoxStyle.OkOnly, "错误提示")
            loginCount += 1
            TextBox_userName.Text = ""
            TextBox_password.Text = ""
            Exit Sub
        End If
        Authority = checkLoginRs.Rows(0)("Authority").ToString.Trim
        User_Name = checkLoginRs.Rows(0)("userName").ToString.Trim
        Operator_Name = checkLoginRs.Rows(0)("operator").ToString.Trim
        Dim cpuId As String = EncryptDes(getCPUID(), "hjr060713", "")
        If cpuId <> checkLoginRs.Rows(0)("cpuId").ToString.Trim Then
            loginCount += 1
            MsgBox("此计算机没被授权，不能使用本程序！", MsgBoxStyle.OkOnly, "错误提示")
            logStr = "'" + Me.Text + "','未被授权！'"
            record_Oplog(logStr)
            If User_Name = "何均文" Then
                workerSetting.Show()
                Me.Close()
            Else
                Exit Sub
            End If
        End If

        Frm_cardInit.Show()
        logStr = "'" + Me.Text + "','登录成功！'"
        record_Oplog(logStr)
        Me.Close()
    End Sub
    Private Sub ComboBox_addresName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_addresName.SelectedIndexChanged
        If ComboBox_addresName.Text = "九龙店" Then
            URL = "richkey.3322.org"
            AddresName = "九龙店"
        ElseIf ComboBox_addresName.Text = "中交店" Then
            URL = "63561999.3322.org"
            AddresName = "中交店"
        End If

        If ComboBox_addresName.Text <> "" Then
            statusCheck(1)
        Else
            statusCheck(0)
        End If

    End Sub

    Private Sub statusCheck(ByVal flag As Integer)
        If flag = 0 Then
            TextBox_password.Enabled = False
            TextBox_userName.Enabled = False
            Button_Enter.Enabled = False
        ElseIf flag = 1 Then
            TextBox_password.Enabled = True
            TextBox_userName.Enabled = True
            Button_Enter.Enabled = True
        End If
    End Sub
    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        End
    End Sub
End Class