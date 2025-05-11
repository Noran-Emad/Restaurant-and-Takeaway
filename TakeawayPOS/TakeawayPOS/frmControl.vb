Public Class frmControl

    Private Sub btnTakeAway_Click(sender As System.Object, e As System.EventArgs) Handles btnTakeAway.Click
        Me.Hide()
        Dim frmTake As New frmTakeaway
        frmTake.ShowDialog()
        Me.Show()
    End Sub

End Class