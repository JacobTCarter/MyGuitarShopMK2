Public Class EmployeeListForm
    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub newEmployeeButton_Click(sender As Object, e As EventArgs) Handles newEmployeeButton.Click
        NewEmployeeForm.Show()
        Me.Close()
    End Sub
End Class