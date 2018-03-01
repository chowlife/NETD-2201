'Option Strict On
''' <summary>
''' Author:         John Urdaneta
''' Project Name:   AverageShipped
''' Date:           02-02-18
''' Description:    Demonstrate the understanding in chapters 1,2,3,4,5 and 8.
'''                 take an input for each day in the week numbered from 1 to 7,
'''                 Then calculates the average for the input in those 7 days.
''' </summary>


Public Class frmAverageShipped
    ' Declare the number of days as long as the form/class lives.
    Private numberOfDays As Integer = 0 ' Governs the number of days in a week
    ''' <summary>
    ''' btnEnter_Click - enters users input and calls the function 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Variables
        'Dim numberOne As Double = 2 
        'Dim numberTwo As Double = 5
        Dim daysInAWeek As Integer = 1

        'numberOfDays += Add(numberOne, numberTwo)
        Dim convertedValue As Integer = 0
        Dim minimumInput As Integer = 0
        Dim maximumOuput As Integer = 1000
        Dim userInput As Integer                     'holds the user input as a string
        Dim userInputDouble As Double = 0.0          'holds the user input to convert to double just incase
        'Dim userInputInteger As Integer = 0         'holds the user input to convert to integer just incase
        'Dim output As String = String.Empty         'holds the output to be displayed to the user
        'Dim showDays(7) As Integer                  'holds the number of days in a week
        'Const minimumarraysize As Integer = 1
        'If String.IsNullOrWhiteSpace(userInput) Then
        '    Throw New ArgumentException("Input cannot be blank! ")
        'End If

        For numberOfDays As Integer = 1 To daysInAWeek
            lbNumberOfDays.Text = numberOfDays.ToString
        Next

        userInput = Integer.Parse(tbUserInput.Text)
        lbDisplayInput.Text = userInput
        'If Integer.TryParse(userInput, convertedValue) Then
        '    If convertedValue < minimumInput OrElse convertedValue >= maximumOuput Then
        '        MsgBox("Invalid entry, please try agian!", userInput)
        '    End If
        'End If
        '    userinput = tbUserInput.Text                'get the input from the textbox

        '    If (Double.TryParse(userinput, userinputdouble)) Then           ' if the input is a double

        '        If (Integer.TryParse(userinput, userinputinteger) AndAlso   ' if the input is an integer
        '        userinputinteger >= minimumarraysize) Then              ' also, there must be at least 1 element
        '            processing
        '        End If
        '    End If
    End Sub

    ''' <summary>
    ''' Add -  Adds two numbers 
    '''     *** Function is a self contained area of code that contains one or more lines of code that can be called by another procedure and returns a value to the calling code.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns>Double - the sum of the two arguments passed to the Method/Function</returns>
    'Private Function Add(numberOne As Double, numberTwo As double) As Double
    '    ' Declare a return value variable
    '    Dim returnValue As Double 

    '    ' Add number one parameter to number two parameter
    '    ' And assign it to return value
    '    returnValue = numberOne + numberTwo

    '    ' Return the return value variable
    '    Return returnValue
    'End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This resets the textbox and output.
        tbUserInput.ResetText()
        lbDisplayInput.ResetText()
        lbDisplayAverage.ResetText()

        ' Resets the number of days
        lbNumberOfDays.ResetText()
    End Sub

    Private Sub tbUserInput_TextChanged(sender As Object, e As EventArgs) Handles tbUserInput.TextChanged

    End Sub

End Class
