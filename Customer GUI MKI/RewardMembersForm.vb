Imports System.Data.SqlClient

Public Class RewardMembersForm


    Private Sub Showcustomers_Click(sender As Object, e As EventArgs) Handles Showcustomers.Click

        'This opens the connection to the database. If you use it change the server name to your server name
        Dim conString As String = "Server= laptop-s17tou1u; Database = Database_Final; Integrated Security = false"
        Dim conSQL As New SqlConnection(conString)
        Dim con As New SqlConnection(conString)

        Try

            con.Open()

            Dim sql As String = "SELECT * FROM Rewards_Specification;"

            Dim cmd As New SqlCommand(sql, con)

            Dim myreader As SqlDataReader = cmd.ExecuteReader()


            'Console.WriteLine()

            Console.WriteLine("=============================")

            While myreader.Read()

                Console.Write(myreader("Firstname").ToString() & ", ")

                Console.Write(myreader("Lastname").ToString() & ", ")

                Console.WriteLine("")

            End While

        Catch ex As SqlException

            Console.WriteLine("Error: " & ex.ToString())

        End Try

    End Sub

End Class