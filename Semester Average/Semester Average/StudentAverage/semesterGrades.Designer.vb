<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.tbUserInput1 = New System.Windows.Forms.TextBox()
        Me.tbUserInput2 = New System.Windows.Forms.TextBox()
        Me.tbUserInput3 = New System.Windows.Forms.TextBox()
        Me.tbUserInput5 = New System.Windows.Forms.TextBox()
        Me.tbUserInput4 = New System.Windows.Forms.TextBox()
        Me.tbUserInput6 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbErrorOutput = New System.Windows.Forms.Label()
        Me.lbGradeLetter2 = New System.Windows.Forms.Label()
        Me.lbGradeLetter6 = New System.Windows.Forms.Label()
        Me.lbGradeLetter5 = New System.Windows.Forms.Label()
        Me.lbGradeLetter3 = New System.Windows.Forms.Label()
        Me.lbGradeLetter4 = New System.Windows.Forms.Label()
        Me.lbGradeLetter1 = New System.Windows.Forms.Label()
        Me.lbAverageLetter = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.TextBox()
        Me.lbCourse1Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbSemesterTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbErrorOutputTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbGradeLetter1Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbAverageLetterTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbUserInput1Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalculateTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnResetTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExitTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbCourse1
        '
        Me.lbCourse1.AutoSize = True
        Me.lbCourse1.Location = New System.Drawing.Point(22, 21)
        Me.lbCourse1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse1.TabIndex = 11
        Me.lbCourse1.Text = "&Course 1:"
        Me.lbCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse1, "Course 1 to 6")
        '
        'lbCourse2
        '
        Me.lbCourse2.AutoSize = True
        Me.lbCourse2.Location = New System.Drawing.Point(22, 44)
        Me.lbCourse2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse2.TabIndex = 12
        Me.lbCourse2.Text = "&Course 2:"
        Me.lbCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse2, "Course 1 to 6")
        '
        'lbCourse3
        '
        Me.lbCourse3.AutoSize = True
        Me.lbCourse3.Location = New System.Drawing.Point(22, 67)
        Me.lbCourse3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse3.TabIndex = 13
        Me.lbCourse3.Text = "&Course 3:"
        Me.lbCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse3, "Course 1 to 6")
        '
        'lbCourse4
        '
        Me.lbCourse4.AutoSize = True
        Me.lbCourse4.Location = New System.Drawing.Point(22, 89)
        Me.lbCourse4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse4.TabIndex = 14
        Me.lbCourse4.Text = "&Course 4:"
        Me.lbCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse4, "Course 1 to 6")
        '
        'lbCourse5
        '
        Me.lbCourse5.AutoSize = True
        Me.lbCourse5.Location = New System.Drawing.Point(22, 112)
        Me.lbCourse5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse5.TabIndex = 15
        Me.lbCourse5.Text = "&Course 5:"
        Me.lbCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse5, "Course 1 to 6")
        '
        'lbCourse6
        '
        Me.lbCourse6.AutoSize = True
        Me.lbCourse6.Location = New System.Drawing.Point(22, 135)
        Me.lbCourse6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(52, 13)
        Me.lbCourse6.TabIndex = 16
        Me.lbCourse6.Text = "&Course 6:"
        Me.lbCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCourse1Tip.SetToolTip(Me.lbCourse6, "Course 1 to 6")
        '
        'lbSemester
        '
        Me.lbSemester.AutoSize = True
        Me.lbSemester.Location = New System.Drawing.Point(22, 158)
        Me.lbSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(54, 13)
        Me.lbSemester.TabIndex = 17
        Me.lbSemester.Text = "&Semester:"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbSemesterTip.SetToolTip(Me.lbSemester, "Shows your semester average based on your grades that you store!")
        '
        'tbUserInput1
        '
        Me.tbUserInput1.Location = New System.Drawing.Point(79, 17)
        Me.tbUserInput1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput1.Name = "tbUserInput1"
        Me.tbUserInput1.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput1.TabIndex = 4
        Me.tbUserInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput1, "Insert your grade in numeric!")
        '
        'tbUserInput2
        '
        Me.tbUserInput2.Location = New System.Drawing.Point(79, 40)
        Me.tbUserInput2.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput2.Name = "tbUserInput2"
        Me.tbUserInput2.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput2.TabIndex = 5
        Me.tbUserInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput2, "Insert your grade in numeric!")
        '
        'tbUserInput3
        '
        Me.tbUserInput3.Location = New System.Drawing.Point(79, 63)
        Me.tbUserInput3.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput3.Name = "tbUserInput3"
        Me.tbUserInput3.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput3.TabIndex = 6
        Me.tbUserInput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput3, "Insert your grade in numeric!")
        '
        'tbUserInput5
        '
        Me.tbUserInput5.Location = New System.Drawing.Point(79, 108)
        Me.tbUserInput5.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput5.Name = "tbUserInput5"
        Me.tbUserInput5.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput5.TabIndex = 8
        Me.tbUserInput5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput5, "Insert your grade in numeric!")
        '
        'tbUserInput4
        '
        Me.tbUserInput4.Location = New System.Drawing.Point(79, 85)
        Me.tbUserInput4.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput4.Name = "tbUserInput4"
        Me.tbUserInput4.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput4.TabIndex = 7
        Me.tbUserInput4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput4, "Insert your grade in numeric!")
        '
        'tbUserInput6
        '
        Me.tbUserInput6.Location = New System.Drawing.Point(79, 131)
        Me.tbUserInput6.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserInput6.Name = "tbUserInput6"
        Me.tbUserInput6.Size = New System.Drawing.Size(76, 20)
        Me.tbUserInput6.TabIndex = 9
        Me.tbUserInput6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbErrorOutputTip.SetToolTip(Me.tbUserInput6, "Insert your grade in numeric!")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(49, 333)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(63, 19)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculateTip.SetToolTip(Me.btnCalculate, "Press the button or Enter to input numbers!")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(116, 333)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(56, 19)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnCalculateTip.SetToolTip(Me.btnReset, "Press the button  or ESC key to reset form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(177, 333)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 19)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnCalculateTip.SetToolTip(Me.btnExit, "Press the button to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbErrorOutput
        '
        Me.lbErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbErrorOutput.Location = New System.Drawing.Point(13, 175)
        Me.lbErrorOutput.Name = "lbErrorOutput"
        Me.lbErrorOutput.Size = New System.Drawing.Size(221, 156)
        Me.lbErrorOutput.TabIndex = 3
        Me.lbErrorOutput.Text = "&"
        Me.lbErrorOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbErrorOutputTip.SetToolTip(Me.lbErrorOutput, "Shows error list here!")
        '
        'lbGradeLetter2
        '
        Me.lbGradeLetter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter2.Location = New System.Drawing.Point(157, 40)
        Me.lbGradeLetter2.Name = "lbGradeLetter2"
        Me.lbGradeLetter2.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter2.TabIndex = 19
        Me.lbGradeLetter2.Text = "&"
        Me.lbGradeLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter2, "Shows your letter grade based on your input!")
        '
        'lbGradeLetter6
        '
        Me.lbGradeLetter6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter6.Location = New System.Drawing.Point(158, 132)
        Me.lbGradeLetter6.Name = "lbGradeLetter6"
        Me.lbGradeLetter6.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter6.TabIndex = 23
        Me.lbGradeLetter6.Text = "&"
        Me.lbGradeLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter6, "Shows your letter grade based on your input!")
        '
        'lbGradeLetter5
        '
        Me.lbGradeLetter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter5.Location = New System.Drawing.Point(158, 108)
        Me.lbGradeLetter5.Name = "lbGradeLetter5"
        Me.lbGradeLetter5.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter5.TabIndex = 22
        Me.lbGradeLetter5.Text = "&"
        Me.lbGradeLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter5, "Shows your letter grade based on your input!")
        '
        'lbGradeLetter3
        '
        Me.lbGradeLetter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter3.Location = New System.Drawing.Point(157, 63)
        Me.lbGradeLetter3.Name = "lbGradeLetter3"
        Me.lbGradeLetter3.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter3.TabIndex = 20
        Me.lbGradeLetter3.Text = "&"
        Me.lbGradeLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter3, "Shows your letter grade based on your input!")
        '
        'lbGradeLetter4
        '
        Me.lbGradeLetter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter4.Location = New System.Drawing.Point(157, 85)
        Me.lbGradeLetter4.Name = "lbGradeLetter4"
        Me.lbGradeLetter4.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter4.TabIndex = 21
        Me.lbGradeLetter4.Text = "&"
        Me.lbGradeLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter4, "Shows your letter grade based on your input!")
        '
        'lbGradeLetter1
        '
        Me.lbGradeLetter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGradeLetter1.Location = New System.Drawing.Point(157, 17)
        Me.lbGradeLetter1.Name = "lbGradeLetter1"
        Me.lbGradeLetter1.Size = New System.Drawing.Size(76, 20)
        Me.lbGradeLetter1.TabIndex = 18
        Me.lbGradeLetter1.Text = "&"
        Me.lbGradeLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGradeLetter1Tip.SetToolTip(Me.lbGradeLetter1, "Shows your letter grade based on your input!")
        '
        'lbAverageLetter
        '
        Me.lbAverageLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageLetter.Location = New System.Drawing.Point(157, 154)
        Me.lbAverageLetter.Name = "lbAverageLetter"
        Me.lbAverageLetter.Size = New System.Drawing.Size(76, 20)
        Me.lbAverageLetter.TabIndex = 24
        Me.lbAverageLetter.Text = "&"
        Me.lbAverageLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbAverageLetterTip.SetToolTip(Me.lbAverageLetter, "Shows your average grade in letter form!")
        '
        'lbAverage
        '
        Me.lbAverage.Location = New System.Drawing.Point(79, 154)
        Me.lbAverage.Margin = New System.Windows.Forms.Padding(2)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.ReadOnly = True
        Me.lbAverage.Size = New System.Drawing.Size(76, 20)
        Me.lbAverage.TabIndex = 10
        Me.lbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lbSemesterTip.SetToolTip(Me.lbAverage, "Shows your semester average based on your grades that you store!")
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(238, 353)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbAverageLetter)
        Me.Controls.Add(Me.lbGradeLetter1)
        Me.Controls.Add(Me.lbGradeLetter4)
        Me.Controls.Add(Me.lbGradeLetter3)
        Me.Controls.Add(Me.lbGradeLetter5)
        Me.Controls.Add(Me.lbGradeLetter6)
        Me.Controls.Add(Me.lbGradeLetter2)
        Me.Controls.Add(Me.lbErrorOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbUserInput6)
        Me.Controls.Add(Me.tbUserInput4)
        Me.Controls.Add(Me.tbUserInput5)
        Me.Controls.Add(Me.tbUserInput3)
        Me.Controls.Add(Me.tbUserInput2)
        Me.Controls.Add(Me.tbUserInput1)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.lbCourse1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Average"
        Me.tbUserInput1Tip.SetToolTip(Me, "Insert your grade in numeric!")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourse1 As Windows.Forms.Label
    Friend WithEvents lbCourse2 As Windows.Forms.Label
    Friend WithEvents lbCourse3 As Windows.Forms.Label
    Friend WithEvents lbCourse4 As Windows.Forms.Label
    Friend WithEvents lbCourse5 As Windows.Forms.Label
    Friend WithEvents lbCourse6 As Windows.Forms.Label
    Friend WithEvents lbSemester As Windows.Forms.Label
    Friend WithEvents tbUserInput1 As Windows.Forms.TextBox
    Friend WithEvents tbUserInput2 As Windows.Forms.TextBox
    Friend WithEvents tbUserInput3 As Windows.Forms.TextBox
    Friend WithEvents tbUserInput5 As Windows.Forms.TextBox
    Friend WithEvents tbUserInput4 As Windows.Forms.TextBox
    Friend WithEvents tbUserInput6 As Windows.Forms.TextBox
    Friend WithEvents btnCalculate As Windows.Forms.Button
    Friend WithEvents btnReset As Windows.Forms.Button
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents lbErrorOutput As Windows.Forms.Label
    Friend WithEvents lbGradeLetter2 As Windows.Forms.Label
    Friend WithEvents lbGradeLetter6 As Windows.Forms.Label
    Friend WithEvents lbGradeLetter5 As Windows.Forms.Label
    Friend WithEvents lbGradeLetter3 As Windows.Forms.Label
    Friend WithEvents lbGradeLetter4 As Windows.Forms.Label
    Friend WithEvents lbGradeLetter1 As Windows.Forms.Label
    Friend WithEvents lbAverageLetter As Windows.Forms.Label
    Friend WithEvents lbAverage As Windows.Forms.TextBox
    Friend WithEvents lbCourse1Tip As Windows.Forms.ToolTip
    Friend WithEvents lbSemesterTip As Windows.Forms.ToolTip
    Friend WithEvents lbErrorOutputTip As Windows.Forms.ToolTip
    Friend WithEvents lbGradeLetter1Tip As Windows.Forms.ToolTip
    Friend WithEvents lbAverageLetterTip As Windows.Forms.ToolTip
    Friend WithEvents tbUserInput1Tip As Windows.Forms.ToolTip
    Friend WithEvents btnCalculateTip As Windows.Forms.ToolTip
    Friend WithEvents btnResetTip As Windows.Forms.ToolTip
    Friend WithEvents btnExitTip As Windows.Forms.ToolTip
End Class
