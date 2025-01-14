Public Class frmSortGames
    Private Sub frmSortGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Array.Sort(frmGames._strGames)
        For Each strGame As String In frmGames._strGames
            If strGame IsNot Nothing Then
                lstSortedGames.Items.Add(strGame)
            End If
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmGames As New frmGames()
        frmGames.Show()
        Close()
    End Sub
End Class