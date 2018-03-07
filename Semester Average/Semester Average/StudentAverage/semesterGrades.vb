Option Strict On                ' Requirements for the lab
Imports System.Windows.Forms    ' Need this for the textbox thing not exactly sure why but yeah.

''' <summary>
''' Author:         John Urdaneta
''' Project Name:   Lab2
''' Date:           18-Feb-2018
''' Description:    Demonstrate the understanding in chapters 1,2,3,4,5 and 8.
'''                 User is asked to input six courses grade Then display the
'''                 lettered grade ex. A+, B+, etc. Once the input for the sixth
'''                 course is done, calculate the gpa for that semester and
'''                 display the lettered grade for the gpa.
''' Sources/Referrence: Google, Prof Alfred's sample codes and Murach 2015 VB.
''' </summary>


Public Class frmSemesterGrades
    ' Declaring global variables to use through out the form
    Const gradeMinimum As Double = 0.00              ' Minimum Input for grade
    Const gradeMaximum As Double = 100.0             ' Maximum Input for grade
    '**************************************
    ' hold grades
    Dim gradeOne As Double = 0.0
    Dim gradeTwo As Double = 0.0
    Dim gradeThree As Double = 0.0
    Dim gradeFour As Double = 0.0
    Dim gradeFive As Double = 0.0
    Dim gradeSix As Double = 0.0
    ' User input
    Dim userInput1 As Double = 0.00
    Dim userInput2 As Double = 0.00
    Dim userInput3 As Double = 0.00
    Dim userInput4 As Double = 0.00
    Dim userInput5 As Double = 0.00
    Dim userInput6 As Double = 0.00
    ' Grade Letter Variables
    Const gradeAPlusLetter As String = "A+"
    Const gradeALetter As String = "A"
    Const gradeAMinusLetter As String = "A-"
    Const gradeBPlusLetter As String = "B+"
    Const gradeBLetter As String = "B"
    Const gradeBMinusLetter As String = "B-"
    Const gradeCPlusLetter As String = "C+"
    Const gradeCLetter As String = "C"
    Const gradeCMinusLetter As String = "C-"
    Const gradeDPlusLetter As String = "D+"
    Const gradeDLetter As String = "D"
    Const gradeDMinusLetter As String = "D-"
    Const gradeFailedLetter As String = "F"
    '**************************************
    'Grade Percent Number
    Const gradeAPlus As Double = 0.9
    Const gradeA As Double = 0.85
    Const gradeAMinus As Double = 0.8
    Const gradeBPlus As Double = 0.77
    Const gradeB As Double = 0.73
    Const gradeBMinus As Double = 0.7
    Const gradeCPlus As Double = 0.67
    Const gradeC As Double = 0.63
    Const gradeCMinus As Double = 0.6
    Const gradeDPlus As Double = 0.57
    Const gradeD As Double = 0.53
    Const gradeDMinus As Double = 0.5
    Const gradeFailed As Double = 0.49


    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show() ' Show stuff
        tbUserInput1.Select() ' Selects the first textbox when the form loads
    End Sub

    Private Sub tbUserInput1_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox)

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeOne)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter1.Text = DetermineGrade(gradeOne)
                'grades(0) = grade
                userInput1 = gradeOne

                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'SetFocusTextBox(gradeControl)
            End If

        End If

    End Sub

    Private Sub tbUserInput2_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox)

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeTwo)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter2.Text = DetermineGrade(gradeTwo)
                userInput2 = gradeTwo

                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'setFocusTextBox(gradeControl)
            End If

        End If

    End Sub

    Private Sub tbUserInput3_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox)

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeThree)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter3.Text = DetermineGrade(gradeThree)
                userInput3 = gradeThree

                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'setFocusTextBox(gradeControl)
            End If

        End If

    End Sub

    Private Sub tbUserInput4_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox)

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeFour)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter4.Text = DetermineGrade(gradeFour)
                userInput4 = gradeFour
                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'setFocusTextBox(gradeControl)
            End If

        End If

    End Sub

    Private Sub tbUserInput5_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox)

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeFive)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter5.Text = DetermineGrade(gradeFive)
                userInput5 = gradeFive

                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'setFocusTextBox(gradeControl)
            End If

        End If

    End Sub


    Private Sub tbUserInput6_LostFocus(sender As Object, e As EventArgs) Handles tbUserInput1.LostFocus

        Dim gradeControl As TextBox = CType(sender, TextBox) ' Convert object to a textbox

        ' If the control has data in its text property
        If (gradeControl.Text.Trim.Length > 0) Then

            ' Try to convert the control text to
            ' a grade by passing it to the try grade method
            If (TryGrade(gradeControl.Text, gradeSix)) Then

                ' Get the letter grade from the determineGrade method
                lbGradeLetter6.Text = DetermineGrade(gradeSix)
                userInput6 = gradeSix
                ' If it is valid
                lbErrorOutput.Text = String.Empty

            Else

                ' If it is invalid
                lbErrorOutput.Text = "Please ensure that what you input is a number between " & gradeMinimum & " and " & gradeMaximum & ", Thank You"


                ' Display a message and set the focus
                ' back to the control
                'setFocusTextBox(gradeControl)
            End If

        End If

    End Sub

    ''' <summary>
    ''' Calculates the average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim studentTotal As Double              ' Adds the 6 courses grade together
        Dim studentAverage As Double            ' Finds the average by dividing variable studentTotal by numberOfClasses
        Const numberOfClasses As Integer = 6    ' A constant for the 6 courses

        ' Convert textboxes inputs to double
        ' then store data in userInput(1-6)
        userInput1 = CDbl(tbUserInput1.Text)
        userInput2 = CDbl(tbUserInput2.Text)
        userInput3 = CDbl(tbUserInput3.Text)
        userInput4 = CDbl(tbUserInput4.Text)
        userInput5 = CDbl(tbUserInput5.Text)
        userInput6 = CDbl(tbUserInput6.Text)

        ' Calculate
        studentTotal = ((userInput1 + userInput2 + userInput3 + userInput4 + userInput5 + userInput6))
        studentAverage = studentTotal / numberOfClasses
        lbAverage.Text = CType(studentAverage, String)

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm() ' reset form
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()  ' Close the form
    End Sub

    ''' <summary>
    ''' Determines the letter grade that the user is going to get
    ''' </summary>
    ''' <param name="numberGrade"></param>
    ''' <returns></returns>
    Private Function DetermineGrade(ByVal numberGrade As Double) As String

        Dim returnGrade As String = gradeAPlusLetter

        Select Case numberGrade

            Case Is < gradeFailed

                ' Set the letter grade
                returnGrade = gradeFailedLetter

            Case Is < gradeDMinus

                ' Set the letter grade
                returnGrade = gradeDPlusLetter

            Case Is < gradeD

                ' Set the letter grade
                returnGrade = gradeDMinusLetter

            Case Is < gradeDPlus

                ' Set the letter grade
                returnGrade = gradeDLetter

            Case Is < gradeCMinus

                ' Set the letter grade
                returnGrade = gradeCPlusLetter

            Case Is < gradeC

                ' Set the letter grade
                returnGrade = gradeCMinusLetter

            Case Is < gradeCPlus

                ' Set the letter grade
                returnGrade = gradeCLetter

            Case Is < gradeBMinus

                ' Set the letter grade
                returnGrade = gradeBPlusLetter

            Case Is < gradeB

                ' Set the letter grade
                returnGrade = gradeBMinusLetter

            Case Is < gradeBPlus

                ' Set the letter grade
                returnGrade = gradeBLetter

            Case Is < gradeAMinus

                ' Set the letter grade
                returnGrade = gradeAPlusLetter

            Case Is < gradeA

                ' Set the letter grade
                returnGrade = gradeAMinusLetter

            Case Is < gradeAPlus

                ' Set the letter grade
                returnGrade = gradeALetter
        End Select

    End Function

    ''' <summary>
    ''' Function that utilizes the IsValidGrade function
    ''' checks each textboxes for empty inputs
    ''' </summary>
    ''' <param name="gradeText"></param>
    ''' <param name="numberGrade"></param>
    ''' <returns></returns>
    Private Function TryGrade(ByVal gradeText As String, ByRef numberGrade As Double) As Boolean

        Dim returnValue = False ' Declare a variable to return a boolean

        ' Check if grade is valid
        If (IsValidGrade()) Then

            ' If it is then convert
            ' the string to a double
            numberGrade = CType(gradeText, Double)

            ' Set the return value to true
            returnValue = True
        Else

            ' Do something, not really sure what to put here.
        End If

        Return False
    End Function

    ''' <summary>
    ''' Function to check if input is valid
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValidGrade() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        ' check if user entered something
        If tbUserInput1.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if user entered something
        If tbUserInput2.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if user entered something
        If tbUserInput3.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if user entered something
        If tbUserInput4.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if user entered something
        If tbUserInput5.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if user entered something
        If tbUserInput6.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Enter an integer " & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbErrorOutput.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    'Private Sub setFocusTextBox(gradeControl As TextBox)

    'End Sub


    ''' <summary>
    ''' Function for reseting the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ResetForm()
        tbUserInput1.Text = String.Empty                    ' Empty the text box
        tbUserInput2.Text = String.Empty
        tbUserInput3.Text = String.Empty
        tbUserInput4.Text = String.Empty
        tbUserInput5.Text = String.Empty
        tbUserInput6.Text = String.Empty
        ''********************************
        lbGradeLetter1.Text = String.Empty                  ' Empty the box that display user's input
        lbGradeLetter2.Text = String.Empty
        lbGradeLetter3.Text = String.Empty
        lbGradeLetter4.Text = String.Empty
        lbGradeLetter5.Text = String.Empty
        lbGradeLetter6.Text = String.Empty
        lbAverage.Text = String.Empty
        lbAverageLetter.Text = String.Empty
        ''********************************
        lbErrorOutput.Text = String.Empty                   ' Empty the average box
        ''********************************
        btnCalculate.Enabled = True                         ' Make the calculate button functional/clickable
        ''********************************
        tbUserInput1.Enabled = True                         ' Make the text boxs functional/clickable
        tbUserInput2.Enabled = True
        tbUserInput3.Enabled = True
        tbUserInput4.Enabled = True
        tbUserInput5.Enabled = True
        tbUserInput6.Enabled = True
        ''********************************
        tbUserInput1.Focus()                                 ' Put the focus on the first text box 
        'Array.Clear(numberOfUnits, 0, numberOfUnits.Length) ' Reset the array
    End Sub

End Class