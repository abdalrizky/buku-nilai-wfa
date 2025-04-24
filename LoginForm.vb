Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "admin" AndAlso password = "admin" Then
            MainMenuForm.Show()
            Hide()
        Else
            MessageBox.Show("Username atau password salah.")
        End If
    End Sub
End Class