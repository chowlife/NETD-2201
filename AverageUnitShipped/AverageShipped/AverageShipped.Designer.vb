<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageShipped
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.lbDisplayInput = New System.Windows.Forms.Label()
        Me.lbDisplayAverage = New System.Windows.Forms.Label()
        Me.tbUserInput = New System.Windows.Forms.TextBox()
        Me.lbNumberOfDays = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(17, 272)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(140, 272)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(263, 272)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(68, 38)
        Me.lbUnits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(48, 17)
        Me.lbUnits.TabIndex = 3
        Me.lbUnits.Text = "Units: "
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(239, 38)
        Me.lbDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(33, 17)
        Me.lbDays.TabIndex = 4
        Me.lbDays.Text = "Day"
        '
        'lbDisplayInput
        '
        Me.lbDisplayInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDisplayInput.Location = New System.Drawing.Point(68, 70)
        Me.lbDisplayInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDisplayInput.Name = "lbDisplayInput"
        Me.lbDisplayInput.Size = New System.Drawing.Size(225, 167)
        Me.lbDisplayInput.TabIndex = 5
        '
        'lbDisplayAverage
        '
        Me.lbDisplayAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDisplayAverage.Location = New System.Drawing.Point(68, 239)
        Me.lbDisplayAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDisplayAverage.Name = "lbDisplayAverage"
        Me.lbDisplayAverage.Size = New System.Drawing.Size(225, 30)
        Me.lbDisplayAverage.TabIndex = 6
        '
        'tbUserInput
        '
        Me.tbUserInput.Location = New System.Drawing.Point(140, 34)
        Me.tbUserInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUserInput.Name = "tbUserInput"
        Me.tbUserInput.Size = New System.Drawing.Size(99, 22)
        Me.tbUserInput.TabIndex = 7
        '
        'lbNumberOfDays
        '
        Me.lbNumberOfDays.AutoSize = True
        Me.lbNumberOfDays.Location = New System.Drawing.Point(273, 38)
        Me.lbNumberOfDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNumberOfDays.Name = "lbNumberOfDays"
        Me.lbNumberOfDays.Size = New System.Drawing.Size(0, 17)
        Me.lbNumberOfDays.TabIndex = 9
        '
        'frmAverageShipped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.lbNumberOfDays)
        Me.Controls.Add(Me.tbUserInput)
        Me.Controls.Add(Me.lbDisplayAverage)
        Me.Controls.Add(Me.lbDisplayInput)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbUnits As Label
    Friend WithEvents lbDays As Label
    Friend WithEvents lbDisplayInput As Label
    Friend WithEvents lbDisplayAverage As Label
    Friend WithEvents tbUserInput As TextBox
    Friend WithEvents lbNumberOfDays As Label
End Class
