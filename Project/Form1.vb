Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Public Class Form1

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtusername.Text()
        Dim password As String = txtPassword.Text()


        Dim check As New checkAuth()
        check.username = username
        check.password = password

        If check.c_Auth() = True Then
            Dim frm As New Form2
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Missing ")

        End If

        'Dim objConn As New SqlConnection
        'Dim objCmd As New SqlCommand
        'Dim strConnString, strSQL As String
        'strConnString = ConfigurationManager.ConnectionStrings.Item(1).ConnectionString
        'objConn.ConnectionString = strConnString
        'objConn.Open()
        'Dim intNumRows As Integer
        'strSQL = "SELECT COUNT(*) FROM member WHERE Username = '" & username & "' AND Password = '" & password & "' "
        'objCmd = New SqlCommand(strSQL, objConn)
        'intNumRows = objCmd.ExecuteScalar()
        'MessageBox.Show("Connect")
        'If intNumRows > 0 Then
        '    Dim frm As New Form2
        '    'frm._strUser = Me.tbId.Text
        '    ' frm.LoadInfor()
        '    frm.Show()

        '    Me.Hide()
        'Else
        '    MessageBox.Show("Username or Password Incorrect")
        'End If

        'objConn.Close()
        'objConn = Nothing


    End Sub

    Private Sub txtusername_OnValueChanged(sender As Object, e As EventArgs) Handles txtusername.OnValueChanged, txtPassword.OnValueChanged
        txtPassword.isPassword = True


    End Sub


    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
