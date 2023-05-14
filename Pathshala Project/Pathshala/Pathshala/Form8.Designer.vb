<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnNxt = New System.Windows.Forms.Button()
        Me.BtnPre = New System.Windows.Forms.Button()
        Me.RtxtAns = New System.Windows.Forms.RichTextBox()
        Me.RtxtQue = New System.Windows.Forms.RichTextBox()
        Me.txtQno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbClass = New System.Windows.Forms.ComboBox()
        Me.CmbChapter = New System.Windows.Forms.ComboBox()
        Me.CmbSubject = New System.Windows.Forms.ComboBox()
        Me.CmbBoard = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNxt
        '
        Me.BtnNxt.Location = New System.Drawing.Point(625, 432)
        Me.BtnNxt.Name = "BtnNxt"
        Me.BtnNxt.Size = New System.Drawing.Size(99, 32)
        Me.BtnNxt.TabIndex = 6
        Me.BtnNxt.Text = "Next"
        Me.BtnNxt.UseVisualStyleBackColor = True
        '
        'BtnPre
        '
        Me.BtnPre.Location = New System.Drawing.Point(264, 432)
        Me.BtnPre.Name = "BtnPre"
        Me.BtnPre.Size = New System.Drawing.Size(99, 32)
        Me.BtnPre.TabIndex = 5
        Me.BtnPre.Text = "Previous"
        Me.BtnPre.UseVisualStyleBackColor = True
        '
        'RtxtAns
        '
        Me.RtxtAns.Location = New System.Drawing.Point(508, 257)
        Me.RtxtAns.Name = "RtxtAns"
        Me.RtxtAns.Size = New System.Drawing.Size(298, 145)
        Me.RtxtAns.TabIndex = 20
        Me.RtxtAns.Text = ""
        '
        'RtxtQue
        '
        Me.RtxtQue.Location = New System.Drawing.Point(172, 257)
        Me.RtxtQue.Name = "RtxtQue"
        Me.RtxtQue.Size = New System.Drawing.Size(298, 145)
        Me.RtxtQue.TabIndex = 18
        Me.RtxtQue.Text = ""
        '
        'txtQno
        '
        Me.txtQno.Location = New System.Drawing.Point(15, 257)
        Me.txtQno.Name = "txtQno"
        Me.txtQno.Size = New System.Drawing.Size(89, 29)
        Me.txtQno.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(621, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Answer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Que. No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Question"
        '
        'CmbClass
        '
        Me.CmbClass.FormattingEnabled = True
        Me.CmbClass.Location = New System.Drawing.Point(138, 93)
        Me.CmbClass.Name = "CmbClass"
        Me.CmbClass.Size = New System.Drawing.Size(121, 30)
        Me.CmbClass.TabIndex = 2
        '
        'CmbChapter
        '
        Me.CmbChapter.FormattingEnabled = True
        Me.CmbChapter.Location = New System.Drawing.Point(576, 92)
        Me.CmbChapter.Name = "CmbChapter"
        Me.CmbChapter.Size = New System.Drawing.Size(274, 30)
        Me.CmbChapter.TabIndex = 4
        '
        'CmbSubject
        '
        Me.CmbSubject.FormattingEnabled = True
        Me.CmbSubject.Location = New System.Drawing.Point(576, 22)
        Me.CmbSubject.Name = "CmbSubject"
        Me.CmbSubject.Size = New System.Drawing.Size(121, 30)
        Me.CmbSubject.TabIndex = 3
        '
        'CmbBoard
        '
        Me.CmbBoard.FormattingEnabled = True
        Me.CmbBoard.Location = New System.Drawing.Point(138, 27)
        Me.CmbBoard.Name = "CmbBoard"
        Me.CmbBoard.Size = New System.Drawing.Size(274, 30)
        Me.CmbBoard.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Chapter :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subject :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Class :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Board :"
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(772, 20)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(110, 32)
        Me.BtnHome.TabIndex = 21
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(894, 469)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnNxt)
        Me.Controls.Add(Me.BtnPre)
        Me.Controls.Add(Me.RtxtAns)
        Me.Controls.Add(Me.RtxtQue)
        Me.Controls.Add(Me.txtQno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbClass)
        Me.Controls.Add(Me.CmbChapter)
        Me.Controls.Add(Me.CmbSubject)
        Me.Controls.Add(Me.CmbBoard)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pathshala"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNxt As System.Windows.Forms.Button
    Friend WithEvents BtnPre As System.Windows.Forms.Button
    Friend WithEvents RtxtAns As System.Windows.Forms.RichTextBox
    Friend WithEvents RtxtQue As System.Windows.Forms.RichTextBox
    Friend WithEvents txtQno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents CmbChapter As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBoard As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnHome As System.Windows.Forms.Button
End Class
