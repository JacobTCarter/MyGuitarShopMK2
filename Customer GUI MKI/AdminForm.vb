Public Class AdminForm
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub employeeListButton_Click(sender As Object, e As EventArgs) Handles employeeListButton.Click
        EmployeeListForm.Show()
    End Sub

    Private Sub productListButton_Click(sender As Object, e As EventArgs) Handles productListButton.Click
        ProductListForm.Show()
    End Sub
End Class