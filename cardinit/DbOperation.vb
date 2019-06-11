
Imports System.Data
Imports System.Data.SqlClient
Public Class DbOperation '连接数据库
    Shared Function DBOperate(ByVal SqlStr As String) As DataTable '主数据
        Dim Conn As String = "Data Source=" & URL & ";Initial Catalog=NatatoriumCardGL;Persist Security Info=True;User ID=richkey;Password=515200"
        Dim SqlConn As New SqlClient.SqlConnection(Conn)
        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlStr, SqlConn)
        Cmd.CommandType = CommandType.Text
        Dim sTokens() As String
        sTokens = SqlStr.Split(" ")
        If InStr("INSERT,DELETE,UPDATE", sTokens(0).ToString) Then
            If SqlConn.State <> ConnectionState.Open Then
                SqlConn.Open()
            End If
            Cmd.ExecuteNonQuery()
            If SqlConn.State = ConnectionState.Closed Then
                SqlConn.Close()
            End If
            Return Nothing
        Else
            Dim MyDataSet As New DataSet()
            Dim MyAdapter As New SqlClient.SqlDataAdapter()
            MyAdapter.TableMappings.Add("Table", "TEMP")
            MyAdapter.SelectCommand = Cmd
            If SqlConn.State <> ConnectionState.Open Then
                SqlConn.Open()
            End If
            Cmd.ExecuteNonQuery()
            If SqlConn.State <> ConnectionState.Closed Then
                SqlConn.Close()
            End If
            MyAdapter.Fill(MyDataSet)
            Return MyDataSet.Tables("TEMP")
        End If

    End Function
    Shared Function systemControl(ByVal SqlStr As String) As DataTable '用户登录
        Dim systemControl_Conn As String = "Data Source=richkey.3322.org;Initial Catalog=systemControl;Persist Security Info=True;User ID=richkey;Password=515200"
        Dim SqlConn As New SqlClient.SqlConnection(systemControl_Conn)
        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlStr, SqlConn)
        Cmd.CommandType = CommandType.Text
        Dim sTokens() As String
        sTokens = SqlStr.Split(" ")
        If InStr("INSERT,DELETE,UPDATE", sTokens(0).ToString) Then
            If SqlConn.State <> ConnectionState.Open Then
                SqlConn.Open()
            End If
            Cmd.ExecuteNonQuery()
            If SqlConn.State = ConnectionState.Closed Then
                SqlConn.Close()
            End If
            Return Nothing
        Else
            Dim MyDataSet As New DataSet()
            Dim MyAdapter As New SqlClient.SqlDataAdapter()
            MyAdapter.TableMappings.Add("Table", "TEMP")
            MyAdapter.SelectCommand = Cmd
            If SqlConn.State <> ConnectionState.Open Then
                SqlConn.Open()
            End If
            Cmd.ExecuteNonQuery()
            If SqlConn.State <> ConnectionState.Closed Then
                SqlConn.Close()
            End If
            MyAdapter.Fill(MyDataSet)
            Return MyDataSet.Tables("TEMP")
        End If
    End Function

End Class

