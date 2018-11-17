Imports System.Data.SqlClient

Public Class UserLoginForm
    Dim connection As New SqlConnection("Server= JACOB; Database = Database_Final; Integrated Security = true")

    Private Sub NewUser_Click(sender As Object, e As EventArgs) Handles newUserButton.Click
        NewUserForm.Show()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submitButton.Click

    End Sub

End Class