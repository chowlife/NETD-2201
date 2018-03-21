Option Strict On                ' Requirements for the lab
Imports System.Windows.Forms    ' Need this for the textbox thing not exactly sure why but yeah.

''' <summary>
''' Author:         John Adrian Urdaneta
''' Project Name:   Lab3
''' Date:           02/03/18
''' Description:    Basically the same thing as lab one, the only difference is that we're being ask to do display three employee's input
'''                 and calculates the average for each employees, after the third employee, disable controls and show the average for the
'''                 three employees.
''' Sources/Referrence: Google, Prof Alfred's sample codes and Murach 2015 VB (the book).
''' </summary>

Public Class frmEmployeeShipped

    ' Global Variables
    Const MAXIMUM_INPUT As Integer = 1000
    Const MINIMUM_INPUT As Integer = 0
    Const NUMBER_OF_DAYS As Integer = 7
    Dim sevenInputOne As Integer = 0
    Dim counterOne As Integer = 0


    ' An array to store the values based on days
    'Dim dayInput(NUMBER_OF_DAYS - 1) As Integer
    Dim dayInputOne(6) As Integer

    ' An array that stores the input passed and faield validation
    'Dim inputTracker(NUMBER_OF_DAYS - 1) As Boolean

    Private Sub frmEmployeeShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUserInput.Select()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Declaration
        Dim userInputOne As Integer = 0
        Dim inputAverage As Integer = 0

        ' Input 
        If Integer.TryParse(tbUserInput.Text, userInputOne) Then
            If (userInputOne >= MINIMUM_INPUT And userInputOne <= MAXIMUM_INPUT) Then

                dayInputOne(counterOne) = userInputOne
                lbEmployeeOneInput.Text += dayInputOne(counterOne).ToString() & vbCrLf
                sevenInputOne += dayInputOne(counterOne)

                counterOne += 1

                If counterOne = 7 Then

                    'tbUserInput.Enabled = False
                    'btnEnter.Enabled = False

                    inputAverage = CInt(sevenInputOne / (counterOne))
                    lbEmployeeOneAverage.Text = "Average: " + inputAverage.ToString

                Else
                    lbNumberOfDay.Text = (counterOne).ToString()

                    tbUserInput.Text = String.Empty
                    tbUserInput.Select()
                End If

            Else

                MessageBox.Show("ERROR: Input must be between 0 and 1000 inclusive!")

            End If

        Else

            MessageBox.Show("ERROR: Input must be a whole number!")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close the form
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm() ' Initialize the function
    End Sub
    ''' <summary>
    ''' Below is the ResetForm Function
    ''' </summary>
    Public Sub ResetForm()

        lbNumberOfDay.Text = String.Empty               ' Reset lbnumberOfDay
        tbUserInput.Text = String.Empty                 ' Reset tbUserInput
        '********************************
        lbEmployeeOneInput.Text = String.Empty           ' Reset lbEmployeeOne
        lbEmployeeTwoInput.Text = String.Empty           ' Reset lbEmployeeTwo
        lbEmployeeThreeInput.Text = String.Empty         ' Reset lbEmployeeThree
        '***************************************
        lbEmployeeOneAverage.Text = String.Empty        ' Reset lbEmployeeOneAverage
        lbEmployeeTwoAverage.Text = String.Empty        ' Reset lbEmployeeTwoAverage
        lbEmployeeThreeAverage.Text = String.Empty      ' Reset lbEmployeeThreeAverage
        '*****************************************
        lbEmployeesAverage.Text = String.Empty          ' Reset lbEmployeesAverage
        btnEnter.Enabled = True                         ' Enable the button again
        tbUserInput.Enabled = True                      ' Enable the textbox again
        counterOne = 0                                     ' Reset Counter
        sevenInputOne = 0                                  ' Reset holder
        tbUserInput.Select()
    End Sub

End Class
