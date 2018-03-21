<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeShipped
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbEmployeesAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lbEmployeeOneInput = New System.Windows.Forms.Label()
        Me.lbEmployeeTwoInput = New System.Windows.Forms.Label()
        Me.lbEmployeeThreeInput = New System.Windows.Forms.Label()
        Me.lbEmployeeOne = New System.Windows.Forms.Label()
        Me.lbEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeThree = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbUserInput = New System.Windows.Forms.TextBox()
        Me.lbNumberOfDay = New System.Windows.Forms.Label()
        Me.lbToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 233)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(107, 23)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "&Enter"
        Me.btnToolTip.SetToolTip(Me.btnEnter, "Press to enter input!")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(125, 233)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnToolTip.SetToolTip(Me.btnReset, "Press to reset!")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 233)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Exit"
        Me.btnToolTip.SetToolTip(Me.btnExit, "Press to exit!")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbEmployeesAverage
        '
        Me.lbEmployeesAverage.BackColor = System.Drawing.Color.Silver
        Me.lbEmployeesAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeesAverage.Location = New System.Drawing.Point(12, 207)
        Me.lbEmployeesAverage.Name = "lbEmployeesAverage"
        Me.lbEmployeesAverage.Size = New System.Drawing.Size(333, 23)
        Me.lbEmployeesAverage.TabIndex = 16
        Me.lbEmployeesAverage.Text = "&"
        Me.lbEmployeesAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeesAverage, "This is where you see the total average after every employee reached their 7th in" &
        "put")
        '
        'lbEmployeeOneAverage
        '
        Me.lbEmployeeOneAverage.BackColor = System.Drawing.Color.Silver
        Me.lbEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeOneAverage.Location = New System.Drawing.Point(12, 175)
        Me.lbEmployeeOneAverage.Name = "lbEmployeeOneAverage"
        Me.lbEmployeeOneAverage.Size = New System.Drawing.Size(107, 23)
        Me.lbEmployeeOneAverage.TabIndex = 13
        Me.lbEmployeeOneAverage.Text = "&"
        Me.lbEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeOneAverage, "This is where you see your average after the 7th input")
        '
        'lbEmployeeTwoAverage
        '
        Me.lbEmployeeTwoAverage.BackColor = System.Drawing.Color.Silver
        Me.lbEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeTwoAverage.Location = New System.Drawing.Point(125, 175)
        Me.lbEmployeeTwoAverage.Name = "lbEmployeeTwoAverage"
        Me.lbEmployeeTwoAverage.Size = New System.Drawing.Size(107, 23)
        Me.lbEmployeeTwoAverage.TabIndex = 14
        Me.lbEmployeeTwoAverage.Text = "&"
        Me.lbEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeTwoAverage, "This is where you see your average after the 7th input")
        '
        'lbEmployeeThreeAverage
        '
        Me.lbEmployeeThreeAverage.BackColor = System.Drawing.Color.Silver
        Me.lbEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeThreeAverage.Location = New System.Drawing.Point(238, 175)
        Me.lbEmployeeThreeAverage.Name = "lbEmployeeThreeAverage"
        Me.lbEmployeeThreeAverage.Size = New System.Drawing.Size(107, 23)
        Me.lbEmployeeThreeAverage.TabIndex = 15
        Me.lbEmployeeThreeAverage.Text = "&"
        Me.lbEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeThreeAverage, "This is where you see your average after the 7th input")
        '
        'lbEmployeeOneInput
        '
        Me.lbEmployeeOneInput.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmployeeOneInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeOneInput.Location = New System.Drawing.Point(12, 67)
        Me.lbEmployeeOneInput.Name = "lbEmployeeOneInput"
        Me.lbEmployeeOneInput.Size = New System.Drawing.Size(107, 104)
        Me.lbEmployeeOneInput.TabIndex = 10
        Me.lbEmployeeOneInput.Text = "&"
        Me.lbEmployeeOneInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeOneInput, "this is where you see your input")
        '
        'lbEmployeeTwoInput
        '
        Me.lbEmployeeTwoInput.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmployeeTwoInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeTwoInput.Location = New System.Drawing.Point(125, 67)
        Me.lbEmployeeTwoInput.Name = "lbEmployeeTwoInput"
        Me.lbEmployeeTwoInput.Size = New System.Drawing.Size(107, 104)
        Me.lbEmployeeTwoInput.TabIndex = 11
        Me.lbEmployeeTwoInput.Text = "&"
        Me.lbEmployeeTwoInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeTwoInput, "this is where you see your input")
        '
        'lbEmployeeThreeInput
        '
        Me.lbEmployeeThreeInput.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmployeeThreeInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeThreeInput.Location = New System.Drawing.Point(238, 67)
        Me.lbEmployeeThreeInput.Name = "lbEmployeeThreeInput"
        Me.lbEmployeeThreeInput.Size = New System.Drawing.Size(107, 104)
        Me.lbEmployeeThreeInput.TabIndex = 12
        Me.lbEmployeeThreeInput.Text = "&"
        Me.lbEmployeeThreeInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeThreeInput, "this is where you see your input")
        '
        'lbEmployeeOne
        '
        Me.lbEmployeeOne.Location = New System.Drawing.Point(42, 43)
        Me.lbEmployeeOne.Name = "lbEmployeeOne"
        Me.lbEmployeeOne.Size = New System.Drawing.Size(64, 24)
        Me.lbEmployeeOne.TabIndex = 7
        Me.lbEmployeeOne.Text = "&Employee 1"
        Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeOne, "Employee 1, 2 and 3")
        '
        'lbEmployeeTwo
        '
        Me.lbEmployeeTwo.Location = New System.Drawing.Point(144, 43)
        Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Size = New System.Drawing.Size(68, 24)
        Me.lbEmployeeTwo.TabIndex = 8
        Me.lbEmployeeTwo.Text = "&Employee 2"
        Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeTwo, "Employee 1, 2 and 3")
        '
        'lbEmployeeThree
        '
        Me.lbEmployeeThree.Location = New System.Drawing.Point(259, 43)
        Me.lbEmployeeThree.Name = "lbEmployeeThree"
        Me.lbEmployeeThree.Size = New System.Drawing.Size(68, 24)
        Me.lbEmployeeThree.TabIndex = 9
        Me.lbEmployeeThree.Text = "&Employee 3"
        Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbToolTip.SetToolTip(Me.lbEmployeeThree, "Employee 1, 2 and 3")
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Location = New System.Drawing.Point(12, 9)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(32, 13)
        Me.lbDay.TabIndex = 4
        Me.lbDay.Text = "&Day: "
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbToolTip.SetToolTip(Me.lbDay, "Day")
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(12, 30)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(37, 13)
        Me.lbUnits.TabIndex = 6
        Me.lbUnits.Text = "&Units: "
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbToolTip.SetToolTip(Me.lbUnits, "Units")
        '
        'tbUserInput
        '
        Me.tbUserInput.Location = New System.Drawing.Point(45, 23)
        Me.tbUserInput.Name = "tbUserInput"
        Me.tbUserInput.Size = New System.Drawing.Size(74, 20)
        Me.tbUserInput.TabIndex = 3
        Me.tbToolTip.SetToolTip(Me.tbUserInput, "Input your daily ships here!")
        '
        'lbNumberOfDay
        '
        Me.lbNumberOfDay.AutoSize = True
        Me.lbNumberOfDay.Location = New System.Drawing.Point(42, 9)
        Me.lbNumberOfDay.Name = "lbNumberOfDay"
        Me.lbNumberOfDay.Size = New System.Drawing.Size(7, 13)
        Me.lbNumberOfDay.TabIndex = 5
        Me.lbNumberOfDay.Text = "&"
        Me.lbToolTip.SetToolTip(Me.lbNumberOfDay, "displays the current day")
        '
        'frmEmployeeShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(360, 261)
        Me.Controls.Add(Me.lbNumberOfDay)
        Me.Controls.Add(Me.tbUserInput)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.lbEmployeeThree)
        Me.Controls.Add(Me.lbEmployeeTwo)
        Me.Controls.Add(Me.lbEmployeeOne)
        Me.Controls.Add(Me.lbEmployeeThreeInput)
        Me.Controls.Add(Me.lbEmployeeTwoInput)
        Me.Controls.Add(Me.lbEmployeeOneInput)
        Me.Controls.Add(Me.lbEmployeeThreeAverage)
        Me.Controls.Add(Me.lbEmployeeTwoAverage)
        Me.Controls.Add(Me.lbEmployeeOneAverage)
        Me.Controls.Add(Me.lbEmployeesAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbEmployeesAverage As Label
    Friend WithEvents lbEmployeeOneAverage As Label
    Friend WithEvents lbEmployeeTwoAverage As Label
    Friend WithEvents lbEmployeeThreeAverage As Label
    Friend WithEvents lbEmployeeOneInput As Label
    Friend WithEvents lbEmployeeTwoInput As Label
    Friend WithEvents lbEmployeeThreeInput As Label
    Friend WithEvents lbEmployeeOne As Label
    Friend WithEvents lbEmployeeTwo As Label
    Friend WithEvents lbEmployeeThree As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUserInput As TextBox
    Friend WithEvents lbNumberOfDay As Label
    Friend WithEvents lbToolTip As ToolTip
    Friend WithEvents btnToolTip As ToolTip
    Friend WithEvents tbToolTip As ToolTip
End Class
