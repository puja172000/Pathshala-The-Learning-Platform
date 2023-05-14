<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.CmbBoard = New System.Windows.Forms.ComboBox()
        Me.CmbClass = New System.Windows.Forms.ComboBox()
        Me.CmbSubject = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbChapter = New System.Windows.Forms.ComboBox()
        Me.RtxtQue = New System.Windows.Forms.RichTextBox()
        Me.RtxtAns = New System.Windows.Forms.RichTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmbBoard
        '
        Me.CmbBoard.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoard.FormattingEnabled = True
        Me.CmbBoard.Location = New System.Drawing.Point(31, 88)
        Me.CmbBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbBoard.Name = "CmbBoard"
        Me.CmbBoard.Size = New System.Drawing.Size(194, 27)
        Me.CmbBoard.TabIndex = 34
        Me.CmbBoard.Text = "Select Board"
        '
        'CmbClass
        '
        Me.CmbClass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbClass.FormattingEnabled = True
        Me.CmbClass.Location = New System.Drawing.Point(326, 88)
        Me.CmbClass.Name = "CmbClass"
        Me.CmbClass.Size = New System.Drawing.Size(204, 27)
        Me.CmbClass.TabIndex = 32
        Me.CmbClass.Text = "Select Class"
        '
        'CmbSubject
        '
        Me.CmbSubject.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSubject.FormattingEnabled = True
        Me.CmbSubject.Location = New System.Drawing.Point(33, 159)
        Me.CmbSubject.Name = "CmbSubject"
        Me.CmbSubject.Size = New System.Drawing.Size(192, 27)
        Me.CmbSubject.TabIndex = 33
        Me.CmbSubject.Text = "Select Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Enter Answer :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Enter Question :"
        '
        'CmbChapter
        '
        Me.CmbChapter.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbChapter.FormattingEnabled = True
        Me.CmbChapter.Location = New System.Drawing.Point(326, 159)
        Me.CmbChapter.Name = "CmbChapter"
        Me.CmbChapter.Size = New System.Drawing.Size(204, 27)
        Me.CmbChapter.TabIndex = 35
        Me.CmbChapter.Text = "Select Chapter"
        '
        'RtxtQue
        '
        Me.RtxtQue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxtQue.Location = New System.Drawing.Point(234, 282)
        Me.RtxtQue.Name = "RtxtQue"
        Me.RtxtQue.Size = New System.Drawing.Size(296, 79)
        Me.RtxtQue.TabIndex = 36
        Me.RtxtQue.Text = ""
        '
        'RtxtAns
        '
        Me.RtxtAns.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxtAns.Location = New System.Drawing.Point(234, 395)
        Me.RtxtAns.Name = "RtxtAns"
        Me.RtxtAns.Size = New System.Drawing.Size(296, 79)
        Me.RtxtAns.TabIndex = 36
        Me.RtxtAns.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(31, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 45)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnModify.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(223, 12)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(113, 45)
        Me.btnModify.TabIndex = 20
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(417, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 45)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Que No. :"
        '
        'txtQno
        '
        Me.txtQno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQno.Location = New System.Drawing.Point(234, 224)
        Me.txtQno.Name = "txtQno"
        Me.txtQno.Size = New System.Drawing.Size(129, 29)
        Me.txtQno.TabIndex = 38
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(562, 500)
        Me.Controls.Add(Me.txtQno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RtxtAns)
        Me.Controls.Add(Me.RtxtQue)
        Me.Controls.Add(Me.CmbChapter)
        Me.Controls.Add(Me.CmbBoard)
        Me.Controls.Add(Me.CmbClass)
        Me.Controls.Add(Me.CmbSubject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question Master"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBoard As System.Windows.Forms.ComboBox
    Friend WithEvents CmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbChapter As System.Windows.Forms.ComboBox
    Friend WithEvents RtxtQue As System.Windows.Forms.RichTextBox
    Friend WithEvents RtxtAns As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQno As System.Windows.Forms.TextBox
End Class
