Public Class Form_Oplog
    Dim userNameLog As String
    Private Sub Form_Oplog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getOplogData(0)
    End Sub
    Private Function comboboxValue(ByVal falg As Integer)

        If falg = 0 Then

        End If
    End Function

    Private Sub getOplogData(ByVal flag As Integer)
        Dim oplogStr As String = ""
        If flag = 0 Then
            oplogStr = "SELECT * FROM cardInitOplog"
        ElseIf flag = 1 Then
            oplogStr = "SELECT * FROM cardInitOplog WHERE userName='" + userNameLog + "'"
        ElseIf flag = 2 Then
            oplogStr = "SELECT * FROM cardInitOplog WHERE loginForm='" + userNameLog + "'"
        End If
        Dim oplogRs As DataTable = DbOperation.systemControl(oplogStr)
        If oplogRs.Rows.Count > 0 Then
            DataGridView1.DataSource = oplogRs
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub Cmb_UserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_UserName.SelectedIndexChanged

    End Sub
End Class