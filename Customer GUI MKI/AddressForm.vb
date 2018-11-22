Imports System.Data.SqlClient

Public Class AddressForm
    'OVERALL CONNECTION
    Dim connection As New SqlConnection("Server= DESKTOP-IGRIGM7; Database = Database_Final; Integrated Security = true")

    'UPDATE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim update As New SqlCommand("UPDATE ADDRESSES SET AddressID = @aid, CustomerID = @cid, Line1 = @line1, Line2 = @line2, City = @city, State = @state, ZipCode = @zip, Phone = @phone WHERE CustomerID = @cid AND AddressID = @aid", connection)

        connection.Open()


        update.Parameters.Add("@line1", SqlDbType.VarChar).Value = ShippingLine1_TB.Text
        update.Parameters.Add("@line2", SqlDbType.VarChar).Value = ShippingLine2_TB.Text
        update.Parameters.Add("@city", SqlDbType.VarChar).Value = ShippingCity_TB.Text
        update.Parameters.Add("@state", SqlDbType.VarChar).Value = ShippingState_TB.Text
        update.Parameters.Add("@zip", SqlDbType.Int).Value = ShippingZip_TB.Text
        update.Parameters.Add("@phone", SqlDbType.VarChar).Value = ShippingPhone_TB.Text

        connection.Close()

        update.ExecuteNonQuery()

        If (CheckBox1.Checked) Then
            Dim update2 As New SqlCommand("UPDATE ADDRESSES SET AddressID = @aid, CustomerID = @cid, Line1 = @line1, Line2 = @line2, City = @city, State = @state, ZipCode = @zip, Phone = @phone WHERE CustomerID = @cid AND AddressID = @aid", connection)

            connection.Open()

            'update2.Parameters.Add("@aid", SqlDbType.Int).Value = findAID
            'update2.Parameters.Add("@cid", SqlDbType.Int).Value = findCID
            update2.Parameters.Add("@line1", SqlDbType.VarChar).Value = BillingLine1_TB.Text
            update2.Parameters.Add("@line2", SqlDbType.VarChar).Value = BillingLine2_TB.Text
            update2.Parameters.Add("@city", SqlDbType.VarChar).Value = BillingCity_TB.Text
            update2.Parameters.Add("@state", SqlDbType.VarChar).Value = BillingState_TB.Text.ToUpper
            update2.Parameters.Add("@zip", SqlDbType.Int).Value = BillingZip_TB.Text
            update2.Parameters.Add("@phone", SqlDbType.VarChar).Value = BillingPhone_TB.Text

            connection.Close()
            update2.ExecuteNonQuery()
        End If
    End Sub

    'EXIT
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub




End Class

