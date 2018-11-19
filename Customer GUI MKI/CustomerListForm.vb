Public Class CustomerListForm
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        CustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub
End Class