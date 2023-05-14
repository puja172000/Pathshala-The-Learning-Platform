Imports System.Data.OleDb
Public Class Form4
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LockControl()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub showgrid()
        On Error Resume Next
        cn.Open()
        sql = "Select *from Subject"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Subjectdetails")
        dg3.DataSource = ds
        dg3.DataMember = "Subjectdetails"
        cn.Close()
    End Sub
    Private Sub txtScode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScode.KeyPress
        cn.Open()
        If Asc(e.KeyChar) = 13 Then
            sql = "SELECT *from Subject where Subject_Code= '" & txtScode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                txtSname.Text = r("Subject_Name")
            Else
                MsgBox("Record Not Found")
                Exit Sub
            End If
            txtScode.Enabled = False
        End If
        cn.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        txtScode.Enabled = True
        txtScode.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        sql = "Delete *from Subject where Subject_Code = '" & txtScode.Text & "'"
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
            sql = "select * from Subject order by Subject_Code"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            Dim tn As String
            tn = "999"
            Do While r.Read()
                tn = Strings.Right(r("Subject_Code"), 4)
            Loop
            Dim AN As Integer
            AN = Val(tn)
            AN = AN + 1
            tn = Trim(Str(AN))
            txtScode.Text = tn
            txtScode.Enabled = False
            txtScode.Focus()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Subject values('" & txtScode.Text & "', '" & txtSname.Text & "')"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub LockControl()
        txtScode.Enabled = False
        txtSname.Enabled = False
    End Sub
    Private Sub OpenLock()
        txtScode.Enabled = True
        txtSname.Enabled = True
    End Sub
    Private Sub ClearControl()
        txtScode.Text = ""
        txtSname.Text = ""
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
            txtScode.Enabled = True
        Else
            btnModify.Text = "Modify"
            sql = "update Subject set Subject_Name= '" & txtSname.Text & "'  WHERE Subject_Code = '" & txtScode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Modified Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
End Class


