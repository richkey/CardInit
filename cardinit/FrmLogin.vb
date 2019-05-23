Public Class FrmLogin
    Const userName As String = "richkey"
    Const password As String = "2368406333"
    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        End
    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        If TextBox_userName.Text.Trim <> userName Then
            MessageBox.Show("登录帐户错误！")
            Exit Sub
        End If
        If TextBox_password.Text.Trim <> password Then
            MessageBox.Show("登录密码错误！")
            Exit Sub
        End If

        Frm_cardInit.Show()
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_addresName.Items.Add("九龙店")
        ComboBox_addresName.Items.Add("中交店")
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

End Class