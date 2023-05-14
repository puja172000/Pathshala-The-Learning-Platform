Imports System.Data.OleDb
Public Class Form5
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LockControl()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub showgrid()
        On Error Resume Next
        cn.Open()
        sql = "Select *from Chapter order by Chapter_Code"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Chapterdetails")
        dg4.DataSource = ds
        dg4.DataMember = "Chapterdetails"
        cn.Close()
    End Sub
    Private Sub txtChcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChcode.KeyPress
        cn.Open()
        If Asc(e.KeyChar) = 13 Then
            sql = "SELECT *from Chapter where Chapter_Code= '" & txtChcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                txtChname.Text = r("Chapter_Name")
            Else
                MsgBox("Record Not Found")
                Exit Sub
            End If
            txtChcode.Enabled = False
        End If
        cn.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        txtChcode.Enabled = True
        txtChcode.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        sql = "Delete *from Chapter where Chapter_Code = '" & txtChcode.Text & "'"
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
            sql = "select * from Chapter order by Chapter_Code"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            Dim tn As String
            tn = "99"
            Do While r.Read()
                'tn = Strings.Right(r("Chapter_Code"), 4)
                tn = r("Chapter_Code")
            Loop
            Dim AN As Integer
            AN = tn
            AN = AN + 1
            tn = Trim(Str(AN))
            txtChcode.Text = tn
            txtChcode.Enabled = False
            txtChcode.Focus()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Chapter (Chapter_Code , Chapter_Name ,Board_Name , Subject_Name, Class_Name) values(" & Val(txtChcode.Text) & ", '" & txtChname.Text & "','" & CmbBoard.SelectedItem & "','" & CmbSubject.SelectedItem & "','" & CmbClass.SelectedItem & "')"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub LockControl()
        txtChcode.Enabled = False
        txtChname.Enabled = False
    End Sub
    Private Sub OpenLock()
        txtChcode.Enabled = True
        txtChname.Enabled = True
    End Sub
    Private Sub ClearControl()
        txtChcode.Text = ""
        txtChname.Text = ""
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
            txtChcode.Enabled = True
        Else
            btnModify.Text = "Modify"
            sql = "update Chapter set Chapter_Name= '" & txtChname.Text & "'  WHERE Chapter_Code = '" & txtChcode.Text & "'"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Modified Successfully.")
            Call showgrid()
            Call LockControl()
        End If
        cn.Close()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()
        sql = "select * from Board"
        rs = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = rs.ExecuteReader()
        Do While r.Read()
            CmbBoard.Items.Add(r("Board_Name"))
        Loop
        sql = "select * from Class"
        rs = New OleDbCommand(sql, cn)
        r = rs.ExecuteReader()
        Do While r.Read()
            CmbClass.Items.Add(r("Class_Name"))
        Loop
        sql = "select * from Subject"
        rs = New OleDbCommand(sql, cn)
        r = rs.ExecuteReader()
        Do While r.Read()
            CmbSubject.Items.Add(r("Subject_Name"))
        Loop
        
        cn.Close()
    End Sub
End Class


