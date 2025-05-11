Imports System.Data.SqlClient

Public Class frmLogIn
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        checkPassword()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MFlag = True
            Me.Close()
        End If
    End Sub

    Private Sub checkPassword()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "SELECT id, name FROM Staff WHERE username = @username AND password = @password AND is_active = 1"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            staffName = reader("name").ToString()
            staffId = Convert.ToInt32(reader("id"))
            MessageBox.Show("Welcome " & staffName)
            Dim frmctrl As New frmControl()
            frmctrl.Show()
            MFlag = False
            Me.Close()
        Else
            lblStatus.Text = "Invalid username or password."
            lblStatus.ForeColor = Color.Red
            lblStatus.TextAlign = ContentAlignment.MiddleCenter
        End If
        reader.Close()
    End Sub

End Class
