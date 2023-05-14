Imports System.Data.OleDb
Public Class Form3
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LockControl()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub showgrid()
        On Error Resume Next
        cn.Open()
        sql = "Select *from Class"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Classdetails")
        dg2.DataSource = ds
        dg2.DataMember = "Classdetails"
        cn.Close()
    End Sub
    Private Sub txtCcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCcode.KeyPress
        cn.Open()
        If Asc(e.KeyChar) = 13 Then
            sql = "SELECT *from Class where Class_Code= '" & txtCcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                txtCname.Text = r("Class_Name")
            Else
                MsgBox("Record Not Found")
                Exit Sub
            End If
            txtCcode.Enabled = False
        End If
        cn.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        txtCcode.Enabled = True
        txtCcode.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        sql = "Delete *from Class where Class_Code = '" & txtCcode.Text & "'"
        rs = New OleDbCommand(sql, cn)
        rs.ExecuteReader()
        Call showgrid()
        Call LockControl()
        cn.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cn.Open()
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            Call OpenLock()
            Call ClearControl()
            sql = "select * from Class order by Class_Code"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            Dim tn As String
            tn = "999"
            Do While r.Read()
                tn = Strings.Right(r("Class_Code"), 4)
            Loop
            Dim AN As Integer
            AN = Val(tn)
            AN = AN + 1
            tn = Trim(Str(AN))
            txtCcode.Text = tn
            txtCcode.Enabled = False
            txtCcode.Focus()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Class values('" & txtCcode.Text & "', '" & txtCcode.Text & "')"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub LockControl()
        txtCcode.Enabled = False
        txtCname.Enabled = False
    End Sub
    Private Sub OpenLock()
        txtCcode.Enabled = True
        txtCname.Enabled = True
    End Sub
    Private Sub ClearControl()
        txtCcode.Text = ""
        txtCname.Text = ""
    End Sub

    Private Sub BtnList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        Call showgrid()
    End Sub

    Private Sub BtnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        cn.Open()
        If btnModify.Text = "Modify" Then
            btnModify.Text = "Update"
            Call OpenLock()
            txtCcode.Enabled = True
        Else
            btnModify.Text = "Modify"
            sql = "update Class set Class_Name= '" & txtCname.Text & "'  WHERE Board_Code = '" & txtCcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Modified Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
End Class


