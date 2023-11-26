Imports MySql.Data.MySqlClient

Public Class claimsForm
    ' Set your MySQL connection string
    Dim connectionString As String = "Server=localhost;Database=examination_system;User ID=root;Password= ;"

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare the SQL query
                Dim query As String = "INSERT INTO claims (studentid, claim) VALUES (@studentid, @claim)"
                Using cmd As New MySqlCommand(query, connection)
                    ' Set the parameter values from the textboxes
                    cmd.Parameters.AddWithValue("@studentid", txtid.Text)
                    cmd.Parameters.AddWithValue("@claim", txtclaim.Text)

                    ' Execute the query
                    cmd.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Data submitted successfully.")
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during the database operation
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        StudentForm.ShowDialog()
    End Sub
End Class
