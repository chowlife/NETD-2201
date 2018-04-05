Option Strict On
Imports System.IO ' For input and Output


''' <summary>
''' Author:         John Urdaneta
''' Date:           April 4th 2018
''' Program:        Lab 5: Text Editor
''' Description:    This program demonstrates the understanding in making a text editor.
''' Referrals:      Previous Labs, Google, Prof Alfred Sample Codes, and Murach VB 2015      
''' </summary>

Public Class frmTextEditor
    Dim filePath As String = String.Empty ' Declaring variable to store file path

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close() ' Close Form
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click

        Dim saveFileDialog As New SaveFileDialog ' To open a dialog
        Dim outputText As String = String.Empty ' Holds the input data in the text box

        outputText = tbText.Text

        saveFileDialog.Filter = "text file (*.txt)|*.txt" ' Set filter

        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            filePath = saveFileDialog.FileName ' Grab full file path

            Save(filePath, outputText) ' Save file

        End If

    End Sub

    Private Sub Save(fullFilePath As String, outputText As String)

        Dim fileStream As New FileStream(fullFilePath, FileMode.Create, FileAccess.Write) ' For access, creating, and write files

        Dim writeStream As New StreamWriter(fileStream)

        writeStream.Write(outputText)

        writeStream.Close()

    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

        Dim openFileDialog As New OpenFileDialog 'to display open file dialogbox
        Dim outputText As String = String.Empty 'to store values from text box as string

        openFileDialog.Filter = "text file (*.txt)|*.txt" 'to set filter for only text files

        If openFileDialog.ShowDialog() = DialogResult.OK Then 'if user click OK

            filePath = openFileDialog.FileName 'to store file path as string

            If File.Exists(filePath) Then 'to make sure that the file really exist

                tbText.Text = OpenFile(filePath) 'to call openFile function

            End If

        End If

    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Dim outputText As String = String.Empty 'initializing text to empty string

        outputText = tbText.Text 'to store values of tbEditor as string

        Save(filePath, outputText) 'call save function

    End Sub


    ''' <summary>
    ''' Mini Sub Routines to call below
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click

        NewDocument() 'to call newDocument subroutine

    End Sub

    Private Sub NewDocument()

        tbText.Clear() ' Clear TextBox
        filePath = String.Empty ' Reset

    End Sub

    Private Sub Cut()

        tbText.Cut() ' Cut

    End Sub

    Private Sub Copy()

        tbText.Copy() ' Copy

    End Sub

    Private Sub Paste()

        tbText.Paste() ' Paste

    End Sub


    ''' <summary>
    ''' Using the little sub routine above to call
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Copy() ' Call the sub copy
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Cut() ' Call the sub cut
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        Paste() ' Call the sub Paste
    End Sub


    ''' <summary>
    ''' The about stuff
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        ' Display the required about to user
        MessageBox.Show("@Purpose: NETD2202-LAB 5" + vbCrLf + "@Author: John Urdaneta")

    End Sub

    ''' <summary>
    ''' Function for Opening Files
    ''' </summary>
    ''' <param name="fullFilePath"></param>
    ''' <returns></returns>
    Private Function OpenFile(fullFilePath As String) As String

        Dim fileContent As String = String.Empty 'declare variable to store file contents
        Dim fileStream As New FileStream(fullFilePath, FileMode.Open, FileAccess.Read) 'to initiate fullFilePath, file mode and file access
        Dim streamReader As New StreamReader(fileStream) 'to initiate write stream

        fileContent = streamReader.ReadToEnd

        streamReader.Close()

        Return fileContent 'return fileContent

    End Function
End Class
