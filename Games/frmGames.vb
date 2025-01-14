' Program Name: Most Popular Games
' Date: January 14, 2025
' Author: K Bola
' Purpose: This application displays the top 10 selling mobile video games of all times and the number of paid downloads in millions

Public Class frmGames
    Public Shared _intSizeOfArray As Integer = 10
    Public Shared _strGames(_intSizeOfArray) As String
    Private _strDownloads(_intSizeOfArray) As String
    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "C:\Users\HELLO\Source\Repos\Games\mobile.txt"
        Dim strErrorMessage As String = "File not found"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        ' Verify if file exists
        If IO.File.Exists(strFileLocation) Then
            ' Open it
            objReader = IO.File.OpenText(strFileLocation)
            ' Read it
            Do While objReader.Peek <> -1
                _strGames(intCount) = objReader.ReadLine()
                _strDownloads(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To _strGames.Length - 1
                If _strGames(intFill) IsNot Nothing Then
                    lstGames.Items.Add(_strGames(intFill))
                End If
            Next
        Else
            MsgBox(strErrorMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
        End If
        lblNumberOfDownloads.Text = ""
        lblTotalDownloads.Text = ""
    End Sub

    Private Sub lstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged
        Dim intSelectedIndex As Integer = lstGames.SelectedIndex
        If intSelectedIndex >= 0 And intSelectedIndex < _strDownloads.Length Then
            lblNumberOfDownloads.Text = "Paid Downloads: " & _strDownloads(intSelectedIndex) & " million."
        Else
            lblNumberOfDownloads.Text = ""
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim totalDownloads As Integer = 0
        For Each downloads As String In _strDownloads
            If IsNumeric(downloads) Then
                totalDownloads += Convert.ToInt32(downloads)
            End If
        Next
        lblTotalDownloads.Text = "Total Paid Downloads: " & totalDownloads & " million."
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblNumberOfDownloads.Text = ""
        lblTotalDownloads.Text = ""
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmSort As New frmSortGames()
        Hide()
        frmSort.ShowDialog()
    End Sub
End Class
