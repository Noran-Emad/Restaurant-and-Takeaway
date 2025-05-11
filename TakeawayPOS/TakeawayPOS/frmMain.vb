Public Class frmMain
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.Open()

        openLogin()
    End Sub

    Private Sub btnLogIn_Click(sender As System.Object, e As System.EventArgs) Handles btnLogIn.Click
        openLogin()
    End Sub

    Private Sub openLogin()
        Me.Hide()
        Dim frmLog As New frmLogIn()
        frmLog.ShowDialog()
        If MFlag Then
            Me.Show()
        End If
    End Sub


End Class