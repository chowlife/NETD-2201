<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.tbText = New System.Windows.Forms.TextBox()
        Me.mnuOptions = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextEditorTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbText
        '
        Me.tbText.AcceptsTab = True
        Me.tbText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbText.Location = New System.Drawing.Point(0, 26)
        Me.tbText.Margin = New System.Windows.Forms.Padding(2)
        Me.tbText.MaxLength = 2147483647
        Me.tbText.Multiline = True
        Me.tbText.Name = "tbText"
        Me.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbText.Size = New System.Drawing.Size(759, 327)
        Me.tbText.TabIndex = 2
        '
        'mnuOptions
        '
        Me.mnuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(759, 24)
        Me.mnuOptions.TabIndex = 3
        Me.mnuOptions.Text = "Options"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "To create new file."
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "To open any existing file."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "To save the current file."
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuSaveAs.Text = "&Save As"
        Me.mnuSaveAs.ToolTipText = "To save this file as a new document."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "&Exit"
        Me.mnuExit.ToolTipText = "To exit this file."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "To copy selected text."
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(152, 22)
        Me.mnuCut.Text = "&Cut"
        Me.mnuCut.ToolTipText = "To cut selected text."
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(152, 22)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "To paste text on current position."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "&About"
        Me.mnuAbout.ToolTipText = "Information about this software."
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 384)
        Me.Controls.Add(Me.mnuOptions)
        Me.Controls.Add(Me.tbText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuOptions.ResumeLayout(False)
        Me.mnuOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbText As TextBox
    Friend WithEvents mnuOptions As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents TextEditorTips As ToolTip
End Class
