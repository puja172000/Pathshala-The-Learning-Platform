Imports System.Data.OleDb
Public Class Form6
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub CmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSubject.SelectedIndexChanged
        CmbChapter.Items.Clear()
        cn.Open()
        sql = ("select * from Chapter where Board_Name='" & CmbBoard.SelectedItem & "'and Class_Name='" & CmbClass.SelectedItem & "'and Subject_Name='" & CmbSubject.SelectedItem & "'")
        rs = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = rs.ExecuteReader()
        Do While r.Read()
            CmbChapter.Items.Add(r("Chapter_Name"))
        Loop
        cn.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cn.Open()
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            Call OpenLock()
            Call ClearControl()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Data values ('" & CmbChapter.SelectedItem & "', '" & txtQno.Text & "','" & RtxtQue.Text & "','" & RtxtAns.Text & "')"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub LockControl()
        RtxtQue.Enabled = False
        RtxtAns.Enabled = False
        CmbSubject.Enabled = False
        CmbClass.Enabled = False
        CmbChapter.Enabled = False
        CmbBoard.Enabled = False
    End Sub
    Private Sub OpenLock()
        RtxtQue.Enabled = True
        RtxtAns.Enabled = True
        CmbSubject.Enabled = True
        CmbClass.Enabled = True
        CmbChapter.Enabled = True
        CmbBoard.Enabled = True
    End Sub
    Private Sub ClearControl()
        RtxtQue.Text = ""
        RtxtAns.Text = ""
    End Sub

    Private Sub CmbChapter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChapter.SelectedIndexChanged
        cn.Open()
        If btnModify.Text = "Update" Then
            txtQno.Enabled = True
        Else
            sql = ("select * from Data where Chapter_Name ='" & CmbChapter.SelectedItem & "'")
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            Dim tn As String
            tn = "99"
            Do While r.Read()
                tn = r("Question_No")
            Loop
            Dim AN As Integer
            AN = tn
            AN = AN + 1
            tn = Trim(Str(AN))
            txtQno.Text = tn
        End If
        cn.Close()
    End Sub
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        cn.Open()
        If btnModify.Text = "Modify" Then
            btnModify.Text = "Update"
            Call OpenLock()
        Else
            btnModify.Text = "Modify"
            sql = "update Data set Questions ='" & RtxtQue.Text & "', Answer='" & RtxtAns.Text & "' WHERE Chapter_Name = '" & CmbChapter.SelectedItem & "' and Question_No='" & txtQno.Text & "'"
            rs = New OleDbCommand(sql, cn)
            rs.ExecuteReader()
            MsgBox("Record Modified Successfully.")
            txtQno.Enabled = False
            Call LockControl()
        End If
        cn.Close()
    End Sub
    Private Sub txtQno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQno.TextChanged
        If btnModify.Text = "Update" Then
            cn.Open()
            sql = "select * from Data where Chapter_Name='" & CmbChapter.SelectedItem & "' and Question_No='" & txtQno.Text & "'"
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                RtxtQue.Text = r("Questions")
                RtxtAns.Text = r("Answer")
            Else
                MsgBox("Question Not Found")

            End If
            cn.Close()
            End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
