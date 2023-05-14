Imports System.Data.OleDb
Public Class Form2
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LockControl()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub showgrid()
        On Error Resume Next
        cn.Open()
        sql = "Select *from Board"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Boarddetails")
        dg1.DataSource = ds
        dg1.DataMember = "Boarddetails"
        cn.Close()
    End Sub
    Private Sub txtBcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBcode.KeyPress
        cn.Open()
        If Asc(e.KeyChar) = 13 Then
            sql = "SELECT *from Board where Board_Code= '" & txtBcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                txtBname.Text = r("Board_Name")
            Else
                MsgBox("Record Not Found")
                Exit Sub
            End If
            txtBcode.Enabled = False
        End If
        cn.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        txtBcode.Enabled = True
        txtBcode.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        sql = "Delete *from Board where Board_Code = '" & txtBcode.Text & "'"
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
            sql = "select * from Board order by Board_Code"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            Dim tn As String
            tn = "999"
            Do While r.Read()
                tn = Strings.Right(r("Board_Code"), 4)
            Loop
            Dim AN As Integer
            AN = Val(tn)
            AN = AN + 1
            tn = Trim(Str(AN))
            txtBcode.Text = tn
            txtBcode.Enabled = False
            txtBname.Focus()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Board values('" & txtBcode.Text & "', '" & txtBname.Text & "')"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub LockControl()
        txtBcode.Enabled = False
        txtBname.Enabled = False
    End Sub
    Private Sub OpenLock()
        txtBcode.Enabled = True
        txtBname.Enabled = True
    End Sub
    Private Sub ClearControl()
        txtBcode.Text = ""
        txtBname.Text = ""
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
            txtBcode.Enabled = True
        Else
            btnModify.Text = "Modify"
            sql = "update Board set Board_Name= '" & txtBname.Text & "'  WHERE Board_Code = '" & txtBcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Modified Successfully.")
            Call showgrid()
            Call LockControl()

        End If
        cn.Close()
    End Sub
End Class


