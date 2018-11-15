Imports System.Data.SqlClient

Public Class CustomerForm
    'This opens the connection to the database. If you use it change the server name to your server name
    Dim connection As New SqlConnection("Server= JACOB; Database = MyGuitarShop; Integrated Security = true")

    'This is for the select button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Creates the command for the database
        'Set identity_insert table name on is needed or you might get an error
        'if the identity is set to false
        'after that just write a regular insert statement like you would in sql
        Dim command As New SqlCommand("SET IDENTITY_INSERT Customers on;insert into Customers(CustomerID, EmailAddress, Password, FirstName, LastName, ShippingAddressID, BillingAddressID) values(@cid,@pas,@email,@fn,@ln,@billing,@shipping)", connection)

        ' The first attribute in the add function is what you put as the values in the insert statement
        command.Parameters.Add("@cid", SqlDbType.Int).Value = TextBox8.Text
        command.Parameters.Add("@pas", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@billing", SqlDbType.Int).Value = TextBox5.Text
        command.Parameters.Add("@shipping", SqlDbType.Int).Value = TextBox6.Text

        'This line is used to actually open the connection to the database 
        connection.Open()

        ''ExecuteNonQuery() executes the sql query you wrote out above
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Customer Added")

        Else

            MessageBox.Show("Customer Not Added")

        End If

        'Closes the database connection
        connection.Close()
    End Sub

    'This is for the exit button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'This is for the delete button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim command As New SqlCommand("DELETE from Customers where CustomerID = @cid", connection)

        ' The first attribute in the add function is what you put as the values in the insert statement
        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = TextBox8.Text

        'This line is used to actually open the connection to the database 
        connection.Open()

        ''ExecuteNonQuery() executes the sql query you wrote out above
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Customer Deleted")

        Else

            MessageBox.Show("Customer Not Deleted")

        End If
    End Sub

    'This is for the get button
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim command As New SqlCommand("Select * From Customers Where CusomberID = @cid", connection)

        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = TextBox8.Text
    End Sub

End Class

