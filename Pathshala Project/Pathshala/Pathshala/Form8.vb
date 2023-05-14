Imports System.Data.OleDb
Public Class Form8
    Public tn As String
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub CmbChapter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChapter.SelectedIndexChanged
        cn.Open()
        RtxtAns.Clear()
        RtxtQue.Clear()
        sql = ("select * from Data where Chapter_Name ='" & CmbChapter.SelectedItem & "'")
        rs = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = rs.ExecuteReader()
        tn = "00"
        Do While r.Read()
            tn = Strings.Right(r("Question_No"), 3)
        Loop
        Dim AN As Integer
        AN = Val(tn)
        tn = Trim(Str(AN))
        cn.Close()
        txtQno.Text = 1

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
    Private Sub txtQno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQno.TextChanged
        If txtQno.Text = 0 Then
            RtxtAns.Clear()
            RtxtQue.Clear()
            MsgBox("Question No. 0 is Not Available")
            BtnPre.Enabled = False
            txtQno.Text = "1"
        ElseIf txtQno.Text = tn + 1 Then
            RtxtAns.Clear()
            RtxtQue.Clear()
            MsgBox("No More Questions")
            BtnNxt.Enabled = False
            txtQno.Text = tn
        Else
            RtxtAns.Clear()
            RtxtQue.Clear()
            cn.Open()
            sql = ("select * from Data where Chapter_Name ='" & CmbChapter.SelectedItem & "'and Question_No='" & txtQno.Text & "'")
            rs = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = rs.ExecuteReader()
            If r.Read() Then
                RtxtQue.Text = r("Questions")
                RtxtAns.Text = r("Answer")
            End If
            cn.Close()
        End If
    End Sub
    Private Sub BtnNxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNxt.Click
        txtQno.Text = txtQno.Text + 1
    End Sub

    Private Sub BtnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPre.Click
        txtQno.Text = txtQno.Text - 1
        BtnNxt.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Close()
    End Sub
End Class