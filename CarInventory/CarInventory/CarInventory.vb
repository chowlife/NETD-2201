﻿Option Strict On
Imports System.Collections  ' For dictionary entry
Imports System.Windows.Forms ' For Event Rags
''' <summary>
''' Author Name:    John Urdaneta
''' Project Name:   CarInventory
''' Date:           20th March 2018
''' Reference:      Google, Prof Alfred's Sample Code, and the Murach VB 2015
''' Description:    Application to keep a list of cars and their information that makes them appealing to the buyer(s)
''' </summary>
Public Class frmCarInventory

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False



    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As ListOfCars          ' declare a Car class
        Dim carItem As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lbOutput.Text = "It worked!"


            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object with the parameterized constructor
                car = New ListOfCars(cmbMake.Text, tbModel.Text, cmbYear.Text, tbPrice.Text, chkNew.Checked)


                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), ListOfCars)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = tbModel.Text
                car.Price = tbPrice.Text
                car.NewStatus = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwResult.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, ListOfCars)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.NewStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Price)

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwResult.Items.Add(carItem)

            Next carEntry

            ' Reset the inputed values
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    Private Sub Reset()


        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lbOutput.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        If cmbMake.SelectedIndex = -1 Then

            outputMessage += "Please select the car make." & vbCrLf


            returnValue = False

        End If


        If tbModel.Text.Trim.Length = 0 Then

            outputMessage += "Please enter the car model." & vbCrLf

            returnValue = False

        End If


        If cmbYear.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If tbPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbOutput.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub


    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwResult.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub


    Private Sub lvwResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwResult.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the cars identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the car identification number 
        currentCarIdentificationNumber = lvwResult.Items(lvwResult.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the car identification number to get the car from the collection object
        Dim car As ListOfCars = CType(carList.Item(currentCarIdentificationNumber), ListOfCars)

        ' set the controls on the form
        cmbMake.Text = car.Make
        tbModel.Text = car.Model
        cmbYear.Text = car.Year
        tbPrice.Text = car.Price

        chkNew.Checked = car.NewStatus ' get the new status and set combo box 

        lbOutput.Text = car.GetInformation()


    End Sub

End Class