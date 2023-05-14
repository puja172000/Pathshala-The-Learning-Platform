Imports System.Data.OleDb
Public Class Form1
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        cn.Open()
        sql = "select * from Login where Username = '" & Trim(txtUname.Text) & "' and Password = '" & Trim(txtPass.Text) & "'"
        rs = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = rs.ExecuteReader()
        Dim f As Integer = 1
        If r.Read = False Then
            MsgBox("Invalid Username or Password")
        Else
            Me.Hide()
            MDIParent1.Show()
        End If
        cn.Close()
        txtUname.Clear()
        txtPass.Clear()
    End Sub
End Class
