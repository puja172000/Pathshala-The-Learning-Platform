<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MastersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoardMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathshalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MastersToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MastersToolStripMenuItem
        '
        Me.MastersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoardMasterToolStripMenuItem, Me.ClassToolStripMenuItem, Me.SubjectMasterToolStripMenuItem, Me.ChapterToolStripMenuItem, Me.QuestionToolStripMenuItem})
        Me.MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        Me.MastersToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MastersToolStripMenuItem.Text = "Masters"
        '
        'BoardMasterToolStripMenuItem
        '
        Me.BoardMasterToolStripMenuItem.Name = "BoardMasterToolStripMenuItem"
        Me.BoardMasterToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.BoardMasterToolStripMenuItem.Text = "Board "
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClassToolStripMenuItem.Text = "Class "
        '
        'SubjectMasterToolStripMenuItem
        '
        Me.SubjectMasterToolStripMenuItem.Name = "SubjectMasterToolStripMenuItem"
        Me.SubjectMasterToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SubjectMasterToolStripMenuItem.Text = "Subject"
        '
        'ChapterToolStripMenuItem
        '
        Me.ChapterToolStripMenuItem.Name = "ChapterToolStripMenuItem"
        Me.ChapterToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ChapterToolStripMenuItem.Text = "Chapter "
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem"
        Me.QuestionToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.QuestionToolStripMenuItem.Text = "Question"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathshalaToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'PathshalaToolStripMenuItem
        '
        Me.PathshalaToolStripMenuItem.Name = "PathshalaToolStripMenuItem"
        Me.PathshalaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PathshalaToolStripMenuItem.Text = "Pathshala"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ExitToolStripMenuItem.Text = "Log Out"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(515, 394)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MastersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoardMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathshalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
